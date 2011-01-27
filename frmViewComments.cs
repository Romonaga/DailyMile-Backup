using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using VengSoft.DailyMileAPIWrapper;

namespace VengSoft.DMBackUp
{
    public partial class frmViewComments : Form
    {
        DailyMileEntry _entry;

        public frmViewComments(DailyMileEntry entry)
            : base()
        {
            _entry = entry;

            InitializeComponent();
          
        }

        private void frmViewComments_FormClosing(object sender, FormClosingEventArgs e)
        {
            VengSoft.DMBackUp.Properties.Settings.Default.Save();
        }

        private void frmViewComments_Load(object sender, EventArgs e)
        {



            dailyMileCommentsDataGridView.DataSource = _entry.Comments;
           
        
         
        }

        private void dailyMileCommentsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dailyMileCommentsDataGridView.SelectedRows.Count > 0)
            {
                DailyMileComments comment = ((DataGridViewRow)dailyMileCommentsDataGridView.SelectedRows[0]).DataBoundItem as DailyMileComments;
                dailyMileCommentsBindingSource.DataSource = comment;
            }
            
        }

        private void dailyMilerssBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

      
    }
}
