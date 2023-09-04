namespace _5_PaymentApplication
{
    partial class frmCustomer
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
            this.labCustomerName = new System.Windows.Forms.Label();
            this.cboCustomerName = new System.Windows.Forms.ComboBox();
            this.labPaymentMethod = new System.Windows.Forms.Label();
            this.btnSelectPayment = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labPayment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labCustomerName
            // 
            this.labCustomerName.AutoSize = true;
            this.labCustomerName.Location = new System.Drawing.Point(36, 43);
            this.labCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCustomerName.Name = "labCustomerName";
            this.labCustomerName.Size = new System.Drawing.Size(126, 20);
            this.labCustomerName.TabIndex = 0;
            this.labCustomerName.Text = "Customer name:";
            // 
            // cboCustomerName
            // 
            this.cboCustomerName.DropDownHeight = 50;
            this.cboCustomerName.FormattingEnabled = true;
            this.cboCustomerName.IntegralHeight = false;
            this.cboCustomerName.Location = new System.Drawing.Point(223, 41);
            this.cboCustomerName.Name = "cboCustomerName";
            this.cboCustomerName.Size = new System.Drawing.Size(213, 28);
            this.cboCustomerName.TabIndex = 1;
            this.cboCustomerName.SelectedIndexChanged += new System.EventHandler(this.cboCustomerName_SelectedIndexChanged);
            // 
            // labPaymentMethod
            // 
            this.labPaymentMethod.AutoSize = true;
            this.labPaymentMethod.Location = new System.Drawing.Point(36, 100);
            this.labPaymentMethod.Name = "labPaymentMethod";
            this.labPaymentMethod.Size = new System.Drawing.Size(133, 20);
            this.labPaymentMethod.TabIndex = 2;
            this.labPaymentMethod.Text = "Payment method:";
            // 
            // btnSelectPayment
            // 
            this.btnSelectPayment.Location = new System.Drawing.Point(400, 137);
            this.btnSelectPayment.Name = "btnSelectPayment";
            this.btnSelectPayment.Size = new System.Drawing.Size(145, 31);
            this.btnSelectPayment.TabIndex = 4;
            this.btnSelectPayment.Text = "Select Payment";
            this.btnSelectPayment.UseVisualStyleBackColor = true;
            this.btnSelectPayment.Click += new System.EventHandler(this.btnSelectPayment_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(262, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(400, 319);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labPayment
            // 
            this.labPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labPayment.Location = new System.Drawing.Point(40, 141);
            this.labPayment.Name = "labPayment";
            this.labPayment.Size = new System.Drawing.Size(327, 143);
            this.labPayment.TabIndex = 7;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(575, 377);
            this.Controls.Add(this.labPayment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectPayment);
            this.Controls.Add(this.labPaymentMethod);
            this.Controls.Add(this.cboCustomerName);
            this.Controls.Add(this.labCustomerName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomer_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCustomerName;
        private System.Windows.Forms.ComboBox cboCustomerName;
        private System.Windows.Forms.Label labPaymentMethod;
        private System.Windows.Forms.Button btnSelectPayment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labPayment;
    }
}

