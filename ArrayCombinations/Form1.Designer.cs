namespace ArrayCombinations
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.rbEfficiency = new System.Windows.Forms.RadioButton();
            this.rbSum = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMandatory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMinSum = new System.Windows.Forms.NumericUpDown();
            this.gbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinSum)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 234);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(6, 323);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(1186, 364);
            this.txtLog.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(126, 22);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(637, 26);
            this.txtInput.TabIndex = 2;
            this.txtInput.Text = "62.00,57.50,51.00,49.99,36.00,26.70,23.45,19.50,16.50,13.95,12.50,11.07,10.50,9.9" +
    "8,9.84,9.00";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1010, 234);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.rbEfficiency);
            this.gbOrder.Controls.Add(this.rbSum);
            this.gbOrder.Location = new System.Drawing.Point(27, 191);
            this.gbOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOrder.Size = new System.Drawing.Size(273, 89);
            this.gbOrder.TabIndex = 6;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Order By";
            // 
            // rbEfficiency
            // 
            this.rbEfficiency.AutoSize = true;
            this.rbEfficiency.Location = new System.Drawing.Point(146, 43);
            this.rbEfficiency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbEfficiency.Name = "rbEfficiency";
            this.rbEfficiency.Size = new System.Drawing.Size(102, 24);
            this.rbEfficiency.TabIndex = 1;
            this.rbEfficiency.TabStop = true;
            this.rbEfficiency.Text = "Efficiency";
            this.rbEfficiency.UseVisualStyleBackColor = true;
            // 
            // rbSum
            // 
            this.rbSum.AutoSize = true;
            this.rbSum.Checked = true;
            this.rbSum.Location = new System.Drawing.Point(9, 43);
            this.rbSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbSum.Name = "rbSum";
            this.rbSum.Size = new System.Drawing.Size(100, 24);
            this.rbSum.TabIndex = 0;
            this.rbSum.TabStop = true;
            this.rbSum.Text = "Max Sum";
            this.rbSum.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "All numbers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mandatory numbers:";
            // 
            // txtMandatory
            // 
            this.txtMandatory.Location = new System.Drawing.Point(184, 62);
            this.txtMandatory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMandatory.Name = "txtMandatory";
            this.txtMandatory.Size = new System.Drawing.Size(578, 26);
            this.txtMandatory.TabIndex = 8;
            this.txtMandatory.Text = "36.00,16.50,10.50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(794, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Min pack sum:";
            // 
            // nudMinSum
            // 
            this.nudMinSum.DecimalPlaces = 1;
            this.nudMinSum.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudMinSum.Location = new System.Drawing.Point(915, 18);
            this.nudMinSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudMinSum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMinSum.Name = "nudMinSum";
            this.nudMinSum.Size = new System.Drawing.Size(74, 26);
            this.nudMinSum.TabIndex = 11;
            this.nudMinSum.ThousandsSeparator = true;
            this.nudMinSum.Value = new decimal(new int[] {
            73,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.nudMinSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMandatory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinSum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.RadioButton rbEfficiency;
        private System.Windows.Forms.RadioButton rbSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMandatory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMinSum;
    }
}

