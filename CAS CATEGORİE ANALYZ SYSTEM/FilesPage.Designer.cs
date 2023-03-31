
namespace CAS_CATEGORİE_ANALYZ_SYSTEM
{
    partial class FilesPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesPage));
            this.topPanel = new System.Windows.Forms.Panel();
            this.infoLbl = new System.Windows.Forms.Label();
            this.totalSizelbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.pageViewer = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.pictureBox2);
            this.topPanel.Controls.Add(this.infoLbl);
            this.topPanel.Controls.Add(this.totalSizelbl);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.searchBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(839, 24);
            this.topPanel.TabIndex = 0;
            // 
            // infoLbl
            // 
            this.infoLbl.AutoEllipsis = true;
            this.infoLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infoLbl.ForeColor = System.Drawing.Color.Silver;
            this.infoLbl.Location = new System.Drawing.Point(157, 3);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(219, 16);
            this.infoLbl.TabIndex = 8;
            this.infoLbl.Text = "Tüm görüntü dosyaları listeleniyor...";
            // 
            // totalSizelbl
            // 
            this.totalSizelbl.AutoEllipsis = true;
            this.totalSizelbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalSizelbl.ForeColor = System.Drawing.Color.Silver;
            this.totalSizelbl.Location = new System.Drawing.Point(5, 4);
            this.totalSizelbl.Name = "totalSizelbl";
            this.totalSizelbl.Size = new System.Drawing.Size(146, 16);
            this.totalSizelbl.TabIndex = 7;
            this.totalSizelbl.Text = "Boyut:956 Gb";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(781, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(95)))), ((int)(((byte)(130)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Location = new System.Drawing.Point(557, 4);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(221, 16);
            this.searchBox.TabIndex = 4;
            // 
            // pageViewer
            // 
            this.pageViewer.AutoScroll = true;
            this.pageViewer.ColumnCount = 1;
            this.pageViewer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageViewer.Location = new System.Drawing.Point(0, 24);
            this.pageViewer.Name = "pageViewer";
            this.pageViewer.RowCount = 3;
            this.pageViewer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pageViewer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pageViewer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pageViewer.Size = new System.Drawing.Size(839, 379);
            this.pageViewer.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(807, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // FilesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(839, 403);
            this.Controls.Add(this.pageViewer);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FilesPage";
            this.Text = "FilesPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FilesPage_FormClosing);
            this.Load += new System.EventHandler(this.FilesPage_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TableLayoutPanel pageViewer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label totalSizelbl;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}