
namespace CAS_CATEGORİE_ANALYZ_SYSTEM
{
    partial class filesCard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filesCard));
            this.listCardPAnel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.morePicturebox = new System.Windows.Forms.PictureBox();
            this.moreMenu3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.klasördeGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şimdiAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePathlbl = new System.Windows.Forms.Label();
            this.fileNamelbl = new System.Windows.Forms.Label();
            this.fileIcon = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listCardPAnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.morePicturebox)).BeginInit();
            this.moreMenu3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // listCardPAnel
            // 
            this.listCardPAnel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listCardPAnel.Controls.Add(this.panel2);
            this.listCardPAnel.Controls.Add(this.panel1);
            this.listCardPAnel.Controls.Add(this.morePicturebox);
            this.listCardPAnel.Controls.Add(this.filePathlbl);
            this.listCardPAnel.Controls.Add(this.fileNamelbl);
            this.listCardPAnel.Controls.Add(this.fileIcon);
            this.listCardPAnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listCardPAnel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCardPAnel.Location = new System.Drawing.Point(10, 0);
            this.listCardPAnel.Name = "listCardPAnel";
            this.listCardPAnel.Size = new System.Drawing.Size(790, 52);
            this.listCardPAnel.TabIndex = 1;
            this.listCardPAnel.MouseLeave += new System.EventHandler(this.listCardPAnel_MouseLeave);
            this.listCardPAnel.MouseHover += new System.EventHandler(this.listCardPAnel_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(8, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 5);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(8, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 30);
            this.panel1.TabIndex = 5;
            // 
            // morePicturebox
            // 
            this.morePicturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.morePicturebox.ContextMenuStrip = this.moreMenu3;
            this.morePicturebox.Image = ((System.Drawing.Image)(resources.GetObject("morePicturebox.Image")));
            this.morePicturebox.Location = new System.Drawing.Point(754, 10);
            this.morePicturebox.Name = "morePicturebox";
            this.morePicturebox.Size = new System.Drawing.Size(30, 30);
            this.morePicturebox.TabIndex = 4;
            this.morePicturebox.TabStop = false;
            // 
            // moreMenu3
            // 
            this.moreMenu3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klasördeGösterToolStripMenuItem,
            this.şimdiAçToolStripMenuItem,
            this.silToolStripMenuItem});
            this.moreMenu3.Name = "moreMenu3";
            this.moreMenu3.Size = new System.Drawing.Size(181, 92);
            // 
            // klasördeGösterToolStripMenuItem
            // 
            this.klasördeGösterToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.klasördeGösterToolStripMenuItem.Name = "klasördeGösterToolStripMenuItem";
            this.klasördeGösterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.klasördeGösterToolStripMenuItem.Text = "Klasörde Göster";
            this.klasördeGösterToolStripMenuItem.Click += new System.EventHandler(this.klasördeGösterToolStripMenuItem_Click);
            // 
            // şimdiAçToolStripMenuItem
            // 
            this.şimdiAçToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.şimdiAçToolStripMenuItem.Name = "şimdiAçToolStripMenuItem";
            this.şimdiAçToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.şimdiAçToolStripMenuItem.Text = "Şimdi Aç";
            this.şimdiAçToolStripMenuItem.Click += new System.EventHandler(this.şimdiAçToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // filePathlbl
            // 
            this.filePathlbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathlbl.BackColor = System.Drawing.Color.Transparent;
            this.filePathlbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filePathlbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filePathlbl.ForeColor = System.Drawing.Color.Silver;
            this.filePathlbl.Location = new System.Drawing.Point(74, 24);
            this.filePathlbl.Name = "filePathlbl";
            this.filePathlbl.Size = new System.Drawing.Size(676, 22);
            this.filePathlbl.TabIndex = 3;
            this.filePathlbl.Text = "?";
            this.filePathlbl.MouseLeave += new System.EventHandler(this.filePathlbl_MouseLeave);
            this.filePathlbl.MouseHover += new System.EventHandler(this.filePathlbl_MouseHover);
            // 
            // fileNamelbl
            // 
            this.fileNamelbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNamelbl.BackColor = System.Drawing.Color.Transparent;
            this.fileNamelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fileNamelbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fileNamelbl.ForeColor = System.Drawing.Color.White;
            this.fileNamelbl.Location = new System.Drawing.Point(73, 7);
            this.fileNamelbl.Name = "fileNamelbl";
            this.fileNamelbl.Size = new System.Drawing.Size(677, 17);
            this.fileNamelbl.TabIndex = 2;
            this.fileNamelbl.Text = "?";
            this.fileNamelbl.MouseLeave += new System.EventHandler(this.fileNamelbl_MouseLeave);
            this.fileNamelbl.MouseHover += new System.EventHandler(this.fileNamelbl_MouseHover);
            // 
            // fileIcon
            // 
            this.fileIcon.BackColor = System.Drawing.Color.Transparent;
            this.fileIcon.Image = ((System.Drawing.Image)(resources.GetObject("fileIcon.Image")));
            this.fileIcon.Location = new System.Drawing.Point(43, 8);
            this.fileIcon.Name = "fileIcon";
            this.fileIcon.Size = new System.Drawing.Size(30, 30);
            this.fileIcon.TabIndex = 1;
            this.fileIcon.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 52);
            this.panel3.TabIndex = 8;
            // 
            // filesCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(95)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(800, 52);
            this.Controls.Add(this.listCardPAnel);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "filesCard";
            this.Text = "filesCard";
            this.Load += new System.EventHandler(this.filesCard_Load);
            this.listCardPAnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.morePicturebox)).EndInit();
            this.moreMenu3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel listCardPAnel;
        private System.Windows.Forms.PictureBox morePicturebox;
        private System.Windows.Forms.Label filePathlbl;
        private System.Windows.Forms.Label fileNamelbl;
        private System.Windows.Forms.PictureBox fileIcon;
        private System.Windows.Forms.ContextMenuStrip moreMenu3;
        private System.Windows.Forms.ToolStripMenuItem klasördeGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şimdiAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}