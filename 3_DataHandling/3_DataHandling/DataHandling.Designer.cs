namespace _3_DataHandling
{
    partial class DataHandlingForm
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
            this.labCurrentDate = new System.Windows.Forms.Label();
            this.labFutureDate = new System.Windows.Forms.Label();
            this.labDaysUntilDue = new System.Windows.Forms.Label();
            this.txtFutureDate = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.strCurrentDate = new System.Windows.Forms.Label();
            this.strDaysUntilDue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labCurrentDate
            // 
            this.labCurrentDate.AutoSize = true;
            this.labCurrentDate.Location = new System.Drawing.Point(20, 50);
            this.labCurrentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCurrentDate.Name = "labCurrentDate";
            this.labCurrentDate.Size = new System.Drawing.Size(102, 20);
            this.labCurrentDate.TabIndex = 0;
            this.labCurrentDate.Text = "Current date:";
            // 
            // labFutureDate
            // 
            this.labFutureDate.AutoSize = true;
            this.labFutureDate.Location = new System.Drawing.Point(20, 110);
            this.labFutureDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFutureDate.Name = "labFutureDate";
            this.labFutureDate.Size = new System.Drawing.Size(96, 20);
            this.labFutureDate.TabIndex = 1;
            this.labFutureDate.Text = "Future date:";
            // 
            // labDaysUntilDue
            // 
            this.labDaysUntilDue.AutoSize = true;
            this.labDaysUntilDue.Location = new System.Drawing.Point(20, 170);
            this.labDaysUntilDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDaysUntilDue.Name = "labDaysUntilDue";
            this.labDaysUntilDue.Size = new System.Drawing.Size(113, 20);
            this.labDaysUntilDue.TabIndex = 2;
            this.labDaysUntilDue.Text = "Days until due:";
            // 
            // txtFutureDate
            // 
            this.txtFutureDate.Location = new System.Drawing.Point(169, 108);
            this.txtFutureDate.Name = "txtFutureDate";
            this.txtFutureDate.Size = new System.Drawing.Size(100, 26);
            this.txtFutureDate.TabIndex = 0;
            this.txtFutureDate.TextChanged += new System.EventHandler(this.txtFutureDate_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(202, 245);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 36);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // strCurrentDate
            // 
            this.strCurrentDate.AutoSize = true;
            this.strCurrentDate.Location = new System.Drawing.Point(169, 50);
            this.strCurrentDate.Name = "strCurrentDate";
            this.strCurrentDate.Size = new System.Drawing.Size(0, 20);
            this.strCurrentDate.TabIndex = 7;
            this.strCurrentDate.TextChanged += new System.EventHandler(this.txtCurrentDate_TextChanged);
            // 
            // strDaysUntilDue
            // 
            this.strDaysUntilDue.AutoSize = true;
            this.strDaysUntilDue.Location = new System.Drawing.Point(169, 170);
            this.strDaysUntilDue.Name = "strDaysUntilDue";
            this.strDaysUntilDue.Size = new System.Drawing.Size(0, 20);
            this.strDaysUntilDue.TabIndex = 8;
            // 
            // DataHandlingForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 309);
            this.Controls.Add(this.strDaysUntilDue);
            this.Controls.Add(this.strCurrentDate);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtFutureDate);
            this.Controls.Add(this.labDaysUntilDue);
            this.Controls.Add(this.labFutureDate);
            this.Controls.Add(this.labCurrentDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DataHandlingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Due Days Calculation";
            this.Load += new System.EventHandler(this.txtCurrentDate_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCurrentDate;
        private System.Windows.Forms.Label labFutureDate;
        private System.Windows.Forms.Label labDaysUntilDue;
        private System.Windows.Forms.TextBox txtFutureDate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label strCurrentDate;
        private System.Windows.Forms.Label strDaysUntilDue;
    }
}

