namespace TestClient
{
    partial class ImageViewer
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
            this.cmbDates = new System.Windows.Forms.ComboBox();
            this.lnkImagesByDate = new System.Windows.Forms.LinkLabel();
            this.dtgImages = new System.Windows.Forms.DataGridView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lnkDownload = new System.Windows.Forms.LinkLabel();
            this.lnk = new System.Windows.Forms.LinkLabel();
            this.txtErrors = new System.Windows.Forms.TextBox();
            this.linkBrowser = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgImages)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDates
            // 
            this.cmbDates.FormattingEnabled = true;
            this.cmbDates.Items.AddRange(new object[] {
            "02/27/17",
            "June 2, 2018",
            "Jul-13-2016",
            "April 31, 2018"});
            this.cmbDates.Location = new System.Drawing.Point(911, 12);
            this.cmbDates.Name = "cmbDates";
            this.cmbDates.Size = new System.Drawing.Size(121, 21);
            this.cmbDates.TabIndex = 1;
            // 
            // lnkImagesByDate
            // 
            this.lnkImagesByDate.AutoSize = true;
            this.lnkImagesByDate.Location = new System.Drawing.Point(885, 46);
            this.lnkImagesByDate.Name = "lnkImagesByDate";
            this.lnkImagesByDate.Size = new System.Drawing.Size(147, 13);
            this.lnkImagesByDate.TabIndex = 2;
            this.lnkImagesByDate.TabStop = true;
            this.lnkImagesByDate.Text = "Get Images for Selected Date";
            this.lnkImagesByDate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkImagesByDate_LinkClicked);
            // 
            // dtgImages
            // 
            this.dtgImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgImages.Location = new System.Drawing.Point(10, 314);
            this.dtgImages.Name = "dtgImages";
            this.dtgImages.Size = new System.Drawing.Size(869, 247);
            this.dtgImages.TabIndex = 3;
            this.dtgImages.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgImages_RowEnter);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(10, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(869, 296);
            this.webBrowser1.TabIndex = 4;
            // 
            // lnkDownload
            // 
            this.lnkDownload.AutoSize = true;
            this.lnkDownload.Location = new System.Drawing.Point(894, 71);
            this.lnkDownload.Name = "lnkDownload";
            this.lnkDownload.Size = new System.Drawing.Size(138, 13);
            this.lnkDownload.TabIndex = 5;
            this.lnkDownload.TabStop = true;
            this.lnkDownload.Text = "DownlLoad Selected Image";
            this.lnkDownload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDownload_LinkClicked);
            // 
            // lnk
            // 
            this.lnk.AutoSize = true;
            this.lnk.Location = new System.Drawing.Point(922, 93);
            this.lnk.Name = "lnk";
            this.lnk.Size = new System.Drawing.Size(110, 13);
            this.lnk.TabIndex = 6;
            this.lnk.TabStop = true;
            this.lnk.Text = "DownLoad All Images";
            this.lnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtErrors
            // 
            this.txtErrors.ForeColor = System.Drawing.Color.Red;
            this.txtErrors.Location = new System.Drawing.Point(10, 567);
            this.txtErrors.Name = "txtErrors";
            this.txtErrors.Size = new System.Drawing.Size(869, 20);
            this.txtErrors.TabIndex = 7;
            // 
            // linkBrowser
            // 
            this.linkBrowser.AutoSize = true;
            this.linkBrowser.Location = new System.Drawing.Point(905, 116);
            this.linkBrowser.Name = "linkBrowser";
            this.linkBrowser.Size = new System.Drawing.Size(127, 13);
            this.linkBrowser.TabIndex = 8;
            this.linkBrowser.TabStop = true;
            this.linkBrowser.Text = "Show in Extrenal Browser";
            this.linkBrowser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBrowser_LinkClicked);
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 593);
            this.Controls.Add(this.linkBrowser);
            this.Controls.Add(this.txtErrors);
            this.Controls.Add(this.lnk);
            this.Controls.Add(this.lnkDownload);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.dtgImages);
            this.Controls.Add(this.lnkImagesByDate);
            this.Controls.Add(this.cmbDates);
            this.Name = "ImageViewer";
            this.Text = "Image Viewer and Downloader";
            ((System.ComponentModel.ISupportInitialize)(this.dtgImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDates;
        private System.Windows.Forms.LinkLabel lnkImagesByDate;
        private System.Windows.Forms.DataGridView dtgImages;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.LinkLabel lnkDownload;
        private System.Windows.Forms.LinkLabel lnk;
        private System.Windows.Forms.TextBox txtErrors;
        private System.Windows.Forms.LinkLabel linkBrowser;
    }
}

