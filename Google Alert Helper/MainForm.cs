using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google_Alert_Helper
{
    public partial class MainForm : Form
    {
        #region ############# Declare Variable ###################
        string email = "";
        string pass = "";
        List<string> listKW = new List<string> { };
        string alertType1 = "";
        string alertType2 = "";
        string deliveryType = "";
        int fromAlert = 0;
        int toALert = 0;
        int fromBrowser = 0;
        int toBrowser = 0;

        Random rd = new Random();
        bool stop = false;
        #endregion
        public MainForm()
        {
            InitializeComponent();
        }
        #region################ Browser Function ########################
        //-----------------------------------------------------------
        public bool ClickATag(string text, bool click_all = false)
        {
            bool flag = false;

            HtmlElementCollection hc = _webBrowser.Document.GetElementsByTagName("a");
            string _text = text.ToLower();
            foreach (HtmlElement e in hc)
            {
                if (e.InnerHtml == null)
                    continue;
                if (e.InnerHtml.ToLower().Contains(_text))
                {
                    flag = true;
                    e.InvokeMember("click");
                    if (!click_all)
                        return true;
                }
            }
            return flag;
        }
        //-----------------------------------------------------------
        public void ClickInputTag(string text, bool click_all = false)
        {

            HtmlElementCollection hc = _webBrowser.Document.GetElementsByTagName("input");
            string _text = text.ToLower();
            foreach (HtmlElement e in hc)
            {
                if (e.GetAttribute("value") == null)
                    continue;
                if (e.GetAttribute("value").ToLower().Contains(text))
                {
                    e.InvokeMember("click");
                    if (!click_all)
                        return;
                }
            }
        }
        //-----------------------------------------------------------
        public void ClickButtonByName(string text, bool click_all = false)
        {

            HtmlElementCollection hc = _webBrowser.Document.GetElementsByTagName("input");
            foreach (HtmlElement e in hc)
            {
                
                if (e.Name == null)
                    continue;
                if (e.Name == text)
                {
                    e.InvokeMember("click");
                    if (!click_all)
                        return;
                }
            }
        }
        //----------------------------------------------------------
        public void ClickEmementById(string text, bool click_all = false)
        {
            HtmlElement e = _webBrowser.Document.GetElementById(text);
            if (e != null)
                e.InvokeMember("click");
            
        }
        //-----------------------------------------------------------
        public void ClickCheckBox(string name)
        {
            HtmlElementCollection hc = _webBrowser.Document.GetElementsByTagName("input");
            for (int i = 0; i < hc.Count; i++)
            {
                if (hc[i].GetAttribute("name") == name)
                    hc[i].SetAttribute("checked", "checked");
            }
        }
        //-----------------------------------------------------------
        public void EnterInputText(string name, string value, string att = "value")
        {
            HtmlElementCollection hc = _webBrowser.Document.GetElementsByTagName("input");
            for (int i = 0; i < hc.Count; i++)
            {
                if (hc[i].GetAttribute("name") == name)
                    hc[i].SetAttribute(att, value);
            }
        }
        //-----------------------------------------------------------
        public void SleepBrowser(int seconds = 2)
        {
            int l = 0;
            int _time = seconds * 1000;
            while (l < _time)
            {
                l++;
                Application.DoEvents();
                System.Threading.Thread.Sleep(1);
                Application.DoEvents();
            }
        }
        //-----------------------------------------------------------
        public void WaitCompleteLoaded(int seconds = 2)
        {
            int mili = seconds * 1000;
            int count = 0;

            while (count <= mili)
            {
                if (!(_webBrowser.ReadyState != WebBrowserReadyState.Complete || _webBrowser.IsBusy))
                    break;
                count++;
                System.Threading.Thread.Sleep(1);
                Application.DoEvents();
            }
        }
        //-----------------------------------------------------------
        public void WaitCompleteLoadedText(string text_for_wait, int seconds = 2)
        {
            int mili = seconds * 1000;
            int count = 0;

            while (true)
            {
                count++;
                System.Threading.Thread.Sleep(1);
                if (count >= mili)
                    break;
                if (_webBrowser.Document == null || _webBrowser.Document.Body == null)
                {
                    SleepBrowser(10);
                    count += 10;
                    continue;
                }
                string html = _webBrowser.Document.Body.InnerText;
                if (html == null)
                {
                    SleepBrowser(10);
                    count += 10;
                    continue;
                }

                if (html.Contains(text_for_wait))
                    break;
                Application.DoEvents();
            }
        }
        //-----------------------------------------------------------
        public bool IsContainText(string text)
        {
            string html = GetSource();
            if (html.Contains(text))
                return true;
            return false;
        }
        //-----------------------------------------------------------
        public string GetSource()
        {
            return _webBrowser.Document.Body.InnerHtml;
        }
        //------------------------------------------------------------------
        public void GoTo(string url)
        {
            _webBrowser.Navigate(url);
        }
        #endregion
        #region ############### Form Function ########################
        private void btStart_Click(object sender, EventArgs e)
        {
            btStart.Enabled = false;

            GoTo("about:blank");
            WaitCompleteLoaded();

            if (!LoadConfig())
            {
                DoStop(false);
                return;
            }
            #region----------------- Log out ----------------
            if (stop)
            {
                DoStop();
                return;
            }
            GoTo("https://www.google.com/accounts/Logout?hl=en&service=alerts&continue=http://www.google.com/alerts");
            WaitCompleteLoaded();
            SleepBrowser(GetBrowserWaitTime());

            #endregion

            #region ---------------Start login--------------
            if (stop)
            {
                DoStop();
                return;
            }
            GoTo("https://accounts.google.com/ServiceLogin?hl=en&service=alerts&continue=http://www.google.com/alerts");
            WaitCompleteLoaded();
            SleepBrowser(GetBrowserWaitTime());

            EnterInputText("Email", email);
            EnterInputText("Passwd", pass);
            ClickButtonByName("signIn");

            WaitCompleteLoaded(5);
            SleepBrowser(GetBrowserWaitTime());
            SleepBrowser(GetBrowserWaitTime());
            if (stop)
            {
                DoStop();
                return;
            }

            #endregion
            
            for (int i = 0; i < listKW.Count; i++)
            {
                GoTo("http://www.google.com/alerts");
                WaitCompleteLoaded(5);
                SleepBrowser(GetBrowserWaitTime());
                if (stop)
                {
                    DoStop();
                    return;
                }
                #region------------------Create Alert-----------------
                //Enter keyword
                EnterInputText("q", listKW[i]);
                //Alter type 1
                EnterInputText("t", alertType1);
                //Delivery type
                EnterInputText("f", deliveryType);
                //Alert type 2
                EnterInputText("e", alertType2);

                ClickEmementById("create_alert");

                WaitCompleteLoaded(5);
                SleepBrowser(GetAlertWaitTime());
                if (stop)
                {
                    DoStop();
                    return;
                }
                
                #endregion
            }
            
            btStart.Enabled = true;
            MessageBox.Show("Complete create alert !");
            
        }
        //-------------------------------------------------------------------------
        bool LoadConfig()
        {
            // Load Email setting
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("You must enter your email");
                return false;
            }
            else
                email = tbEmail.Text;
            // Load Pass setting
            if (string.IsNullOrWhiteSpace(tbPass.Text))
            {
                MessageBox.Show("You must enter your password");
                return false;
            }
            else
                pass = tbPass.Text;
            // Load keywords setting
            if (string.IsNullOrWhiteSpace(tbKeywords.Text))
            {
                MessageBox.Show("You must enter your keywords");
                return false;
            }
            else
                listKW = tbKeywords.Lines.ToList();
            // Load delay setting
            int intTemp = IsNumeric(tbFromAlert.Text);
            if (intTemp == -1)
            {
                MessageBox.Show("Have a error in delay setting");
                return false;
            }
            else
                fromAlert = intTemp;

            intTemp = IsNumeric(tbToAlert.Text);
            if (intTemp == -1)
            {
                MessageBox.Show("Have a error in delay setting");
                return false;
            }
            else
                toALert = intTemp;

            intTemp = IsNumeric(tbFromBrowser.Text);
            if (intTemp == -1)
            {
                MessageBox.Show("Have a error in delay setting");
                return false;
            }
            else
                fromBrowser = intTemp;

            intTemp = IsNumeric(tbToBrowser.Text);
            if (intTemp == -1)
            {
                MessageBox.Show("Have a error in delay setting");
                return false;
            }
            else
                toBrowser = intTemp;
            // Alert type 1
            if (rbEverything.Checked)
                alertType1 = rbEverything.Tag.ToString();
            if (rbDiscuss.Checked)
                alertType1 = rbDiscuss.Tag.ToString();
            if (rbBlogs.Checked)
                alertType1 = rbBlogs.Tag.ToString();
            if (rbBooks.Checked)
                alertType1 = rbBooks.Tag.ToString();
            if (rbVideo.Checked)
                alertType1 = rbVideo.Tag.ToString();
            if (rbNews.Checked)
                alertType1 = rbNews.Tag.ToString();
            // Load alert type 2
            if (rbFeed.Checked)
                alertType2 = "feed";
            if (rbEmail.Checked)
                alertType2 = email;
            //Load delivery
            if (rbAsit.Checked)
                deliveryType = rbAsit.Tag.ToString();
            if (rbOnceaweek.Checked)
                deliveryType = rbOnceaweek.Tag.ToString();
            if (rbOnceaday.Checked)
                deliveryType = rbOnceaday.Tag.ToString();



            return true;
        }
        //--------------------------------------------------------------------------
        int GetBrowserWaitTime()
        {
            int ret = rd.Next(fromBrowser, toBrowser + 1);
            return ret;
        }
        int GetAlertWaitTime()
        {
            int ret = rd.Next(fromAlert, toALert + 1);
            return ret;
        }
        
        //--------------------------------------------------------------------------
        // MS checking numberic
        public int IsNumeric(object Expression)
        {
            bool isNum;
            int retNum;
            isNum =  int.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            if (isNum)
                return retNum;
            else
                return -1;
        }
        //--------------------------------------------------------------------------
        void DoStop(bool showMessaage = true)
        {
            btStart.Enabled = true;
            btStop.Enabled = true;
            btStop.Text = "Stop";
            stop = false;
            GoTo("about:blank");
            if(showMessaage)
                MessageBox.Show("Process have stopped");
        }
        #endregion

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tbUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbBooks_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbOnceaday_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFeed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbKeywords_TextChanged(object sender, EventArgs e)
        {

        }

        private void btStop_Click(object sender, EventArgs e)
        {
            if (btStart.Enabled)
                return;
            stop = true;
            btStop.Enabled = false;
            btStop.Text = "Waiting";
        }

        private void _webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            _webBrowser.Height = this.Height - 181;
            _webBrowser.Width = this.Width - 22;
        }

        private void MainForm_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void rbEverything_CheckedChanged(object sender, EventArgs e)
        {

        }

   


        
    }
}
