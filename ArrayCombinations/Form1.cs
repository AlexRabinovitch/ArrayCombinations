using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayCombinations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] _input = null;
        List<double> _sums = null;
        double _minSum = 73;
        //List<List<Pack>> _packs = null;
        List<PackSet> _packs = null;
        StringBuilder _logSB = null;

        private void Button1_Click(object sender, EventArgs e)
        {
            ClearLog();

            _input = SplitInputToDoubleArray(txtInput.Text);

            _sums = new List<double>();

            double[] mandatoryInput = SplitInputToDoubleArray(txtMandatory.Text); ;

            _minSum = (double)nudMinSum.Value;

            LogMessage($"Starting to work on {_input.Length} numbers. Sum = {_input.Sum()}");

            //int numOfIterations = Convert.ToInt32(Math.Floor(_input.Sum() / 75));

            List<double> lstInput = _input.ToList();

            _packs = new List<PackSet>();

            Stopwatch swTotal = new Stopwatch();
            swTotal.Start();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            GetAllPacks(lstInput, new List<Pack>());

            sw.Stop();
            long elapsedSeconds = sw.ElapsedMilliseconds / 1000;

            LogMessage($"GetAllPacks() time: {elapsedSeconds} seconds, packs number: {_packs.Count}");

            _packs = ProcessMandatoryNumbers(mandatoryInput);

            sw.Reset();
            sw.Start();

            _packs = _packs.Distinct().ToList();

            sw.Stop();
            elapsedSeconds = sw.ElapsedMilliseconds / 1000;
            LogMessage($"Distinct() time: {elapsedSeconds} seconds, packs number: {_packs.Count}");

            sw.Reset();
            sw.Start();

            if (rbSum.Checked)
            {
                _packs = _packs.OrderByDescending(elm => elm.Sum).ToList();
            }
            else
            {
                _packs = _packs.OrderBy(elm => ((elm.Packs.Count * 75) % elm.Sum)).ToList();
            }
            sw.Stop();
            elapsedSeconds = sw.ElapsedMilliseconds / 1000;
            LogMessage($"Ordering time: {elapsedSeconds} seconds, packs number: {_packs.Count}");

            sw.Reset();
            sw.Start();

            StartMessage();

            for(int i = 0; i < _packs.Count; i++)
            {
                AppendMessage($"******** OPTION {i + 1} ********");

                AppendMessage("Sum: " + _packs[i].Sum);

                _packs[i].Packs.ForEach(elm => AppendMessage("Total: " + elm.Sum + " => " + string.Join(", ", elm.Sums)));

                AppendMessage("**************************");
            }
            sw.Stop();
            elapsedSeconds = sw.ElapsedMilliseconds / 1000;
            LogMessage($"Message building time: {elapsedSeconds} seconds, packs number: {_packs.Count}");

            swTotal.Stop();
            elapsedSeconds = swTotal.ElapsedMilliseconds / 1000;
            LogMessage($"Total time: {elapsedSeconds} seconds");

            EndMessage();
        }

        private double[] SplitInputToDoubleArray(string strInput)
        {
            string[] arrStrInput = null;
            if (strInput != string.Empty)
            {
                if(strInput.Contains(","))
                    arrStrInput = strInput.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                else if(strInput.Contains(Environment.NewLine))
                    arrStrInput = strInput.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            }

            double[] arrInput = null;
            if (arrStrInput != null && arrStrInput.Length > 0)
                arrInput = Array.ConvertAll(arrStrInput, element => double.Parse(element));

            return arrInput;
        }

        private List<PackSet> ProcessMandatoryNumbers(double[] mandatoryInput)
        {
            if (mandatoryInput == null || mandatoryInput.Length <= 0)
                return _packs;

            List<PackSet> lstPacks = new List<PackSet>();

            foreach(PackSet packSet in _packs)
            {
                if (PackSetHasAllMandatory(packSet, mandatoryInput))
                    lstPacks.Add(packSet);
            }

            return lstPacks;
        }

        private bool PackSetHasAllMandatory(PackSet packSet, double[] mandatoryInput)
        {
            foreach(double sum in mandatoryInput)
            {
                bool found = false;

                foreach(Pack pack in packSet.Packs)
                {
                    if (pack.Sums.Contains(sum))
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                    return false;
                else
                    found = false;
            }

            return true;
        }

        private void GetAllPacks(List<double> lstInput, List<Pack> lstPacks)
        {
            List<Pack> lstResult = GetAllCombos(lstInput);

            //IEnumerable<Pack> filteredResult = lstResult.Where(elm => (elm.Sum <= 75 && elm.Sum >= _minSum)).Distinct().OrderByDescending(elm => elm.Sum).ToList();
            IEnumerable<Pack> filteredResult = lstResult.Distinct().OrderByDescending(elm => elm.Sum).ToList();

            foreach (Pack pack in filteredResult)
            //Parallel.ForEach(result, pack =>
            {
                //lstPacks.Add(new List<Pack>());
                //lstPacks.Last().Add(pack);

                List<Pack> lstNewPacks = new List<Pack>(lstPacks);

                lstNewPacks.Add(pack);

                List<double> lstInputTrimmed = new List<double>(lstInput);
                foreach (double sum in pack.Sums)
                    lstInputTrimmed.Remove(sum);

                GetAllPacks(lstInputTrimmed, lstNewPacks);
            //});
            }

            if(filteredResult.Count() == 0)
            {
                _packs.Add(new PackSet { Packs = lstPacks });
            }

            //result.ForEach(elm => LogMessage("Total: " + elm.Sum + " => " + string.Join(", ", elm.Sums)));
            //lstPacks.ForEach(elm => LogMessage("Total: " + elm[0].Sum + " => " + string.Join(", ", elm[0].Sums)));
        }

        private List<Pack> GetAllCombos(List<double> list)
        {
            int comboCount = (int)Math.Pow(2, list.Count) - 1;
            //List<List<T>> result = new List<List<T>>();
            List<Pack> result = new List<Pack>();
            for (int i = 1; i < comboCount + 1; i++)
            {
                // make each combo here
                Pack pack = new Pack();
                bool isRelevantPack = true;
                //result.Add(new Pack());
                for (int j = 0; j < list.Count; j++)
                {
                    if ((i >> j) % 2 != 0)
                    {
                        //result.Last().Sums.Add(list[j]);
                        double currentSum = list[j];
                        if (pack.Sum + currentSum <= 75)
                        {
                            pack.Sums.Add(currentSum);
                        }
                        else
                        {
                            isRelevantPack = false;
                            break;
                        }
                    }
                }
                if(pack.Sum >= _minSum)
                {
                    if (isRelevantPack)
                        result.Add(pack);
                }
            }
            return result;
        }

        private void ClearLog()
        {
            txtLog.Clear();
        }

        private void LogMessage(string message)
        {
            txtLog.Text += Environment.NewLine + DateTime.Now + " " + message;
        }

        private void LogError(string message)
        {
            LogMessage("Error: " + message);
        }

        private void StartMessage()
        {
            _logSB = new StringBuilder();
        }

        private void AppendMessage(string message)
        {
            if (_logSB == null)
                StartMessage();

            _logSB.Append(Environment.NewLine + message);
        }

        private void EndMessage()
        {
            if (_logSB != null)
                txtLog.Text += _logSB.ToString();

            _logSB = null;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            List<PackSet> lstPackSets = new List<PackSet>();

            Pack p1 = new Pack();
            p1.Sums.Add(32.95);
            p1.Sums.Add(24);
            p1.Sums.Add(10);
            p1.Sums.Add(8);

            Pack p2 = new Pack();
            p1.Sums.Add(28.77);
            p1.Sums.Add(16);
            p1.Sums.Add(15);
            p1.Sums.Add(15);

            Pack p3 = new Pack();
            p1.Sums.Add(55);
            p1.Sums.Add(19.5);

            PackSet ps1 = new PackSet();
            ps1.Packs.Add(p1);
            ps1.Packs.Add(p2);
            ps1.Packs.Add(p3);

            PackSet ps2 = new PackSet();
            ps2.Packs.Add(p1);
            ps2.Packs.Add(p3);
            ps2.Packs.Add(p2);

            lstPackSets.Add(ps1);
            lstPackSets.Add(ps2);

            MessageBox.Show(lstPackSets.Count.ToString());

            lstPackSets = lstPackSets.Distinct().ToList();

            MessageBox.Show(lstPackSets.Count.ToString());
        }
    }

    class SumList : List<double>
    {
        public SumList() : base()
        {
        }

        public double Sum { get; private set; }
        public new void Add(double item)
        {
            base.Add(item);
            Sum += item;
        }

        public new void AddRange(IEnumerable<double> collection)
        {
            base.AddRange(collection);
            Sum = this.Sum();
        }

        public new bool Remove(double item)
        {
            bool result = base.Remove(item);
            if (result)
                Sum -= item;

            return result;
        }

        public new int RemoveAll(Predicate<double> match)
        {
            int result = base.RemoveAll(match);
            Sum = this.Sum();
            return result;
        }

        public new void RemoveAt(int index)
        {
            base.RemoveAt(index);
            Sum = this.Sum();
        }

        public new void RemoveRange(int index, int count)
        {
            base.RemoveRange(index, count);
            Sum = this.Sum();
        }
    }

    class Pack : IEquatable<Pack>
    {
        public double Sum
        {
            get
            {
                //return Sums.Sum();
                return Sums.Sum;
            }
        }


        public List<int> Numbers { get; set; }

        public SumList Sums { get; set; }

        public Pack()
        {
            //Sum = 0;
            Numbers = new List<int>();
            Sums = new SumList();
        }

        public override bool Equals(object other)
        {
            return Equals(other as Pack);
        }

        public bool Equals(Pack other)
        {
            if (other == null)
                return false;

            if (other.Sums.Count != this.Sums.Count)
                return false;

            for(int i = 0; i < other.Sums.Count; i++)
            {
                if (other.Sums[i] != this.Sums[i])
                    return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hashcode = Sum.GetHashCode();

            foreach (double sum in Sums)
                hashcode = hashcode ^ sum.GetHashCode();

            return hashcode;
        }
    }

    class PackSet : IEquatable<PackSet>
    {
        public List<Pack> Packs { get; set; }

        public double Sum
        {
            get
            {
                return Packs.Sum(elm => elm.Sum);
            }
        }

        public PackSet()
        {
            Packs = new List<Pack>();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as PackSet);
        }

        public bool Equals(PackSet other)
        {
            if (other == null)
                return false;

            if (other.Packs.Count != this.Packs.Count)
                return false;

            if (other.Sum != this.Sum)
                return false;

            foreach(Pack thisPack in this.Packs)
            {
                if (!FindEqualPack(thisPack, other))
                    return false;
            }

            return true;
        }

        private bool FindEqualPack(Pack thisPack, PackSet otherSet)
        {
            foreach(Pack otherPack in otherSet.Packs)
            {
                if (ArePacksEqual(thisPack, otherPack))
                    return true;
            }
            return false;
        }

        private bool ArePacksEqual(Pack thisPack, Pack otherPack)
        {
            if (thisPack.Sums.Count != otherPack.Sums.Count)
                return false;

            if (thisPack.Sum != otherPack.Sum)
                return false;

            for (int i = 0; i < thisPack.Sums.Count; i++)
            {
                if (thisPack.Sums[i] != otherPack.Sums[i])
                    return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            int hashcode = Sum.GetHashCode();

            foreach(Pack pack in Packs)
            {
                foreach (double sum in pack.Sums)
                    hashcode = hashcode ^ sum.GetHashCode();
            }

            return hashcode;
        }
    }

    public static class Extensions
    {
        public static List<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }
    }

}
