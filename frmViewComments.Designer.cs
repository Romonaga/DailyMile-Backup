namespace VengSoft.DMBackUp
{
    partial class frmViewComments
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label bodyLabel;
            System.Windows.Forms.Label display_NameLabel;
            System.Windows.Forms.Label localTimeLabel;
            System.Windows.Forms.Label titleLabel;
            this.dailyMileCommentsDataGridView = new System.Windows.Forms.DataGridView();
            this.LocalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyTextBox = new System.Windows.Forms.TextBox();
            this.display_NameTextBox = new System.Windows.Forms.TextBox();
            this.localTimeTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.dailyMileCommentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            bodyLabel = new System.Windows.Forms.Label();
            display_NameLabel = new System.Windows.Forms.Label();
            localTimeLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dailyMileCommentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyMileCommentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bodyLabel
            // 
            bodyLabel.AutoSize = true;
            bodyLabel.Location = new System.Drawing.Point(7, 311);
            bodyLabel.Name = "bodyLabel";
            bodyLabel.Size = new System.Drawing.Size(34, 13);
            bodyLabel.TabIndex = 1;
            bodyLabel.Text = "Body:";
            // 
            // display_NameLabel
            // 
            display_NameLabel.AutoSize = true;
            display_NameLabel.Location = new System.Drawing.Point(45, 242);
            display_NameLabel.Name = "display_NameLabel";
            display_NameLabel.Size = new System.Drawing.Size(75, 13);
            display_NameLabel.TabIndex = 3;
            display_NameLabel.Text = "Display Name:";
            // 
            // localTimeLabel
            // 
            localTimeLabel.AutoSize = true;
            localTimeLabel.Location = new System.Drawing.Point(257, 239);
            localTimeLabel.Name = "localTimeLabel";
            localTimeLabel.Size = new System.Drawing.Size(62, 13);
            localTimeLabel.TabIndex = 5;
            localTimeLabel.Text = "Local Time:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(441, 236);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(63, 13);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "Motovation:";
            // 
            // dailyMileCommentsDataGridView
            // 
            this.dailyMileCommentsDataGridView.AllowUserToAddRows = false;
            this.dailyMileCommentsDataGridView.AllowUserToDeleteRows = false;
            this.dailyMileCommentsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dailyMileCommentsDataGridView.AutoGenerateColumns = false;
            this.dailyMileCommentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dailyMileCommentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyMileCommentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.LocalTime,
            this.dataGridViewTextBoxColumn2});
            this.dailyMileCommentsDataGridView.DataSource = this.dailyMileCommentsBindingSource;
            this.dailyMileCommentsDataGridView.Location = new System.Drawing.Point(12, 25);
            this.dailyMileCommentsDataGridView.MultiSelect = false;
            this.dailyMileCommentsDataGridView.Name = "dailyMileCommentsDataGridView";
            this.dailyMileCommentsDataGridView.ReadOnly = true;
            this.dailyMileCommentsDataGridView.Size = new System.Drawing.Size(830, 189);
            this.dailyMileCommentsDataGridView.TabIndex = 1;
            this.dailyMileCommentsDataGridView.SelectionChanged += new System.EventHandler(this.dailyMileCommentsDataGridView_SelectionChanged);
            // 
            // LocalTime
            // 
            this.LocalTime.DataPropertyName = "LocalTime";
            this.LocalTime.HeaderText = "Entry Time";
            this.LocalTime.MinimumWidth = 120;
            this.LocalTime.Name = "LocalTime";
            this.LocalTime.ReadOnly = true;
            this.LocalTime.Width = 120;
            // 
            // bodyTextBox
            // 
            this.bodyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileCommentsBindingSource, "Body", true));
            this.bodyTextBox.Location = new System.Drawing.Point(47, 261);
            this.bodyTextBox.Multiline = true;
            this.bodyTextBox.Name = "bodyTextBox";
            this.bodyTextBox.ReadOnly = true;
            this.bodyTextBox.Size = new System.Drawing.Size(795, 118);
            this.bodyTextBox.TabIndex = 2;
            // 
            // display_NameTextBox
            // 
            this.display_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileCommentsBindingSource, "Display_Name", true));
            this.display_NameTextBox.Location = new System.Drawing.Point(126, 239);
            this.display_NameTextBox.Name = "display_NameTextBox";
            this.display_NameTextBox.ReadOnly = true;
            this.display_NameTextBox.Size = new System.Drawing.Size(125, 20);
            this.display_NameTextBox.TabIndex = 4;
            // 
            // localTimeTextBox
            // 
            this.localTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileCommentsBindingSource, "LocalTime", true));
            this.localTimeTextBox.Location = new System.Drawing.Point(325, 236);
            this.localTimeTextBox.Name = "localTimeTextBox";
            this.localTimeTextBox.ReadOnly = true;
            this.localTimeTextBox.Size = new System.Drawing.Size(110, 20);
            this.localTimeTextBox.TabIndex = 6;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMileCommentsBindingSource, "MotovationTitle", true));
            this.titleTextBox.Location = new System.Drawing.Point(509, 233);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(333, 20);
            this.titleTextBox.TabIndex = 8;
            // 
            // dailyMileCommentsBindingSource
            // 
            this.dailyMileCommentsBindingSource.DataSource = typeof(VengSoft.DailyMileAPIWrapper.DailyMileComments);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Display_Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Display_Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Body";
            this.dataGridViewTextBoxColumn2.HeaderText = "Body";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 500;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 500;
            // 
            // frmViewComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 399);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(localTimeLabel);
            this.Controls.Add(this.localTimeTextBox);
            this.Controls.Add(display_NameLabel);
            this.Controls.Add(this.display_NameTextBox);
            this.Controls.Add(bodyLabel);
            this.Controls.Add(this.bodyTextBox);
            this.Controls.Add(this.dailyMileCommentsDataGridView);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::VengSoft.DMBackUp.Properties.Settings.Default, "frmViewComments", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::VengSoft.DMBackUp.Properties.Settings.Default.frmViewComments;
            this.MaximumSize = new System.Drawing.Size(870, 437);
            this.MinimumSize = new System.Drawing.Size(870, 437);
            this.Name = "frmViewComments";
            this.Text = "DMBackUp - View Comments";
            this.Load += new System.EventHandler(this.frmViewComments_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewComments_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dailyMileCommentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyMileCommentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dailyMileCommentsBindingSource;
        private System.Windows.Forms.DataGridView dailyMileCommentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox bodyTextBox;
        private System.Windows.Forms.TextBox display_NameTextBox;
        private System.Windows.Forms.TextBox localTimeTextBox;
        private System.Windows.Forms.TextBox titleTextBox;


    }
}