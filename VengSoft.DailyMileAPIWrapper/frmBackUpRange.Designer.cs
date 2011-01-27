namespace VengSoft.DailyMileAPIWrapper
{
    partial class frmBackUpRange
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
            this.dtpSince = new System.Windows.Forms.DateTimePicker();
            this.dtUntil = new System.Windows.Forms.DateTimePicker();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpSince
            // 
            this.dtpSince.Location = new System.Drawing.Point(23, 12);
            this.dtpSince.MinDate = new System.DateTime(2008, 1, 1, 0, 0, 0, 0);
            this.dtpSince.Name = "dtpSince";
            this.dtpSince.Size = new System.Drawing.Size(200, 20);
            this.dtpSince.TabIndex = 0;
            // 
            // dtUntil
            // 
            this.dtUntil.Location = new System.Drawing.Point(244, 12);
            this.dtUntil.Name = "dtUntil";
            this.dtUntil.Size = new System.Drawing.Size(200, 20);
            this.dtUntil.TabIndex = 1;
            this.dtUntil.Value = new System.DateTime(2008, 1, 1, 0, 0, 0, 0);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(23, 58);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // frmBackUpRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 93);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dtUntil);
            this.Controls.Add(this.dtpSince);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::VengSoft.DailyMileAPIWrapper.Properties.Settings.Default, "frmBackUpRangeLoc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::VengSoft.DailyMileAPIWrapper.Properties.Settings.Default.frmBackUpRangeLoc;
            this.MaximumSize = new System.Drawing.Size(487, 131);
            this.MinimumSize = new System.Drawing.Size(487, 131);
            this.Name = "frmBackUpRange";
            this.Text = "DMBackUp - Date Range Selection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSince;
        private System.Windows.Forms.DateTimePicker dtUntil;
        private System.Windows.Forms.Button btnSelect;
    }
}