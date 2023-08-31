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
            this.labPercentMark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labSubtotal
            // 
            this.labSubtotal.AutoSize = true;
            this.labSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSubtotal.Location = new System.Drawing.Point(40, 45);
            this.labSubtotal.Name = "labSubtotal";
            this.labSubtotal.Size = new System.Drawing.Size(73, 20);
            this.labSubtotal.TabIndex = 0;
            this.labSubtotal.Text = "&Subtotal:";
            // 
            // labDisPercent
            // 
            this.labDisPercent.AutoSize = true;
            this.labDisPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDisPercent.Location = new System.Drawing.Point(40, 92);
            this.labDisPercent.Name = "labDisPercent";
            this.labDisPercent.Size = new System.Drawing.Size(135, 20);
            this.labDisPercent.TabIndex = 1;
            this.labDisPercent.Text = "&Discount Percent:";
            // 
            // labDisAmount
            // 
            this.labDisAmount.AutoSize = true;
            this.labDisAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDisAmount.Location = new System.Drawing.Point(40, 140);
            this.labDisAmount.Name = "labDisAmount";
            this.labDisAmount.Size = new System.Drawing.Size(136, 20);
            this.labDisAmount.TabIndex = 2;
            this.labDisAmount.Text = "Discount &Amount:";
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTotal.Location = new System.Drawing.Point(40, 193);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(48, 20);
            this.labTotal.TabIndex = 3;
            this.labTotal.Text = "&Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSubtotal.Location = new System.Drawing.Point(184, 45);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 26);
            this.txtSubtotal.TabIndex = 4;
            this.txtSubtotal.Text = "Enter Price";
            // 
            // txtDisPercent
            // 
            this.txtDisPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDisPercent.Location = new System.Drawing.Point(184, 92);
            this.txtDisPercent.Name = "txtDisPercent";
            this.txtDisPercent.ReadOnly = true;
            this.txtDisPercent.Size = new System.Drawing.Size(48, 26);
            this.txtDisPercent.TabIndex = 5;
            this.txtDisPercent.TabStop = false;
            this.txtDisPercent.Text = "10.0";
            // 
            // txtDisAmount
            // 
            this.txtDisAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDisAmount.Location = new System.Drawing.Point(184, 140);
            this.txtDisAmount.Name = "txtDisAmount";
            this.txtDisAmount.Size = new System.Drawing.Size(100, 26);
            this.txtDisAmount.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTotal.Location = new System.Drawing.Point(184, 193);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCalculate.Location = new System.Drawing.Point(82, 265);
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
            this.btnExit.Location = new System.Drawing.Point(199, 265);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labPercentMark
            // 
            this.labPercentMark.AutoSize = true;
            this.labPercentMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPercentMark.Location = new System.Drawing.Point(233, 95);
            this.labPercentMark.Name = "labPercentMark";
            this.labPercentMark.Size = new System.Drawing.Size(23, 20);
            this.labPercentMark.TabIndex = 10;
            this.labPercentMark.Text = "%";
            // 
            // InvoiceTotal
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(347, 341);
            this.Controls.Add(this.labPercentMark);
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
        private System.Windows.Forms.Label labPercentMark;
    }
}

