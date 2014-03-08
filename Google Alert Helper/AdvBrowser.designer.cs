namespace BlueSoft
{
    partial class AdvWebBrowser
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
            this.cbDlImage = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbDlImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 100);
            this.panel1.TabIndex = 0;
            // 
            // cbDlImage
            // 
            this.cbDlImage.AutoSize = true;
            this.cbDlImage.Checked = true;
            this.cbDlImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDlImage.Location = new System.Drawing.Point(13, 23);
            this.cbDlImage.Name = "cbDlImage";
            this.cbDlImage.Size = new System.Drawing.Size(134, 17);
            this.cbDlImage.TabIndex = 0;
            this.cbDlImage.Text = "Don\'t download image.";
            this.cbDlImage.UseVisualStyleBackColor = true;
            this.cbDlImage.CheckedChanged += new System.EventHandler(this.cbDlImage_CheckedChanged);
            // 
            // AdvWebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 233);
            this.Controls.Add(this.panel1);
            this.Name = "AdvWebBrowser";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbDlImage;


    }
}