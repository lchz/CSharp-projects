namespace FutureValue
{
    partial class FutureValueForm
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
            this.labMonInvestment = new System.Windows.Forms.Label();
            this.labYearlyInterestRate = new System.Windows.Forms.Label();
            this.labNumYears = new System.Windows.Forms.Label();
            this.labFutureValue = new System.Windows.Forms.Label();
            this.txtMonInvestment = new System.Windows.Forms.TextBox();
            this.txtYearlyInterestRate = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboNumberOfYears = new System.Windows.Forms.ComboBox();
            this.lstFutureValue = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labMonInvestment
            // 
            this.labMonInvestment.AutoSize = true;
            this.labMonInvestment.Location = new System.Drawing.Point(25, 28);
            this.labMonInvestment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMonInvestment.Name = "labMonInvestment";
            this.labMonInvestment.Size = new System.Drawing.Size(151, 20);
            this.labMonInvestment.TabIndex = 0;
            this.labMonInvestment.Text = "Monthly Investment:";
            // 
            // labYearlyInterestRate
            // 
            this.labYearlyInterestRate.AutoSize = true;
            this.labYearlyInterestRate.Location = new System.Drawing.Point(25, 82);
            this.labYearlyInterestRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labYearlyInterestRate.Name = "labYearlyInterestRate";
            this.labYearlyInterestRate.Size = new System.Drawing.Size(155, 20);
            this.labYearlyInterestRate.TabIndex = 1;
            this.labYearlyInterestRate.Text = "Yearly Interest Rate:";
            // 
            // labNumYears
            // 
            this.labNumYears.AutoSize = true;
            this.labNumYears.Location = new System.Drawing.Point(25, 139);
            this.labNumYears.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNumYears.Name = "labNumYears";
            this.labNumYears.Size = new System.Drawing.Size(133, 20);
            this.labNumYears.TabIndex = 2;
            this.labNumYears.Text = "Number of Years:";
            // 
            // labFutureValue
            // 
            this.labFutureValue.AutoSize = true;
            this.labFutureValue.Location = new System.Drawing.Point(25, 194);
            this.labFutureValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFutureValue.Name = "labFutureValue";
            this.labFutureValue.Size = new System.Drawing.Size(105, 20);
            this.labFutureValue.TabIndex = 3;
            this.labFutureValue.Text = "Future Value:";
            // 
            // txtMonInvestment
            // 
            this.txtMonInvestment.Location = new System.Drawing.Point(196, 27);
            this.txtMonInvestment.Name = "txtMonInvestment";
            this.txtMonInvestment.Size = new System.Drawing.Size(100, 26);
            this.txtMonInvestment.TabIndex = 4;
            this.txtMonInvestment.TextChanged += new System.EventHandler(this.ClearFutureValue);
            this.txtMonInvestment.MouseHover += new System.EventHandler(this.ClearFutureValue);
            // 
            // txtYearlyInterestRate
            // 
            this.txtYearlyInterestRate.Location = new System.Drawing.Point(196, 79);
            this.txtYearlyInterestRate.Name = "txtYearlyInterestRate";
            this.txtYearlyInterestRate.Size = new System.Drawing.Size(100, 26);
            this.txtYearlyInterestRate.TabIndex = 5;
            this.txtYearlyInterestRate.TextChanged += new System.EventHandler(this.ClearFutureValue);
            this.txtYearlyInterestRate.DoubleClick += new System.EventHandler(this.txtYearlyInterestRate_DoubleClick);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(196, 374);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(87, 31);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(325, 374);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 31);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboNumberOfYears
            // 
            this.cboNumberOfYears.DropDownHeight = 70;
            this.cboNumberOfYears.FormattingEnabled = true;
            this.cboNumberOfYears.IntegralHeight = false;
            this.cboNumberOfYears.Location = new System.Drawing.Point(196, 137);
            this.cboNumberOfYears.Name = "cboNumberOfYears";
            this.cboNumberOfYears.Size = new System.Drawing.Size(100, 28);
            this.cboNumberOfYears.TabIndex = 6;
            // 
            // lstFutureValue
            // 
            this.lstFutureValue.FormattingEnabled = true;
            this.lstFutureValue.ItemHeight = 20;
            this.lstFutureValue.Location = new System.Drawing.Point(196, 194);
            this.lstFutureValue.Name = "lstFutureValue";
            this.lstFutureValue.Size = new System.Drawing.Size(235, 144);
            this.lstFutureValue.TabIndex = 10;
            this.lstFutureValue.TabStop = false;
            // 
            // FutureValueForm
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(513, 432);
            this.Controls.Add(this.lstFutureValue);
            this.Controls.Add(this.cboNumberOfYears);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtYearlyInterestRate);
            this.Controls.Add(this.txtMonInvestment);
            this.Controls.Add(this.labFutureValue);
            this.Controls.Add(this.labNumYears);
            this.Controls.Add(this.labYearlyInterestRate);
            this.Controls.Add(this.labMonInvestment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FutureValueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Value";
            this.Load += new System.EventHandler(this.FutureValueForm_Load);
            this.DoubleClick += new System.EventHandler(this.FutureValueForm_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMonInvestment;
        private System.Windows.Forms.Label labYearlyInterestRate;
        private System.Windows.Forms.Label labNumYears;
        private System.Windows.Forms.Label labFutureValue;
        private System.Windows.Forms.TextBox txtMonInvestment;
        private System.Windows.Forms.TextBox txtYearlyInterestRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cboNumberOfYears;
        private System.Windows.Forms.ListBox lstFutureValue;
    }
}

