
namespace CAS_CATEGORİE_ANALYZ_SYSTEM
{
    partial class CAS
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAS));
            this.pageVewer = new System.Windows.Forms.Panel();
            this.appBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.extensionsBtn = new System.Windows.Forms.Button();
            this.videosBtn = new System.Windows.Forms.Button();
            this.imagesBtn = new System.Windows.Forms.Button();
            this.docsBtn = new System.Windows.Forms.Button();
            this.folderBtn = new System.Windows.Forms.Button();
            this.allBtn = new System.Windows.Forms.Button();
            this.formDragBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.appBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.formDragBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pageVewer
            // 
            this.pageVewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.pageVewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageVewer.Location = new System.Drawing.Point(0, 67);
            this.pageVewer.Name = "pageVewer";
            this.pageVewer.Size = new System.Drawing.Size(908, 505);
            this.pageVewer.TabIndex = 0;
            // 
            // appBar
            // 
            this.appBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(95)))), ((int)(((byte)(130)))));
            this.appBar.Controls.Add(this.panel1);
            this.appBar.Controls.Add(this.button1);
            this.appBar.Controls.Add(this.historyBtn);
            this.appBar.Controls.Add(this.extensionsBtn);
            this.appBar.Controls.Add(this.videosBtn);
            this.appBar.Controls.Add(this.imagesBtn);
            this.appBar.Controls.Add(this.docsBtn);
            this.appBar.Controls.Add(this.folderBtn);
            this.appBar.Controls.Add(this.allBtn);
            this.appBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.appBar.Location = new System.Drawing.Point(0, 25);
            this.appBar.Name = "appBar";
            this.appBar.Size = new System.Drawing.Size(908, 42);
            this.appBar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(856, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 42);
            this.panel1.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(12, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(671, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 25);
            this.button1.TabIndex = 7;
            this.button1.Text = "Listeler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // historyBtn
            // 
            this.historyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.historyBtn.FlatAppearance.BorderSize = 0;
            this.historyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.historyBtn.ForeColor = System.Drawing.Color.White;
            this.historyBtn.Location = new System.Drawing.Point(578, 17);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(93, 25);
            this.historyBtn.TabIndex = 6;
            this.historyBtn.Text = "Geçmiş";
            this.historyBtn.UseVisualStyleBackColor = true;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // extensionsBtn
            // 
            this.extensionsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.extensionsBtn.FlatAppearance.BorderSize = 0;
            this.extensionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extensionsBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.extensionsBtn.ForeColor = System.Drawing.Color.White;
            this.extensionsBtn.Location = new System.Drawing.Point(485, 17);
            this.extensionsBtn.Name = "extensionsBtn";
            this.extensionsBtn.Size = new System.Drawing.Size(93, 25);
            this.extensionsBtn.TabIndex = 5;
            this.extensionsBtn.Text = "Uzantılar";
            this.extensionsBtn.UseVisualStyleBackColor = true;
            this.extensionsBtn.Click += new System.EventHandler(this.extensionsBtn_Click);
            // 
            // videosBtn
            // 
            this.videosBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.videosBtn.FlatAppearance.BorderSize = 0;
            this.videosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videosBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.videosBtn.ForeColor = System.Drawing.Color.White;
            this.videosBtn.Location = new System.Drawing.Point(392, 17);
            this.videosBtn.Name = "videosBtn";
            this.videosBtn.Size = new System.Drawing.Size(93, 25);
            this.videosBtn.TabIndex = 4;
            this.videosBtn.Text = "Videolar";
            this.videosBtn.UseVisualStyleBackColor = true;
            this.videosBtn.Click += new System.EventHandler(this.videosBtn_Click);
            // 
            // imagesBtn
            // 
            this.imagesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imagesBtn.FlatAppearance.BorderSize = 0;
            this.imagesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imagesBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.imagesBtn.ForeColor = System.Drawing.Color.White;
            this.imagesBtn.Location = new System.Drawing.Point(299, 17);
            this.imagesBtn.Name = "imagesBtn";
            this.imagesBtn.Size = new System.Drawing.Size(93, 25);
            this.imagesBtn.TabIndex = 3;
            this.imagesBtn.Text = "Görüntüler";
            this.imagesBtn.UseVisualStyleBackColor = true;
            this.imagesBtn.Click += new System.EventHandler(this.imagesBtn_Click);
            // 
            // docsBtn
            // 
            this.docsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.docsBtn.FlatAppearance.BorderSize = 0;
            this.docsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.docsBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.docsBtn.ForeColor = System.Drawing.Color.White;
            this.docsBtn.Location = new System.Drawing.Point(206, 17);
            this.docsBtn.Name = "docsBtn";
            this.docsBtn.Size = new System.Drawing.Size(93, 25);
            this.docsBtn.TabIndex = 2;
            this.docsBtn.Text = "Dosyalar";
            this.docsBtn.UseVisualStyleBackColor = true;
            this.docsBtn.Click += new System.EventHandler(this.docsBtn_Click);
            // 
            // folderBtn
            // 
            this.folderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.folderBtn.FlatAppearance.BorderSize = 0;
            this.folderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.folderBtn.ForeColor = System.Drawing.Color.White;
            this.folderBtn.Location = new System.Drawing.Point(113, 17);
            this.folderBtn.Name = "folderBtn";
            this.folderBtn.Size = new System.Drawing.Size(93, 25);
            this.folderBtn.TabIndex = 1;
            this.folderBtn.Text = "Klasörler";
            this.folderBtn.UseVisualStyleBackColor = true;
            this.folderBtn.Click += new System.EventHandler(this.folderBtn_Click);
            // 
            // allBtn
            // 
            this.allBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.allBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.allBtn.FlatAppearance.BorderSize = 0;
            this.allBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.allBtn.ForeColor = System.Drawing.Color.White;
            this.allBtn.Location = new System.Drawing.Point(20, 17);
            this.allBtn.Name = "allBtn";
            this.allBtn.Size = new System.Drawing.Size(93, 25);
            this.allBtn.TabIndex = 0;
            this.allBtn.Text = "Tümü";
            this.allBtn.UseVisualStyleBackColor = false;
            this.allBtn.Click += new System.EventHandler(this.allBtn_Click);
            // 
            // formDragBar
            // 
            this.formDragBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(115)))), ((int)(((byte)(180)))));
            this.formDragBar.Controls.Add(this.label2);
            this.formDragBar.Controls.Add(this.pictureBox1);
            this.formDragBar.Controls.Add(this.minimizeButton);
            this.formDragBar.Controls.Add(this.maximizeButton);
            this.formDragBar.Controls.Add(this.closeButton);
            this.formDragBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.formDragBar.Location = new System.Drawing.Point(0, 0);
            this.formDragBar.Name = "formDragBar";
            this.formDragBar.Size = new System.Drawing.Size(908, 25);
            this.formDragBar.TabIndex = 1;
            this.formDragBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formDragBar_MouseDown);
            this.formDragBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formDragBar_MouseMove);
            this.formDragBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formDragBar_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(25, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "CAS CATAGORİES ANALYSİS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.Location = new System.Drawing.Point(843, 2);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("maximizeButton.Image")));
            this.maximizeButton.Location = new System.Drawing.Point(864, 2);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(20, 20);
            this.maximizeButton.TabIndex = 1;
            this.maximizeButton.UseVisualStyleBackColor = true;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(885, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(908, 572);
            this.Controls.Add(this.pageVewer);
            this.Controls.Add(this.appBar);
            this.Controls.Add(this.formDragBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAS";
            this.Load += new System.EventHandler(this.CAS_Load);
            this.appBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.formDragBar.ResumeLayout(false);
            this.formDragBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pageVewer;
        private System.Windows.Forms.Panel appBar;
        private System.Windows.Forms.Panel formDragBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button extensionsBtn;
        private System.Windows.Forms.Button videosBtn;
        private System.Windows.Forms.Button imagesBtn;
        private System.Windows.Forms.Button docsBtn;
        private System.Windows.Forms.Button folderBtn;
        private System.Windows.Forms.Button allBtn;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}

