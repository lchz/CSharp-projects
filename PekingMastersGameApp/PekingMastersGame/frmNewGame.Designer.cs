namespace PekingMastersGameApp
{
    partial class frmNewGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNewStatus = new System.Windows.Forms.Label();
            this.lblNewGame = new System.Windows.Forms.Label();
            this.lblNewDay = new System.Windows.Forms.Label();
            this.lblNewName = new System.Windows.Forms.Label();
            this.lblNewDate = new System.Windows.Forms.Label();
            this.lblNewSeason = new System.Windows.Forms.Label();
            this.lblNewEp = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbNewName = new System.Windows.Forms.ComboBox();
            this.cmbNewStatus = new System.Windows.Forms.ComboBox();
            this.cmbNewGameNum = new System.Windows.Forms.ComboBox();
            this.cmbNewDay = new System.Windows.Forms.ComboBox();
            this.cmbNewEp = new System.Windows.Forms.ComboBox();
            this.cmbNewSeason = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNewStatus);
            this.panel1.Controls.Add(this.lblNewGame);
            this.panel1.Controls.Add(this.lblNewDay);
            this.panel1.Controls.Add(this.lblNewName);
            this.panel1.Controls.Add(this.lblNewDate);
            this.panel1.Controls.Add(this.lblNewSeason);
            this.panel1.Controls.Add(this.lblNewEp);
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 437);
            this.panel1.TabIndex = 0;
            // 
            // lblNewStatus
            // 
            this.lblNewStatus.AutoSize = true;
            this.lblNewStatus.Location = new System.Drawing.Point(37, 386);
            this.lblNewStatus.Name = "lblNewStatus";
            this.lblNewStatus.Size = new System.Drawing.Size(60, 20);
            this.lblNewStatus.TabIndex = 6;
            this.lblNewStatus.Text = "Status:";
            // 
            // lblNewGame
            // 
            this.lblNewGame.AutoSize = true;
            this.lblNewGame.Location = new System.Drawing.Point(12, 266);
            this.lblNewGame.Name = "lblNewGame";
            this.lblNewGame.Size = new System.Drawing.Size(85, 20);
            this.lblNewGame.TabIndex = 5;
            this.lblNewGame.Text = "Game No.:";
            // 
            // lblNewDay
            // 
            this.lblNewDay.AutoSize = true;
            this.lblNewDay.Location = new System.Drawing.Point(47, 200);
            this.lblNewDay.Name = "lblNewDay";
            this.lblNewDay.Size = new System.Drawing.Size(41, 20);
            this.lblNewDay.TabIndex = 4;
            this.lblNewDay.Text = "Day:";
            // 
            // lblNewName
            // 
            this.lblNewName.AutoSize = true;
            this.lblNewName.Location = new System.Drawing.Point(40, 328);
            this.lblNewName.Name = "lblNewName";
            this.lblNewName.Size = new System.Drawing.Size(55, 20);
            this.lblNewName.TabIndex = 3;
            this.lblNewName.Text = "Name:";
            // 
            // lblNewDate
            // 
            this.lblNewDate.AutoSize = true;
            this.lblNewDate.Location = new System.Drawing.Point(47, 138);
            this.lblNewDate.Name = "lblNewDate";
            this.lblNewDate.Size = new System.Drawing.Size(48, 20);
            this.lblNewDate.TabIndex = 2;
            this.lblNewDate.Text = "Date:";
            // 
            // lblNewSeason
            // 
            this.lblNewSeason.AutoSize = true;
            this.lblNewSeason.Location = new System.Drawing.Point(27, 27);
            this.lblNewSeason.Name = "lblNewSeason";
            this.lblNewSeason.Size = new System.Drawing.Size(68, 20);
            this.lblNewSeason.TabIndex = 1;
            this.lblNewSeason.Text = "Season:";
            // 
            // lblNewEp
            // 
            this.lblNewEp.AutoSize = true;
            this.lblNewEp.Location = new System.Drawing.Point(24, 82);
            this.lblNewEp.Name = "lblNewEp";
            this.lblNewEp.Size = new System.Drawing.Size(71, 20);
            this.lblNewEp.TabIndex = 0;
            this.lblNewEp.Text = "Episode:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbNewName);
            this.panel2.Controls.Add(this.cmbNewStatus);
            this.panel2.Controls.Add(this.cmbNewGameNum);
            this.panel2.Controls.Add(this.cmbNewDay);
            this.panel2.Controls.Add(this.cmbNewEp);
            this.panel2.Controls.Add(this.cmbNewSeason);
            this.panel2.Controls.Add(this.dateTimePicker);
            this.panel2.Location = new System.Drawing.Point(149, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 437);
            this.panel2.TabIndex = 1;
            // 
            // cmbNewName
            // 
            this.cmbNewName.FormattingEnabled = true;
            this.cmbNewName.Location = new System.Drawing.Point(31, 325);
            this.cmbNewName.Name = "cmbNewName";
            this.cmbNewName.Size = new System.Drawing.Size(121, 28);
            this.cmbNewName.TabIndex = 6;
            // 
            // cmbNewStatus
            // 
            this.cmbNewStatus.FormattingEnabled = true;
            this.cmbNewStatus.Location = new System.Drawing.Point(31, 386);
            this.cmbNewStatus.Name = "cmbNewStatus";
            this.cmbNewStatus.Size = new System.Drawing.Size(121, 28);
            this.cmbNewStatus.TabIndex = 5;
            // 
            // cmbNewGameNum
            // 
            this.cmbNewGameNum.FormattingEnabled = true;
            this.cmbNewGameNum.Location = new System.Drawing.Point(31, 258);
            this.cmbNewGameNum.Name = "cmbNewGameNum";
            this.cmbNewGameNum.Size = new System.Drawing.Size(121, 28);
            this.cmbNewGameNum.TabIndex = 4;
            // 
            // cmbNewDay
            // 
            this.cmbNewDay.FormattingEnabled = true;
            this.cmbNewDay.Location = new System.Drawing.Point(31, 192);
            this.cmbNewDay.Name = "cmbNewDay";
            this.cmbNewDay.Size = new System.Drawing.Size(121, 28);
            this.cmbNewDay.TabIndex = 3;
            // 
            // cmbNewEp
            // 
            this.cmbNewEp.FormattingEnabled = true;
            this.cmbNewEp.Location = new System.Drawing.Point(31, 82);
            this.cmbNewEp.Name = "cmbNewEp";
            this.cmbNewEp.Size = new System.Drawing.Size(121, 28);
            this.cmbNewEp.TabIndex = 2;
            // 
            // cmbNewSeason
            // 
            this.cmbNewSeason.FormattingEnabled = true;
            this.cmbNewSeason.Location = new System.Drawing.Point(31, 19);
            this.cmbNewSeason.Name = "cmbNewSeason";
            this.cmbNewSeason.Size = new System.Drawing.Size(121, 28);
            this.cmbNewSeason.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(31, 132);
            this.dateTimePicker.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(121, 26);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.Value = new System.DateTime(2023, 9, 18, 0, 0, 0, 0);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(26, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(234, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Location = new System.Drawing.Point(190, 470);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 66);
            this.panel3.TabIndex = 4;
            // 
            // frmNewGame
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(587, 553);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmNewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Episode";
            this.Load += new System.EventHandler(this.frmNewEpisode_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNewEp;
        private System.Windows.Forms.Label lblNewSeason;
        private System.Windows.Forms.Label lblNewDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblNewName;
        private System.Windows.Forms.Label lblNewDay;
        private System.Windows.Forms.Label lblNewGame;
        private System.Windows.Forms.Label lblNewStatus;
        private System.Windows.Forms.ComboBox cmbNewSeason;
        private System.Windows.Forms.ComboBox cmbNewName;
        private System.Windows.Forms.ComboBox cmbNewStatus;
        private System.Windows.Forms.ComboBox cmbNewGameNum;
        private System.Windows.Forms.ComboBox cmbNewDay;
        private System.Windows.Forms.ComboBox cmbNewEp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel3;
    }
}