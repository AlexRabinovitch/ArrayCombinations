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
            this.button1.Location = new System.Drawing.Point(362, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 524);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(646, 238);
            this.txtLog.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(84, 14);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(426, 212);
            this.txtInput.TabIndex = 2;
            this.txtInput.Text = "62.00,57.50,51.00,49.99,30.00,26.70,23.45,19.50,14.95,14.49,13.95,12.50,10.50,9.9" +
    "8,9.84,9.00,8.90,8.00,7.99";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(543, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // gbOrder
            // 
            this.gbOrder.Controls.Add(this.rbEfficiency);
            this.gbOrder.Controls.Add(this.rbSum);
            this.gbOrder.Location = new System.Drawing.Point(18, 443);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(182, 58);
            this.gbOrder.TabIndex = 6;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Order By";
            // 
            // rbEfficiency
            // 
            this.rbEfficiency.AutoSize = true;
            this.rbEfficiency.Location = new System.Drawing.Point(97, 28);
            this.rbEfficiency.Name = "rbEfficiency";
            this.rbEfficiency.Size = new System.Drawing.Size(71, 17);
            this.rbEfficiency.TabIndex = 1;
            this.rbEfficiency.TabStop = true;
            this.rbEfficiency.Text = "Efficiency";
            this.rbEfficiency.UseVisualStyleBackColor = true;
            // 
            // rbSum
            // 
            this.rbSum.AutoSize = true;
            this.rbSum.Checked = true;
            this.rbSum.Location = new System.Drawing.Point(6, 28);
            this.rbSum.Name = "rbSum";
            this.rbSum.Size = new System.Drawing.Size(69, 17);
            this.rbSum.TabIndex = 0;
            this.rbSum.TabStop = true;
            this.rbSum.Text = "Max Sum";
            this.rbSum.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "All numbers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mandatory numbers:";
            // 
            // txtMandatory
            // 
            this.txtMandatory.Location = new System.Drawing.Point(123, 256);
            this.txtMandatory.Multiline = true;
            this.txtMandatory.Name = "txtMandatory";
            this.txtMandatory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMandatory.Size = new System.Drawing.Size(387, 112);
            this.txtMandatory.TabIndex = 8;
            this.txtMandatory.Text = "62.00,26.70,23.45,13.95,12.50,9.84";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 407);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
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
            this.nudMinSum.Location = new System.Drawing.Point(96, 405);
            this.nudMinSum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMinSum.Name = "nudMinSum";
            this.nudMinSum.Size = new System.Drawing.Size(49, 20);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 774);
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

