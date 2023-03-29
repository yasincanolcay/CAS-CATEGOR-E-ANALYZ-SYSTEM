
namespace CAS_CATEGORİE_ANALYZ_SYSTEM
{
    partial class ExtensionCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtensionCard));
            this.cardPanel = new System.Windows.Forms.Panel();
            this.fileIconPicture = new System.Windows.Forms.PictureBox();
            this.extensionNumberLbl = new System.Windows.Forms.Label();
            this.extensionNameLbl = new System.Windows.Forms.Label();
            this.cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileIconPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // cardPanel
            // 
            this.cardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(65)))), ((int)(((byte)(95)))));
            this.cardPanel.Controls.Add(this.fileIconPicture);
            this.cardPanel.Controls.Add(this.extensionNumberLbl);
            this.cardPanel.Controls.Add(this.extensionNameLbl);
            this.cardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardPanel.Location = new System.Drawing.Point(0, 0);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Size = new System.Drawing.Size(200, 190);
            this.cardPanel.TabIndex = 1;
            // 
            // fileIconPicture
            // 
            this.fileIconPicture.Image = ((System.Drawing.Image)(resources.GetObject("fileIconPicture.Image")));
            this.fileIconPicture.Location = new System.Drawing.Point(85, 133);
            this.fileIconPicture.Name = "fileIconPicture";
            this.fileIconPicture.Size = new System.Drawing.Size(30, 30);
            this.fileIconPicture.TabIndex = 4;
            this.fileIconPicture.TabStop = false;
            // 
            // extensionNumberLbl
            // 
            this.extensionNumberLbl.AutoEllipsis = true;
            this.extensionNumberLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.extensionNumberLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(150)))));
            this.extensionNumberLbl.Location = new System.Drawing.Point(3, 77);
            this.extensionNumberLbl.Name = "extensionNumberLbl";
            this.extensionNumberLbl.Size = new System.Drawing.Size(194, 42);
            this.extensionNumberLbl.TabIndex = 2;
            this.extensionNumberLbl.Text = "?";
            this.extensionNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // extensionNameLbl
            // 
            this.extensionNameLbl.AutoEllipsis = true;
            this.extensionNameLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.extensionNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(140)))));
            this.extensionNameLbl.Location = new System.Drawing.Point(3, 4);
            this.extensionNameLbl.Name = "extensionNameLbl";
            this.extensionNameLbl.Size = new System.Drawing.Size(194, 73);
            this.extensionNameLbl.TabIndex = 1;
            this.extensionNameLbl.Text = "?";
            this.extensionNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExtensionCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(200, 190);
            this.Controls.Add(this.cardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExtensionCard";
            this.Text = "ExtensionCard";
            this.Load += new System.EventHandler(this.ExtensionCard_Load);
            this.cardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileIconPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cardPanel;
        private System.Windows.Forms.PictureBox fileIconPicture;
        private System.Windows.Forms.Label extensionNumberLbl;
        private System.Windows.Forms.Label extensionNameLbl;
    }
}