namespace CAS_CATEGORİE_ANALYZ_SYSTEM
{
    partial class HistoryCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryCard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.folderOrFilePic = new System.Windows.Forms.PictureBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.pathLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datetimeLbl = new System.Windows.Forms.Label();
            this.processLbl = new System.Windows.Forms.Label();
            this.deletePicture = new System.Windows.Forms.PictureBox();
            this.goFolderPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderOrFilePic)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goFolderPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.goFolderPicture);
            this.panel1.Controls.Add(this.deletePicture);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pathLbl);
            this.panel1.Controls.Add(this.nameLbl);
            this.panel1.Controls.Add(this.folderOrFilePic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 84);
            this.panel1.TabIndex = 0;
            // 
            // folderOrFilePic
            // 
            this.folderOrFilePic.Image = ((System.Drawing.Image)(resources.GetObject("folderOrFilePic.Image")));
            this.folderOrFilePic.Location = new System.Drawing.Point(4, 5);
            this.folderOrFilePic.Name = "folderOrFilePic";
            this.folderOrFilePic.Size = new System.Drawing.Size(30, 30);
            this.folderOrFilePic.TabIndex = 0;
            this.folderOrFilePic.TabStop = false;
            // 
            // nameLbl
            // 
            this.nameLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(38, 5);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(615, 18);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Klasör veya Dosya Adı";
            // 
            // pathLbl
            // 
            this.pathLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pathLbl.ForeColor = System.Drawing.Color.Silver;
            this.pathLbl.Location = new System.Drawing.Point(38, 23);
            this.pathLbl.Name = "pathLbl";
            this.pathLbl.Size = new System.Drawing.Size(615, 17);
            this.pathLbl.TabIndex = 2;
            this.pathLbl.Text = "yol://ornekyol//ornekdosya.ext";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.panel2.Controls.Add(this.processLbl);
            this.panel2.Controls.Add(this.datetimeLbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 41);
            this.panel2.TabIndex = 3;
            // 
            // datetimeLbl
            // 
            this.datetimeLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datetimeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(140)))));
            this.datetimeLbl.Location = new System.Drawing.Point(4, 2);
            this.datetimeLbl.Name = "datetimeLbl";
            this.datetimeLbl.Size = new System.Drawing.Size(186, 20);
            this.datetimeLbl.TabIndex = 1;
            this.datetimeLbl.Text = "Tarih: 29/03/2023 4:00";
            // 
            // processLbl
            // 
            this.processLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.processLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(140)))));
            this.processLbl.Location = new System.Drawing.Point(196, 2);
            this.processLbl.Name = "processLbl";
            this.processLbl.Size = new System.Drawing.Size(360, 20);
            this.processLbl.TabIndex = 2;
            this.processLbl.Text = "İşlem: \'Önemliler\'  listesine eklendi";
            // 
            // deletePicture
            // 
            this.deletePicture.Image = ((System.Drawing.Image)(resources.GetObject("deletePicture.Image")));
            this.deletePicture.Location = new System.Drawing.Point(783, 6);
            this.deletePicture.Name = "deletePicture";
            this.deletePicture.Size = new System.Drawing.Size(30, 30);
            this.deletePicture.TabIndex = 4;
            this.deletePicture.TabStop = false;
            this.deletePicture.Click += new System.EventHandler(this.deletePicture_Click);
            // 
            // goFolderPicture
            // 
            this.goFolderPicture.Image = ((System.Drawing.Image)(resources.GetObject("goFolderPicture.Image")));
            this.goFolderPicture.Location = new System.Drawing.Point(747, 6);
            this.goFolderPicture.Name = "goFolderPicture";
            this.goFolderPicture.Size = new System.Drawing.Size(30, 30);
            this.goFolderPicture.TabIndex = 5;
            this.goFolderPicture.TabStop = false;
            this.goFolderPicture.Click += new System.EventHandler(this.goFolderPicture_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(711, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // HistoryCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(819, 84);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryCard";
            this.Text = "HistoryCard";
            this.Load += new System.EventHandler(this.HistoryCard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.folderOrFilePic)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deletePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goFolderPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox folderOrFilePic;
        private System.Windows.Forms.Label pathLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label processLbl;
        private System.Windows.Forms.Label datetimeLbl;
        private System.Windows.Forms.PictureBox deletePicture;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox goFolderPicture;
    }
}