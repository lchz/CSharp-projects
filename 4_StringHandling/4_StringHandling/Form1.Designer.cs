namespace _4_StringHandling
{
    partial class StringHandlingForm
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
            this.labName = new System.Windows.Forms.Label();
            this.btnParseName = new System.Windows.Forms.Button();
            this.btnEditPhoneNumber = new System.Windows.Forms.Button();
            this.labPhoneNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(13, 38);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(55, 20);
            this.labName.TabIndex = 0;
            this.labName.Text = "Name:";
            // 
            // btnParseName
            // 
            this.btnParseName.Location = new System.Drawing.Point(149, 162);
            this.btnParseName.Name = "btnParseName";
            this.btnParseName.Size = new System.Drawing.Size(108, 31);
            this.btnParseName.TabIndex = 3;
            this.btnParseName.Text = "Parse Name";
            this.btnParseName.UseVisualStyleBackColor = true;
            this.btnParseName.Click += new System.EventHandler(this.btnParseName_Click);
            // 
            // btnEditPhoneNumber
            // 
            this.btnEditPhoneNumber.Location = new System.Drawing.Point(123, 214);
            this.btnEditPhoneNumber.Name = "btnEditPhoneNumber";
            this.btnEditPhoneNumber.Size = new System.Drawing.Size(172, 31);
            this.btnEditPhoneNumber.TabIndex = 4;
            this.btnEditPhoneNumber.Text = "Edit Phone Number";
            this.btnEditPhoneNumber.UseVisualStyleBackColor = true;
            // 
            // labPhoneNumber
            // 
            this.labPhoneNumber.AutoSize = true;
            this.labPhoneNumber.Location = new System.Drawing.Point(13, 96);
            this.labPhoneNumber.Name = "labPhoneNumber";
            this.labPhoneNumber.Size = new System.Drawing.Size(119, 20);
            this.labPhoneNumber.TabIndex = 5;
            this.labPhoneNumber.Text = "Phone Number:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 0;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(166, 96);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 26);
            this.txtPhoneNumber.TabIndex = 9;
            // 
            // StringHandlingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 301);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labPhoneNumber);
            this.Controls.Add(this.btnEditPhoneNumber);
            this.Controls.Add(this.btnParseName);
            this.Controls.Add(this.labName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StringHandlingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhoneBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnParseName;
        private System.Windows.Forms.Button btnEditPhoneNumber;
        private System.Windows.Forms.Label labPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
    }
}

