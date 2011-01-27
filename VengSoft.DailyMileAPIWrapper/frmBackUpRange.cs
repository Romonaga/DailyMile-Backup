using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VengSoft.DailyMileAPIWrapper
{
    public partial class frmBackUpRange : Form
    {
        public DateTime SinceDateTime
        {
            get { return dtpSince.Value; }
            set { dtpSince.Value = value; }
        }

        public DateTime UntilDateTime
        {
            get { return dtUntil.Value; }
            set { dtUntil.Value = value; }
        }

        public frmBackUpRange(DateTime since) : base()
        {
            InitializeComponent();
            dtUntil.Value = DateTime.Now;
            if (since < dtpSince.MinDate)
                dtpSince.Value = dtpSince.MinDate;
            else
                dtpSince.Value = since;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
