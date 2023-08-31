namespace WindowsFormsApp2
{
    partial class InvoiceTotal
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

        //private void InitializeComponent()
        //{




        //}

        //#endregion




    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
        private void InitializeComponent()
    {
            this.labSubtotal = new System.Windows.Forms.Label();
            this.labDisPercent = new System.Windows.Forms.Label();
            this.labDisAmount = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDisPercent = new System.Windows.Forms.TextBox();
            this.txtDisAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearTotals = new System.Windows.Forms.Button();
            this.labNumInvoices = new System.Windows.Forms.Label();
            this.labTotalInvoices = new System.Windows.Forms.Label();
            this.labInvoiceAve = new System.Windows.Forms.Label();
            this.txtNumInvoices = new System.Windows.Forms.TextBox();
            this.txtTotalInvoices = new System.Windows.Forms.TextBox();
            this.txtInvoiceAve = new System.Windows.Forms.TextBox();
            this.labEnterSubtotal = new System.Windows.Forms.Label();
            this.txtEnterSubtotal = new System.Windows.Forms.TextBox();
            this.labLargestInvoice = new System.Windows.Forms.Label();
            this.txtLargestInvoice = new System.Windows.Forms.TextBox();
            this.labSmallestInvoice = new System.Windows.Forms.Label();
            this.txtSmallestInvoice = new System.Windows.Forms.TextBox();
            this.labCustomerType = new System.Windows.Forms.Label();
            this.txtCustomerType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labSubtotal
            // 
            this.labSubtotal.AutoSize = true;
            this.labSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSubtotal.Location = new System.Drawing.Point(55, 133);
            this.labSubtotal.Name = "labSubtotal";
            this.labSubtotal.Size = new System.Drawing.Size(73, 20);
            this.labSubtotal.TabIndex = 0;
            this.labSubtotal.Text = "&Subtotal:";
            // 
            // labDisPercent
            // 
            this.labDisPercent.AutoSize = true;
            this.labDisPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDisPercent.Location = new System.Drawing.Point(54, 183);
            this.labDisPercent.Name = "labDisPercent";
            this.labDisPercent.Size = new System.Drawing.Size(135, 20);
            this.labDisPercent.TabIndex = 1;
            this.labDisPercent.Text = "&Discount Percent:";
            // 
            // labDisAmount
            // 
            this.labDisAmount.AutoSize = true;
            this.labDisAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDisAmount.Location = new System.Drawing.Point(54, 231);
            this.labDisAmount.Name = "labDisAmount";
            this.labDisAmount.Size = new System.Drawing.Size(136, 20);
            this.labDisAmount.TabIndex = 2;
            this.labDisAmount.Text = "Discount &Amount:";
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTotal.Location = new System.Drawing.Point(55, 281);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(48, 20);
            this.labTotal.TabIndex = 3;
            this.labTotal.Text = "&Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSubtotal.Location = new System.Drawing.Point(190, 131);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 26);
            this.txtSubtotal.TabIndex = 4;
            this.txtSubtotal.TabStop = false;
            // 
            // txtDisPercent
            // 
            this.txtDisPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDisPercent.Location = new System.Drawing.Point(190, 178);
            this.txtDisPercent.Name = "txtDisPercent";
            this.txtDisPercent.ReadOnly = true;
            this.txtDisPercent.Size = new System.Drawing.Size(100, 26);
            this.txtDisPercent.TabIndex = 5;
            this.txtDisPercent.TabStop = false;
            // 
            // txtDisAmount
            // 
            this.txtDisAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDisAmount.Location = new System.Drawing.Point(190, 226);
            this.txtDisAmount.Name = "txtDisAmount";
            this.txtDisAmount.ReadOnly = true;
            this.txtDisAmount.Size = new System.Drawing.Size(100, 26);
            this.txtDisAmount.TabIndex = 6;
            this.txtDisAmount.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTotal.Location = new System.Drawing.Point(190, 279);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 7;
            this.txtTotal.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCalculate.Location = new System.Drawing.Point(145, 427);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(90, 30);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(520, 427);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearTotals
            // 
            this.btnClearTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClearTotals.Location = new System.Drawing.Point(323, 427);
            this.btnClearTotals.Name = "btnClearTotals";
            this.btnClearTotals.Size = new System.Drawing.Size(111, 30);
            this.btnClearTotals.TabIndex = 9;
            this.btnClearTotals.Text = "Clear Totals";
            this.btnClearTotals.UseVisualStyleBackColor = true;
            this.btnClearTotals.Click += new System.EventHandler(this.btnClearTotals_Click);
            // 
            // labNumInvoices
            // 
            this.labNumInvoices.AutoSize = true;
            this.labNumInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labNumInvoices.Location = new System.Drawing.Point(386, 139);
            this.labNumInvoices.Name = "labNumInvoices";
            this.labNumInvoices.Size = new System.Drawing.Size(147, 20);
            this.labNumInvoices.TabIndex = 12;
            this.labNumInvoices.Text = "Number of invoices:";
            // 
            // labTotalInvoices
            // 
            this.labTotalInvoices.AutoSize = true;
            this.labTotalInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTotalInvoices.Location = new System.Drawing.Point(386, 187);
            this.labTotalInvoices.Name = "labTotalInvoices";
            this.labTotalInvoices.Size = new System.Drawing.Size(126, 20);
            this.labTotalInvoices.TabIndex = 13;
            this.labTotalInvoices.Text = "Total of invoices:";
            // 
            // labInvoiceAve
            // 
            this.labInvoiceAve.AutoSize = true;
            this.labInvoiceAve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labInvoiceAve.Location = new System.Drawing.Point(386, 240);
            this.labInvoiceAve.Name = "labInvoiceAve";
            this.labInvoiceAve.Size = new System.Drawing.Size(124, 20);
            this.labInvoiceAve.TabIndex = 14;
            this.labInvoiceAve.Text = "Invoice average:";
            // 
            // txtNumInvoices
            // 
            this.txtNumInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNumInvoices.Location = new System.Drawing.Point(531, 138);
            this.txtNumInvoices.Name = "txtNumInvoices";
            this.txtNumInvoices.ReadOnly = true;
            this.txtNumInvoices.Size = new System.Drawing.Size(100, 26);
            this.txtNumInvoices.TabIndex = 15;
            this.txtNumInvoices.TabStop = false;
            // 
            // txtTotalInvoices
            // 
            this.txtTotalInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTotalInvoices.Location = new System.Drawing.Point(531, 186);
            this.txtTotalInvoices.Name = "txtTotalInvoices";
            this.txtTotalInvoices.ReadOnly = true;
            this.txtTotalInvoices.Size = new System.Drawing.Size(100, 26);
            this.txtTotalInvoices.TabIndex = 16;
            this.txtTotalInvoices.TabStop = false;
            // 
            // txtInvoiceAve
            // 
            this.txtInvoiceAve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtInvoiceAve.Location = new System.Drawing.Point(531, 239);
            this.txtInvoiceAve.Name = "txtInvoiceAve";
            this.txtInvoiceAve.ReadOnly = true;
            this.txtInvoiceAve.Size = new System.Drawing.Size(100, 26);
            this.txtInvoiceAve.TabIndex = 17;
            this.txtInvoiceAve.TabStop = false;
            // 
            // labEnterSubtotal
            // 
            this.labEnterSubtotal.AutoSize = true;
            this.labEnterSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labEnterSubtotal.Location = new System.Drawing.Point(55, 46);
            this.labEnterSubtotal.Name = "labEnterSubtotal";
            this.labEnterSubtotal.Size = new System.Drawing.Size(116, 20);
            this.labEnterSubtotal.TabIndex = 0;
            this.labEnterSubtotal.Text = "Enter Subtotal:";
            // 
            // txtEnterSubtotal
            // 
            this.txtEnterSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEnterSubtotal.Location = new System.Drawing.Point(190, 43);
            this.txtEnterSubtotal.Name = "txtEnterSubtotal";
            this.txtEnterSubtotal.Size = new System.Drawing.Size(100, 26);
            this.txtEnterSubtotal.TabIndex = 1;
            // 
            // labLargestInvoice
            // 
            this.labLargestInvoice.AutoSize = true;
            this.labLargestInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLargestInvoice.Location = new System.Drawing.Point(135, 356);
            this.labLargestInvoice.Name = "labLargestInvoice";
            this.labLargestInvoice.Size = new System.Drawing.Size(121, 20);
            this.labLargestInvoice.TabIndex = 18;
            this.labLargestInvoice.Text = "Largest Invoice:";
            // 
            // txtLargestInvoice
            // 
            this.txtLargestInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLargestInvoice.Location = new System.Drawing.Point(252, 350);
            this.txtLargestInvoice.Name = "txtLargestInvoice";
            this.txtLargestInvoice.ReadOnly = true;
            this.txtLargestInvoice.Size = new System.Drawing.Size(100, 26);
            this.txtLargestInvoice.TabIndex = 19;
            this.txtLargestInvoice.TabStop = false;
            // 
            // labSmallestInvoice
            // 
            this.labSmallestInvoice.AutoSize = true;
            this.labSmallestInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSmallestInvoice.Location = new System.Drawing.Point(386, 353);
            this.labSmallestInvoice.Name = "labSmallestInvoice";
            this.labSmallestInvoice.Size = new System.Drawing.Size(128, 20);
            this.labSmallestInvoice.TabIndex = 20;
            this.labSmallestInvoice.Text = "Smallest Invoice:";
            // 
            // txtSmallestInvoice
            // 
            this.txtSmallestInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSmallestInvoice.Location = new System.Drawing.Point(510, 347);
            this.txtSmallestInvoice.Name = "txtSmallestInvoice";
            this.txtSmallestInvoice.ReadOnly = true;
            this.txtSmallestInvoice.Size = new System.Drawing.Size(100, 26);
            this.txtSmallestInvoice.TabIndex = 21;
            // 
            // labCustomerType
            // 
            this.labCustomerType.AutoSize = true;
            this.labCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCustomerType.Location = new System.Drawing.Point(55, 89);
            this.labCustomerType.Name = "labCustomerType";
            this.labCustomerType.Size = new System.Drawing.Size(120, 20);
            this.labCustomerType.TabIndex = 22;
            this.labCustomerType.Text = "Customer Type:";
            // 
            // txtCustomerType
            // 
            this.txtCustomerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustomerType.Location = new System.Drawing.Point(190, 86);
            this.txtCustomerType.Name = "txtCustomerType";
            this.txtCustomerType.Size = new System.Drawing.Size(100, 26);
            this.txtCustomerType.TabIndex = 2;
            this.txtCustomerType.Text = "R/C/T";
            // 
            // InvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(711, 507);
            this.Controls.Add(this.txtCustomerType);
            this.Controls.Add(this.labCustomerType);
            this.Controls.Add(this.txtSmallestInvoice);
            this.Controls.Add(this.labSmallestInvoice);
            this.Controls.Add(this.txtLargestInvoice);
            this.Controls.Add(this.labLargestInvoice);
            this.Controls.Add(this.txtEnterSubtotal);
            this.Controls.Add(this.labEnterSubtotal);
            this.Controls.Add(this.txtInvoiceAve);
            this.Controls.Add(this.txtTotalInvoices);
            this.Controls.Add(this.txtNumInvoices);
            this.Controls.Add(this.labInvoiceAve);
            this.Controls.Add(this.labTotalInvoices);
            this.Controls.Add(this.labNumInvoices);
            this.Controls.Add(this.btnClearTotals);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDisAmount);
            this.Controls.Add(this.txtDisPercent);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.labDisAmount);
            this.Controls.Add(this.labDisPercent);
            this.Controls.Add(this.labSubtotal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "InvoiceTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

        private System.Windows.Forms.Label labSubtotal;
        private System.Windows.Forms.Label labDisPercent;
        private System.Windows.Forms.Label labDisAmount;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDisPercent;
        private System.Windows.Forms.TextBox txtDisAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearTotals;
        private System.Windows.Forms.Label labNumInvoices;
        private System.Windows.Forms.Label labTotalInvoices;
        private System.Windows.Forms.Label labInvoiceAve;
        private System.Windows.Forms.TextBox txtNumInvoices;
        private System.Windows.Forms.TextBox txtTotalInvoices;
        private System.Windows.Forms.TextBox txtInvoiceAve;
        private System.Windows.Forms.Label labEnterSubtotal;
        private System.Windows.Forms.TextBox txtEnterSubtotal;
        private System.Windows.Forms.Label labLargestInvoice;
        private System.Windows.Forms.TextBox txtLargestInvoice;
        private System.Windows.Forms.Label labSmallestInvoice;
        private System.Windows.Forms.TextBox txtSmallestInvoice;
        private System.Windows.Forms.Label labCustomerType;
        private System.Windows.Forms.TextBox txtCustomerType;
    }
}

