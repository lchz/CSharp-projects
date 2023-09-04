namespace _5_PaymentApplication
{
    partial class frmPayment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labCreditCardType = new System.Windows.Forms.Label();
            this.lstCreditCardType = new System.Windows.Forms.ListBox();
            this.labCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.labExpDate = new System.Windows.Forms.Label();
            this.cboExpMonth = new System.Windows.Forms.ComboBox();
            this.cboExpYear = new System.Windows.Forms.ComboBox();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdoCreditCard = new System.Windows.Forms.RadioButton();
            this.rdoBillCustomer = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBillCustomer);
            this.groupBox1.Controls.Add(this.rdoCreditCard);
            this.groupBox1.Location = new System.Drawing.Point(34, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(465, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing";
            // 
            // labCreditCardType
            // 
            this.labCreditCardType.AutoSize = true;
            this.labCreditCardType.Location = new System.Drawing.Point(34, 165);
            this.labCreditCardType.Name = "labCreditCardType";
            this.labCreditCardType.Size = new System.Drawing.Size(124, 20);
            this.labCreditCardType.TabIndex = 1;
            this.labCreditCardType.Text = "Credit card type:";
            // 
            // lstCreditCardType
            // 
            this.lstCreditCardType.FormattingEnabled = true;
            this.lstCreditCardType.ItemHeight = 20;
            this.lstCreditCardType.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "American Express"});
            this.lstCreditCardType.Location = new System.Drawing.Point(195, 153);
            this.lstCreditCardType.Name = "lstCreditCardType";
            this.lstCreditCardType.ScrollAlwaysVisible = true;
            this.lstCreditCardType.Size = new System.Drawing.Size(304, 84);
            this.lstCreditCardType.TabIndex = 2;
            // 
            // labCardNumber
            // 
            this.labCardNumber.AutoSize = true;
            this.labCardNumber.Location = new System.Drawing.Point(38, 266);
            this.labCardNumber.Name = "labCardNumber";
            this.labCardNumber.Size = new System.Drawing.Size(105, 20);
            this.labCardNumber.TabIndex = 3;
            this.labCardNumber.Text = "Card number:";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(195, 265);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(304, 26);
            this.txtCardNumber.TabIndex = 4;
            // 
            // labExpDate
            // 
            this.labExpDate.AutoSize = true;
            this.labExpDate.Location = new System.Drawing.Point(34, 313);
            this.labExpDate.Name = "labExpDate";
            this.labExpDate.Size = new System.Drawing.Size(119, 20);
            this.labExpDate.TabIndex = 5;
            this.labExpDate.Text = "Expiration date:";
            // 
            // cboExpMonth
            // 
            this.cboExpMonth.DropDownHeight = 100;
            this.cboExpMonth.FormattingEnabled = true;
            this.cboExpMonth.IntegralHeight = false;
            this.cboExpMonth.Items.AddRange(new object[] {
            "Select a month...",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cboExpMonth.Location = new System.Drawing.Point(195, 310);
            this.cboExpMonth.Name = "cboExpMonth";
            this.cboExpMonth.Size = new System.Drawing.Size(140, 28);
            this.cboExpMonth.TabIndex = 6;
            // 
            // cboExpYear
            // 
            this.cboExpYear.DropDownHeight = 100;
            this.cboExpYear.FormattingEnabled = true;
            this.cboExpYear.IntegralHeight = false;
            this.cboExpYear.Location = new System.Drawing.Point(359, 310);
            this.cboExpYear.Name = "cboExpYear";
            this.cboExpYear.Size = new System.Drawing.Size(140, 28);
            this.cboExpYear.TabIndex = 7;
            // 
            // chkDefault
            // 
            this.chkDefault.AutoSize = true;
            this.chkDefault.Checked = true;
            this.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDefault.Location = new System.Drawing.Point(38, 371);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(228, 24);
            this.chkDefault.TabIndex = 8;
            this.chkDefault.Text = "Set as default billing method";
            this.chkDefault.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(262, 424);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 31);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(388, 424);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 31);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdoCreditCard
            // 
            this.rdoCreditCard.AutoSize = true;
            this.rdoCreditCard.Checked = true;
            this.rdoCreditCard.Location = new System.Drawing.Point(26, 38);
            this.rdoCreditCard.Name = "rdoCreditCard";
            this.rdoCreditCard.Size = new System.Drawing.Size(104, 24);
            this.rdoCreditCard.TabIndex = 0;
            this.rdoCreditCard.TabStop = true;
            this.rdoCreditCard.Text = "Credit card";
            this.rdoCreditCard.UseVisualStyleBackColor = true;
            this.rdoCreditCard.CheckedChanged += new System.EventHandler(this.rdoCreditCard_CheckedChanged);
            // 
            // rdoBillCustomer
            // 
            this.rdoBillCustomer.AutoSize = true;
            this.rdoBillCustomer.Location = new System.Drawing.Point(214, 38);
            this.rdoBillCustomer.Name = "rdoBillCustomer";
            this.rdoBillCustomer.Size = new System.Drawing.Size(117, 24);
            this.rdoBillCustomer.TabIndex = 1;
            this.rdoBillCustomer.TabStop = true;
            this.rdoBillCustomer.Text = "Bill customer";
            this.rdoBillCustomer.UseVisualStyleBackColor = true;
            this.rdoBillCustomer.CheckedChanged += new System.EventHandler(this.rdoBillCustomer_CheckedChanged);
            // 
            // frmPayment
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(545, 478);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkDefault);
            this.Controls.Add(this.cboExpYear);
            this.Controls.Add(this.cboExpMonth);
            this.Controls.Add(this.labExpDate);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.labCardNumber);
            this.Controls.Add(this.lstCreditCardType);
            this.Controls.Add(this.labCreditCardType);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labCreditCardType;
        private System.Windows.Forms.ListBox lstCreditCardType;
        private System.Windows.Forms.Label labCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label labExpDate;
        private System.Windows.Forms.ComboBox cboExpMonth;
        private System.Windows.Forms.ComboBox cboExpYear;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdoCreditCard;
        private System.Windows.Forms.RadioButton rdoBillCustomer;
    }
}