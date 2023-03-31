using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAS_CATEGORİE_ANALYZ_SYSTEM
{
    public partial class CAS : Form
    {
        int endClick = 0;
        //----------------------------------------//
        //FORM EKRANDA SURUKLEMEK ICIN INT KONUM DEGISKENLERI VE BOOL
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        //----------------------------------------//

        List<AllFolderAndDocsPage> homePageList = new List<AllFolderAndDocsPage>();
        List<AllFolderAndDocsPage> folderPageList = new List<AllFolderAndDocsPage>();
        List<FilesPage> filesPageList = new List<FilesPage>();
        List<ExtensionsPage> extensionsPageList = new List<ExtensionsPage>();
        List<HistoryPage> historyPageList = new List<HistoryPage>();
        public CAS()
        {
            InitializeComponent();
        }


        private void CAS_Load(object sender, EventArgs e)
        {
            loadHomePage();
        }
        private void loadHomePage()
        {
            for(int i = 0; i < homePageList.Count; i++)
            {
                homePageList[i].Close();
                homePageList[i].Dispose();
                GC.SuppressFinalize(homePageList[i]);
            }
            for (int i = 0; i < folderPageList.Count; i++)
            {
                folderPageList[i].Close();
                folderPageList[i].Dispose();
                GC.SuppressFinalize(folderPageList[i]);
            }
            for (int i = 0; i < filesPageList.Count; i++)
            {
                filesPageList[i].Close();
                filesPageList[i].Dispose();
                GC.SuppressFinalize(filesPageList[i]);
            }
            for (int i = 0; i < extensionsPageList.Count; i++)
            {
                extensionsPageList[i].Close();
                extensionsPageList[i].Dispose();
                GC.SuppressFinalize(extensionsPageList[i]);
            }
            for (int i = 0; i < historyPageList.Count; i++)
            {
                historyPageList[i].Close();
                historyPageList[i].Dispose();
                GC.SuppressFinalize(historyPageList[i]);
            }
            extensionsPageList.Clear();
            filesPageList.Clear();
            homePageList.Clear();
            folderPageList.Clear();
            historyPageList.Clear();
            AllFolderAndDocsPage homePage = new AllFolderAndDocsPage();
            pageVewer.Controls.Clear();
            homePage.Dock = DockStyle.Fill;
            homePage.TopLevel = false;
            homePage.viewPanel = pageVewer;
            pageVewer.Controls.Add(homePage);
            homePage.Show();
            homePageList.Add(homePage);
        }
        private void loadFoldersPage()
        {
            for (int i = 0; i < folderPageList.Count; i++)
            {
                folderPageList[i].Close();
                folderPageList[i].Dispose();
                GC.SuppressFinalize(folderPageList[i]);
            }
            for (int i = 0; i < homePageList.Count; i++)
            {
                homePageList[i].Close();
                homePageList[i].Dispose();
                GC.SuppressFinalize(homePageList[i]);
            }
            for (int i = 0; i < filesPageList.Count; i++)
            {
                filesPageList[i].Close();
                filesPageList[i].Dispose();
                GC.SuppressFinalize(filesPageList[i]);
            }
            for (int i = 0; i < extensionsPageList.Count; i++)
            {
                extensionsPageList[i].Close();
                extensionsPageList[i].Dispose();
                GC.SuppressFinalize(extensionsPageList[i]);
            }
            for (int i = 0; i < historyPageList.Count; i++)
            {
                historyPageList[i].Close();
                historyPageList[i].Dispose();
                GC.SuppressFinalize(historyPageList[i]);
            }
            extensionsPageList.Clear();
            filesPageList.Clear();
            homePageList.Clear();
            folderPageList.Clear();
            historyPageList.Clear();
            AllFolderAndDocsPage FoldersPage = new AllFolderAndDocsPage();
            pageVewer.Controls.Clear();
            FoldersPage.Dock = DockStyle.Fill;
            FoldersPage.TopLevel = false;
            FoldersPage.viewPanel = pageVewer;
            FoldersPage.foldersBtn = true;
            FoldersPage.onlyFiles = false;
            FoldersPage.onlyFolders = true;
            pageVewer.Controls.Add(FoldersPage);
            FoldersPage.Show();
            folderPageList.Add(FoldersPage);

        }
        private void loadFilesPage(bool onlyImages,bool onlyVideos)
        {
            for (int i = 0; i < filesPageList.Count; i++)
            {
                filesPageList[i].Close();
                filesPageList[i].Dispose();
                GC.SuppressFinalize(filesPageList[i]);
            }
            for (int i = 0; i < homePageList.Count; i++)
            {
                homePageList[i].Close();
                homePageList[i].Dispose();
                GC.SuppressFinalize(homePageList[i]);
            }
            for (int i = 0; i < folderPageList.Count; i++)
            {
                folderPageList[i].Close();
                folderPageList[i].Dispose();
                GC.SuppressFinalize(folderPageList[i]);
            }
            for (int i = 0; i < extensionsPageList.Count; i++)
            {
                extensionsPageList[i].Close();
                extensionsPageList[i].Dispose();
                GC.SuppressFinalize(extensionsPageList[i]);
            }
            for (int i = 0; i < historyPageList.Count; i++)
            {
                historyPageList[i].Close();
                historyPageList[i].Dispose();
                GC.SuppressFinalize(historyPageList[i]);
            }
            extensionsPageList.Clear();
            filesPageList.Clear();
            homePageList.Clear();
            folderPageList.Clear();
            historyPageList.Clear();
            FilesPage filesPage = new FilesPage();
            pageVewer.Controls.Clear();
            filesPage.Dock = DockStyle.Fill;
            filesPage.TopLevel = false;
            filesPage.onlyImages = onlyImages;
            filesPage.onlyVideos = onlyVideos;
            pageVewer.Controls.Add(filesPage);
            filesPage.Show();
            filesPageList.Add(filesPage);
        }
        private void loadextensionPage()
        {
            for (int i = 0; i < extensionsPageList.Count; i++)
            {
                extensionsPageList[i].Close();
                extensionsPageList[i].Dispose();
                GC.SuppressFinalize(extensionsPageList[i]);
            }
            for (int i = 0; i < filesPageList.Count; i++)
            {
                filesPageList[i].Close();
                filesPageList[i].Dispose();
                GC.SuppressFinalize(filesPageList[i]);
            }
            for (int i = 0; i < homePageList.Count; i++)
            {
                homePageList[i].Close();
                homePageList[i].Dispose();
                GC.SuppressFinalize(homePageList[i]);
            }
            for (int i = 0; i < folderPageList.Count; i++)
            {
                folderPageList[i].Close();
                folderPageList[i].Dispose();
                GC.SuppressFinalize(folderPageList[i]);
            }
            for (int i = 0; i < historyPageList.Count; i++)
            {
                historyPageList[i].Close();
                historyPageList[i].Dispose();
                GC.SuppressFinalize(historyPageList[i]);
            }
            extensionsPageList.Clear();
            filesPageList.Clear();
            homePageList.Clear();
            folderPageList.Clear();
            historyPageList.Clear();
            pageVewer.Controls.Clear();
            ExtensionsPage exPage = new ExtensionsPage();
            exPage.Dock = DockStyle.Fill;
            exPage.TopLevel = false;
            pageVewer.Controls.Add(exPage);
            exPage.Show();
            extensionsPageList.Add(exPage);
        }
        private void loadHistoryPage()
        {
            for (int i = 0; i < extensionsPageList.Count; i++)
            {
                extensionsPageList[i].Close();
                extensionsPageList[i].Dispose();
                GC.SuppressFinalize(extensionsPageList[i]);
            }
            for (int i = 0; i < filesPageList.Count; i++)
            {
                filesPageList[i].Close();
                filesPageList[i].Dispose();
                GC.SuppressFinalize(filesPageList[i]);
            }
            for (int i = 0; i < homePageList.Count; i++)
            {
                homePageList[i].Close();
                homePageList[i].Dispose();
                GC.SuppressFinalize(homePageList[i]);
            }
            for (int i = 0; i < folderPageList.Count; i++)
            {
                folderPageList[i].Close();
                folderPageList[i].Dispose();
                GC.SuppressFinalize(folderPageList[i]);
            }
            for (int i = 0; i < historyPageList.Count; i++)
            {
                historyPageList[i].Close();
                historyPageList[i].Dispose();
                GC.SuppressFinalize(historyPageList[i]);
            }
            extensionsPageList.Clear();
            filesPageList.Clear();
            homePageList.Clear();
            folderPageList.Clear();
            historyPageList.Clear();
            pageVewer.Controls.Clear();
            // it will go to history page
            HistoryPage historyPage = new HistoryPage();
            historyPage.Dock = DockStyle.Fill;
            historyPage.TopLevel = false;
            pageVewer.Controls.Add(historyPage);
            historyPage.Show();
            historyPageList.Add(historyPage);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                endClick++;
                if (endClick < 2)
                {
                    SoundPlayer sound = new SoundPlayer(@"sounds\end.wav");
                    sound.Play();
                    sound.Dispose();
                    GC.SuppressFinalize(sound);
                }
                for (int i = 0; i < extensionsPageList.Count; i++)
                {
                    extensionsPageList[i].Close();
                    extensionsPageList[i].Dispose();
                    GC.SuppressFinalize(extensionsPageList[i]);
                }
                for (int i = 0; i < filesPageList.Count; i++)
                {
                    filesPageList[i].Close();
                    filesPageList[i].Dispose();
                    GC.SuppressFinalize(filesPageList[i]);
                }
                for (int i = 0; i < homePageList.Count; i++)
                {
                    homePageList[i].Close();
                    homePageList[i].Dispose();
                    GC.SuppressFinalize(homePageList[i]);
                }
                for (int i = 0; i < folderPageList.Count; i++)
                {
                    folderPageList[i].Close();
                    folderPageList[i].Dispose();
                    GC.SuppressFinalize(folderPageList[i]);
                }
                for (int i = 0; i < historyPageList.Count; i++)
                {
                    historyPageList[i].Close();
                    historyPageList[i].Dispose();
                    GC.SuppressFinalize(historyPageList[i]);
                }
                extensionsPageList.Clear();
                filesPageList.Clear();
                homePageList.Clear();
                folderPageList.Clear();
                historyPageList.Clear();
                pageVewer.Controls.Clear();
                Application.Exit();
            }
            catch { }
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"sounds\click.wav");
            sound.Play();
            sound.Dispose();
            GC.SuppressFinalize(sound);
            loadHomePage();
            allBtn.BackColor = Color.FromArgb(0, 80, 120);
            folderBtn.BackColor = Color.FromArgb(30, 95, 130);
            docsBtn.BackColor = Color.FromArgb(30, 95, 130);
            imagesBtn.BackColor = Color.FromArgb(30, 95, 130);
            videosBtn.BackColor = Color.FromArgb(30, 95, 130);
            extensionsBtn.BackColor = Color.FromArgb(30, 95, 130);
            historyBtn.BackColor = Color.FromArgb(30, 95, 130);
        }

        private void formDragBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void formDragBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void formDragBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void folderBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"sounds\click.wav");
            sound.Play();
            sound.Dispose();
            GC.SuppressFinalize(sound);
            loadFoldersPage();
            folderBtn.BackColor = Color.FromArgb(0, 80, 120);
            allBtn.BackColor = Color.FromArgb(30, 95, 130);
            docsBtn.BackColor = Color.FromArgb(30, 95, 130);
            imagesBtn.BackColor = Color.FromArgb(30, 95, 130);
            extensionsBtn.BackColor = Color.FromArgb(30, 95, 130);
            videosBtn.BackColor = Color.FromArgb(30, 95, 130);
            historyBtn.BackColor = Color.FromArgb(30, 95, 130);
        }

        private void docsBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"sounds\click.wav");
            sound.Play();
            sound.Dispose();
            GC.SuppressFinalize(sound);
            loadFilesPage(false,false);
            allBtn.BackColor = Color.FromArgb(30, 95, 130);
            folderBtn.BackColor = Color.FromArgb(30, 95, 130);
            imagesBtn.BackColor = Color.FromArgb(30, 95, 130);
            videosBtn.BackColor = Color.FromArgb(30, 95, 130);
            extensionsBtn.BackColor = Color.FromArgb(30, 95, 130);
            docsBtn.BackColor = Color.FromArgb(0, 80, 120);
            historyBtn.BackColor = Color.FromArgb(30, 95, 130);
        }

        private void imagesBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"sounds\click.wav");
            sound.Play();
            sound.Dispose();
            GC.SuppressFinalize(sound);
            allBtn.BackColor = Color.FromArgb(30, 95, 130);
            folderBtn.BackColor = Color.FromArgb(30, 95, 130);
            docsBtn.BackColor = Color.FromArgb(30, 95, 130);
            videosBtn.BackColor = Color.FromArgb(30, 95, 130);
            extensionsBtn.BackColor = Color.FromArgb(30, 95, 130);
            imagesBtn.BackColor = Color.FromArgb(0, 80, 120);
            historyBtn.BackColor = Color.FromArgb(30, 95, 130);
            loadFilesPage(true,false);
        }

        private void videosBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"sounds\click.wav");
            sound.Play();
            sound.Dispose();
            GC.SuppressFinalize(sound);
            videosBtn.BackColor = Color.FromArgb(0, 80, 120);
            allBtn.BackColor = Color.FromArgb(30, 95, 130);
            folderBtn.BackColor = Color.FromArgb(30, 95, 130);
            docsBtn.BackColor = Color.FromArgb(30, 95, 130);
            imagesBtn.BackColor = Color.FromArgb(30, 95, 130);
            extensionsBtn.BackColor = Color.FromArgb(30, 95, 130);
            historyBtn.BackColor = Color.FromArgb(30, 95, 130);
            loadFilesPage(false, true);
        }

        private void extensionsBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"sounds\click.wav");
            sound.Play();
            sound.Dispose();
            GC.SuppressFinalize(sound);
            extensionsBtn.BackColor = Color.FromArgb(0, 80, 120);
            videosBtn.BackColor = Color.FromArgb(30, 95, 130);
            allBtn.BackColor = Color.FromArgb(30, 95, 130);
            folderBtn.BackColor = Color.FromArgb(30, 95, 130);
            docsBtn.BackColor = Color.FromArgb(30, 95, 130);
            imagesBtn.BackColor = Color.FromArgb(30, 95, 130);
            historyBtn.BackColor = Color.FromArgb(30, 95, 130);
            loadextensionPage();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"sounds\click.wav");
            historyBtn.BackColor = Color.FromArgb(0, 80, 120);
            videosBtn.BackColor = Color.FromArgb(30, 95, 130);
            allBtn.BackColor = Color.FromArgb(30, 95, 130);
            folderBtn.BackColor = Color.FromArgb(30, 95, 130);
            docsBtn.BackColor = Color.FromArgb(30, 95, 130);
            imagesBtn.BackColor = Color.FromArgb(30, 95, 130);
            extensionsBtn.BackColor = Color.FromArgb(30, 95, 130);
            loadHistoryPage();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // it will go to Lists page
        }
    }
}
