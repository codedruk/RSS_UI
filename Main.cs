namespace Rss_UI
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using RSS_reader;

    #endregion

    public partial class Main : Form
    {
        public Main()
        {
            this.InitializeComponent();
        }

        public void Poll(Object stateInfo)
        {
            var poller = new RssPoller();
            poller.RaiseCustomEvent += this.Poller_RaiseCustomEvent;
            poller.Poll(this.txtURL.Text);
        }

        public void Poller_RaiseCustomEvent(object sender, PollFinishedEventArgs e)
        {
            this.DisplayText(e.GetChannel.GetDataString());
        }

        public void DisplayText(string text)
        {
            var newText = text;
            this.Invoke((MethodInvoker)delegate 
            { 
                this.txtFeed.Text = newText; 
            });

            this.lblStatus.Text = "RSS Feed Polled";
        }

        private void Btn_Pull_Click(object sender, EventArgs e)
        {
            this.lblStatus.Text = "Now Polling...";
            var callback = new TimerCallback(this.Poll);
            var pollTimer = new System.Threading.Timer(callback, null, 0, 15000);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.lblStatus.Text = "Enter RSS Feed URL";
        }       
    }
}
