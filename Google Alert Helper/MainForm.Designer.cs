namespace Google_Alert_Helper
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbFromBrowser = new System.Windows.Forms.TextBox();
            this.tbToBrowser = new System.Windows.Forms.TextBox();
            this.tbToAlert = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbFromAlert = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDiscuss = new System.Windows.Forms.RadioButton();
            this.rbNews = new System.Windows.Forms.RadioButton();
            this.rbBlogs = new System.Windows.Forms.RadioButton();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.rbBooks = new System.Windows.Forms.RadioButton();
            this.rbEverything = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbOnceaweek = new System.Windows.Forms.RadioButton();
            this.rbOnceaday = new System.Windows.Forms.RadioButton();
            this.rbAsit = new System.Windows.Forms.RadioButton();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this._webBrowser = new System.Windows.Forms.WebBrowser();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbKeywords = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbFeed = new System.Windows.Forms.RadioButton();
            this.rbEmail = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbPass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(50, 27);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(136, 20);
            this.tbEmail.TabIndex = 1;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pass :";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(50, 60);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(136, 20);
            this.tbPass.TabIndex = 2;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbFromBrowser);
            this.groupBox2.Controls.Add(this.tbToBrowser);
            this.groupBox2.Controls.Add(this.tbToAlert);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbFromAlert);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(10, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 67);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delay";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tbFromBrowser
            // 
            this.tbFromBrowser.Location = new System.Drawing.Point(39, 40);
            this.tbFromBrowser.Name = "tbFromBrowser";
            this.tbFromBrowser.Size = new System.Drawing.Size(30, 20);
            this.tbFromBrowser.TabIndex = 6;
            this.tbFromBrowser.Text = "2";
            // 
            // tbToBrowser
            // 
            this.tbToBrowser.Location = new System.Drawing.Point(92, 39);
            this.tbToBrowser.Name = "tbToBrowser";
            this.tbToBrowser.Size = new System.Drawing.Size(32, 20);
            this.tbToBrowser.TabIndex = 7;
            this.tbToBrowser.Text = "5";
            // 
            // tbToAlert
            // 
            this.tbToAlert.Location = new System.Drawing.Point(93, 15);
            this.tbToAlert.Name = "tbToAlert";
            this.tbToAlert.Size = new System.Drawing.Size(31, 20);
            this.tbToAlert.TabIndex = 5;
            this.tbToAlert.Text = "5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "s each alert cretion.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "to";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "to";
            // 
            // tbFromAlert
            // 
            this.tbFromAlert.Location = new System.Drawing.Point(37, 14);
            this.tbFromAlert.Name = "tbFromAlert";
            this.tbFromAlert.Size = new System.Drawing.Size(32, 20);
            this.tbFromAlert.TabIndex = 4;
            this.tbFromAlert.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "s each browser action.";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbDiscuss);
            this.groupBox3.Controls.Add(this.rbNews);
            this.groupBox3.Controls.Add(this.rbBlogs);
            this.groupBox3.Controls.Add(this.rbVideo);
            this.groupBox3.Controls.Add(this.rbBooks);
            this.groupBox3.Controls.Add(this.rbEverything);
            this.groupBox3.Location = new System.Drawing.Point(383, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alert type";
            // 
            // rbDiscuss
            // 
            this.rbDiscuss.AutoSize = true;
            this.rbDiscuss.Location = new System.Drawing.Point(6, 45);
            this.rbDiscuss.Name = "rbDiscuss";
            this.rbDiscuss.Size = new System.Drawing.Size(84, 17);
            this.rbDiscuss.TabIndex = 14;
            this.rbDiscuss.TabStop = true;
            this.rbDiscuss.Tag = "8";
            this.rbDiscuss.Text = "Discussions ";
            this.rbDiscuss.UseVisualStyleBackColor = true;
            // 
            // rbNews
            // 
            this.rbNews.AutoSize = true;
            this.rbNews.Location = new System.Drawing.Point(6, 70);
            this.rbNews.Name = "rbNews";
            this.rbNews.Size = new System.Drawing.Size(52, 17);
            this.rbNews.TabIndex = 13;
            this.rbNews.TabStop = true;
            this.rbNews.Tag = "1";
            this.rbNews.Text = "News";
            this.rbNews.UseVisualStyleBackColor = true;
            // 
            // rbBlogs
            // 
            this.rbBlogs.AutoSize = true;
            this.rbBlogs.Location = new System.Drawing.Point(100, 44);
            this.rbBlogs.Name = "rbBlogs";
            this.rbBlogs.Size = new System.Drawing.Size(51, 17);
            this.rbBlogs.TabIndex = 12;
            this.rbBlogs.TabStop = true;
            this.rbBlogs.Tag = "4";
            this.rbBlogs.Text = "Blogs";
            this.rbBlogs.UseVisualStyleBackColor = true;
            // 
            // rbVideo
            // 
            this.rbVideo.AutoSize = true;
            this.rbVideo.Location = new System.Drawing.Point(100, 69);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(52, 17);
            this.rbVideo.TabIndex = 11;
            this.rbVideo.TabStop = true;
            this.rbVideo.Tag = "9";
            this.rbVideo.Text = "Video";
            this.rbVideo.UseVisualStyleBackColor = true;
            // 
            // rbBooks
            // 
            this.rbBooks.AutoSize = true;
            this.rbBooks.Location = new System.Drawing.Point(100, 19);
            this.rbBooks.Name = "rbBooks";
            this.rbBooks.Size = new System.Drawing.Size(55, 17);
            this.rbBooks.TabIndex = 10;
            this.rbBooks.Tag = "22";
            this.rbBooks.Text = "Books";
            this.rbBooks.UseVisualStyleBackColor = true;
            this.rbBooks.CheckedChanged += new System.EventHandler(this.rbBooks_CheckedChanged);
            // 
            // rbEverything
            // 
            this.rbEverything.AutoSize = true;
            this.rbEverything.Checked = true;
            this.rbEverything.Location = new System.Drawing.Point(6, 19);
            this.rbEverything.Name = "rbEverything";
            this.rbEverything.Size = new System.Drawing.Size(75, 17);
            this.rbEverything.TabIndex = 9;
            this.rbEverything.TabStop = true;
            this.rbEverything.Tag = "7";
            this.rbEverything.Text = "Everything";
            this.rbEverything.UseVisualStyleBackColor = true;
            this.rbEverything.CheckedChanged += new System.EventHandler(this.rbEverything_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbOnceaweek);
            this.groupBox4.Controls.Add(this.rbOnceaday);
            this.groupBox4.Controls.Add(this.rbAsit);
            this.groupBox4.Location = new System.Drawing.Point(549, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(93, 100);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delivery type";
            // 
            // rbOnceaweek
            // 
            this.rbOnceaweek.AutoSize = true;
            this.rbOnceaweek.Location = new System.Drawing.Point(6, 70);
            this.rbOnceaweek.Name = "rbOnceaweek";
            this.rbOnceaweek.Size = new System.Drawing.Size(89, 17);
            this.rbOnceaweek.TabIndex = 17;
            this.rbOnceaweek.TabStop = true;
            this.rbOnceaweek.Tag = "6";
            this.rbOnceaweek.Text = "Once a week";
            this.rbOnceaweek.UseVisualStyleBackColor = true;
            // 
            // rbOnceaday
            // 
            this.rbOnceaday.AutoSize = true;
            this.rbOnceaday.Location = new System.Drawing.Point(6, 44);
            this.rbOnceaday.Name = "rbOnceaday";
            this.rbOnceaday.Size = new System.Drawing.Size(80, 17);
            this.rbOnceaday.TabIndex = 14;
            this.rbOnceaday.TabStop = true;
            this.rbOnceaday.Tag = "1";
            this.rbOnceaday.Text = "Once a day";
            this.rbOnceaday.UseVisualStyleBackColor = true;
            this.rbOnceaday.CheckedChanged += new System.EventHandler(this.rbOnceaday_CheckedChanged);
            // 
            // rbAsit
            // 
            this.rbAsit.AutoSize = true;
            this.rbAsit.Checked = true;
            this.rbAsit.Location = new System.Drawing.Point(6, 19);
            this.rbAsit.Name = "rbAsit";
            this.rbAsit.Size = new System.Drawing.Size(89, 17);
            this.rbAsit.TabIndex = 9;
            this.rbAsit.TabStop = true;
            this.rbAsit.Tag = "0";
            this.rbAsit.Text = "As-it-happens";
            this.rbAsit.UseVisualStyleBackColor = true;
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btStart.Location = new System.Drawing.Point(352, 121);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(73, 41);
            this.btStart.TabIndex = 11;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btStop.Location = new System.Drawing.Point(431, 121);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(73, 41);
            this.btStop.TabIndex = 12;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // _webBrowser
            // 
            this._webBrowser.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this._webBrowser.Location = new System.Drawing.Point(0, 181);
            this._webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this._webBrowser.Name = "_webBrowser";
            this._webBrowser.ScriptErrorsSuppressed = true;
            this._webBrowser.Size = new System.Drawing.Size(647, 325);
            this._webBrowser.TabIndex = 13;
            this._webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this._webBrowser_DocumentCompleted);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbKeywords);
            this.groupBox5.Location = new System.Drawing.Point(208, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(171, 96);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Keywords";
            // 
            // tbKeywords
            // 
            this.tbKeywords.Location = new System.Drawing.Point(3, 16);
            this.tbKeywords.Multiline = true;
            this.tbKeywords.Name = "tbKeywords";
            this.tbKeywords.Size = new System.Drawing.Size(162, 74);
            this.tbKeywords.TabIndex = 3;
            this.tbKeywords.TextChanged += new System.EventHandler(this.tbKeywords_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbFeed);
            this.groupBox6.Controls.Add(this.rbEmail);
            this.groupBox6.Location = new System.Drawing.Point(256, 108);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(90, 67);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Alert type";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // rbFeed
            // 
            this.rbFeed.AutoSize = true;
            this.rbFeed.Location = new System.Drawing.Point(10, 39);
            this.rbFeed.Name = "rbFeed";
            this.rbFeed.Size = new System.Drawing.Size(49, 17);
            this.rbFeed.TabIndex = 18;
            this.rbFeed.TabStop = true;
            this.rbFeed.Text = "Feed";
            this.rbFeed.UseVisualStyleBackColor = true;
            this.rbFeed.CheckedChanged += new System.EventHandler(this.rbFeed_CheckedChanged);
            // 
            // rbEmail
            // 
            this.rbEmail.AutoSize = true;
            this.rbEmail.Checked = true;
            this.rbEmail.Location = new System.Drawing.Point(10, 13);
            this.rbEmail.Name = "rbEmail";
            this.rbEmail.Size = new System.Drawing.Size(50, 17);
            this.rbEmail.TabIndex = 17;
            this.rbEmail.TabStop = true;
            this.rbEmail.Text = "Email";
            this.rbEmail.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 506);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this._webBrowser);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(665, 544);
            this.Name = "MainForm";
            this.Text = "Google Alert Creator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MainForm_Scroll);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbFromAlert;
        private System.Windows.Forms.RadioButton rbDiscuss;
        private System.Windows.Forms.RadioButton rbNews;
        private System.Windows.Forms.RadioButton rbBlogs;
        private System.Windows.Forms.RadioButton rbVideo;
        private System.Windows.Forms.RadioButton rbBooks;
        private System.Windows.Forms.RadioButton rbEverything;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbOnceaday;
        private System.Windows.Forms.RadioButton rbAsit;
        private System.Windows.Forms.TextBox tbToAlert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFromBrowser;
        private System.Windows.Forms.TextBox tbToBrowser;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.WebBrowser _webBrowser;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbKeywords;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbFeed;
        private System.Windows.Forms.RadioButton rbEmail;
        private System.Windows.Forms.RadioButton rbOnceaweek;
    }
}

