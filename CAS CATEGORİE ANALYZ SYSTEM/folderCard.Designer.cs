
namespace CAS_CATEGORİE_ANALYZ_SYSTEM
{
    partial class folderCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(folderCard));
            this.listCardPAnel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.moreMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.klasördeGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şimdiAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderDisklbl = new System.Windows.Forms.Label();
            this.folderNamelbl = new System.Windows.Forms.Label();
            this.folderIcon = new System.Windows.Forms.PictureBox();
            this.listCardPAnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.moreMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // listCardPAnel
            // 
            this.listCardPAnel.Controls.Add(this.pictureBox1);
            this.listCardPAnel.Controls.Add(this.folderDisklbl);
            this.listCardPAnel.Controls.Add(this.folderNamelbl);
            this.listCardPAnel.Controls.Add(this.folderIcon);
            this.listCardPAnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listCardPAnel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCardPAnel.Location = new System.Drawing.Point(0, 0);
            this.listCardPAnel.Name = "listCardPAnel";
            this.listCardPAnel.Size = new System.Drawing.Size(800, 52);
            this.listCardPAnel.TabIndex = 0;
            this.listCardPAnel.MouseLeave += new System.EventHandler(this.listCardPAnel_MouseLeave);
            this.listCardPAnel.MouseHover += new System.EventHandler(this.listCardPAnel_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ContextMenuStrip = this.moreMenu1;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(764, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // moreMenu1
            // 
            this.moreMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klasördeGösterToolStripMenuItem,
            this.şimdiAçToolStripMenuItem,
            this.silToolStripMenuItem});
            this.moreMenu1.Name = "moreMenu";
            this.moreMenu1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.moreMenu1.Size = new System.Drawing.Size(181, 92);
            // 
            // klasördeGösterToolStripMenuItem
            // 
            this.klasördeGösterToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.klasördeGösterToolStripMenuItem.Name = "klasördeGösterToolStripMenuItem";
            this.klasördeGösterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.klasördeGösterToolStripMenuItem.Text = "Klasöre Git";
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
            // folderDisklbl
            // 
            this.folderDisklbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderDisklbl.BackColor = System.Drawing.Color.Transparent;
            this.folderDisklbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.folderDisklbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.folderDisklbl.ForeColor = System.Drawing.Color.Silver;
            this.folderDisklbl.Location = new System.Drawing.Point(39, 24);
            this.folderDisklbl.Name = "folderDisklbl";
            this.folderDisklbl.Size = new System.Drawing.Size(706, 22);
            this.folderDisklbl.TabIndex = 3;
            this.folderDisklbl.Text = "?";
            this.folderDisklbl.MouseLeave += new System.EventHandler(this.folderDisklbl_MouseLeave);
            this.folderDisklbl.MouseHover += new System.EventHandler(this.folderDisklbl_MouseHover);
            // 
            // folderNamelbl
            // 
            this.folderNamelbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folderNamelbl.BackColor = System.Drawing.Color.Transparent;
            this.folderNamelbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.folderNamelbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.folderNamelbl.ForeColor = System.Drawing.Color.White;
            this.folderNamelbl.Location = new System.Drawing.Point(38, 7);
            this.folderNamelbl.Name = "folderNamelbl";
            this.folderNamelbl.Size = new System.Drawing.Size(707, 17);
            this.folderNamelbl.TabIndex = 2;
            this.folderNamelbl.Text = "?";
            this.folderNamelbl.MouseLeave += new System.EventHandler(this.folderNamelbl_MouseLeave);
            this.folderNamelbl.MouseHover += new System.EventHandler(this.folderNamelbl_MouseHover);
            // 
            // folderIcon
            // 
            this.folderIcon.BackColor = System.Drawing.Color.Transparent;
            this.folderIcon.Image = ((System.Drawing.Image)(resources.GetObject("folderIcon.Image")));
            this.folderIcon.Location = new System.Drawing.Point(4, 8);
            this.folderIcon.Name = "folderIcon";
            this.folderIcon.Size = new System.Drawing.Size(30, 30);
            this.folderIcon.TabIndex = 1;
            this.folderIcon.TabStop = false;
            // 
            // folderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(95)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(800, 52);
            this.Controls.Add(this.listCardPAnel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "folderCard";
            this.Text = "folderCard";
            this.Load += new System.EventHandler(this.folderCard_Load);
            this.listCardPAnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.moreMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel listCardPAnel;
        private System.Windows.Forms.Label folderDisklbl;
        private System.Windows.Forms.Label folderNamelbl;
        private System.Windows.Forms.PictureBox folderIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip moreMenu1;
        private System.Windows.Forms.ToolStripMenuItem klasördeGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şimdiAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}