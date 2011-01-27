using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using VengSoft.Collections;

namespace VengSoft.DailyMileAPIWrapper
{
    internal partial class DailyMileLogon : Form
    {
        DailyMileConnectionInfo _connectionInfo;

        public DailyMileLogon(DailyMileConnectionInfo connectionInfo) : base()
        {
            
            _connectionInfo = connectionInfo;
            InitializeComponent();
        }

        private void DailyMileLogon_Load(object sender, EventArgs e)
        {
            wbControl.ScriptErrorsSuppressed = true;
            string requestURL;
            requestURL = string.Format("{0}/oauth/authorize?response_type=token&client_id={1}&redirect_uri={2}", _connectionInfo.DailyMileURL, _connectionInfo.ClientID, _connectionInfo.RedirectURL);

            Uri uri = new Uri(requestURL);

            wbControl.Navigate(uri);
            
        }

        private void ProcessQryResults(BindingListView<QueryResponseHolder> qryResponses)
        {
            if (qryResponses.Exists("Key", "access_token") && _connectionInfo.IsLoggedIn == false)
            {
                _connectionInfo.ServerKey = qryResponses.GetFirstItem("Key", "access_token").Value;
                _connectionInfo.IsLoggedIn = true;
                DailyMileConnectionInfo.SaveConnectionInfo(_connectionInfo.ConfigFileLocation, _connectionInfo);
                DialogResult = DialogResult.OK;
                this.Close();
            }

        }


        private void wbControl_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            BindingListView<QueryResponseHolder> qryResponses;

            WebBrowser wb = (WebBrowser)sender;
            if (_connectionInfo.RedirectURL.Contains(wb.Url.Host) == true)
            {
                wbControl.Visible = false;
                qryResponses = new BindingListView<QueryResponseHolder>();
                if (string.IsNullOrEmpty(wb.Url.Fragment) == false)
                {
                    string[] qryString = wb.Url.Fragment.Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string item in qryString)
                    {
                        string key;
                        string value;

                        int pos = item.IndexOf('=');
                        key = item.Substring(0, pos);
                        value = item.Substring(pos + 1, item.Length - (pos + 1));
                        qryResponses.Add(new QueryResponseHolder(key, value));

                        ProcessQryResults(qryResponses);

                    }

                }
            }
        }

        private void DailyMileLogon_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        
    }
}
