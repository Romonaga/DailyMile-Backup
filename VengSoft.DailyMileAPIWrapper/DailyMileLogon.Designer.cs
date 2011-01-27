namespace VengSoft.DailyMileAPIWrapper
{
    partial class DailyMileLogon
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
            this.wbControl = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbControl
            // 
            this.wbControl.AllowWebBrowserDrop = false;
            this.wbControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.wbControl.Location = new System.Drawing.Point(0, 0);
            this.wbControl.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbControl.Name = "wbControl";
            this.wbControl.Size = new System.Drawing.Size(626, 319);
            this.wbControl.TabIndex = 1;
            this.wbControl.WebBrowserShortcutsEnabled = false;
            this.wbControl.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbControl_DocumentCompleted);
            // 
            // DailyMileLogon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 357);
            this.Controls.Add(this.wbControl);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::VengSoft.DailyMileAPIWrapper.Properties.Settings.Default, "DMLogonFormLoc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::VengSoft.DailyMileAPIWrapper.Properties.Settings.Default.DMLogonFormLoc;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(642, 395);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(642, 395);
            this.Name = "DailyMileLogon";
            this.Text = "DMBackup - Dailymile Validation";
            this.Load += new System.EventHandler(this.DailyMileLogon_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DailyMileLogon_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbControl;

    }
}