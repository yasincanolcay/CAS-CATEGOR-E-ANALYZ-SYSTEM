using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAS_CATEGORİE_ANALYZ_SYSTEM
{
    public partial class FilesPage : Form
    {
        int totalFileSize = 0;
        int totalFiles = 0;
        public bool onlyImages = false;
        public bool onlyVideos = false;
        List<filesCard> filesCardList = new List<filesCard>();
        public FilesPage()
        {
            InitializeComponent();
        }

        private void FilesPage_Load(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"sounds\data.wav");
            sound.Play();
            sound.Dispose();
            GC.SuppressFinalize(sound);
            if (!onlyImages&&!onlyVideos)
            {
                Main();
            }
            else if(onlyImages)
            {
                loadImages();
            }
            else if (onlyVideos)
            {
                loadVideos();
            }
        }

        void Main()
        {
            infoLbl.Text = "Tüm dosyalar listeleniyor...";
            totalFileSize = 0;
            for(int i = 0; i < filesCardList.Count; i++)
            {
                filesCardList[i].Dispose();
                GC.SuppressFinalize(filesCardList[i]);
            }
            pageViewer.Controls.Clear();
            // Bilgisayardaki tüm sabit sürücülerin yollarını al
            string[] drives = Environment.GetLogicalDrives();

            // Her sürücü için dosyaların bilgilerini al ve yazdır
            foreach (string drive in drives)
            {
                try
                {
                    var files = Directory.EnumerateFiles(drive, "*", SearchOption.AllDirectories);
                    // Klasöre erişim izni alınması
                    DirectorySecurity security = Directory.GetAccessControl(drive);
                    AuthorizationRuleCollection rules = security.GetAccessRules(true, true, typeof(NTAccount));
                    foreach (var file in files)
                    {
                        // Dosyaya erişim izni alınması
                        FileSecurity fileSecurity = File.GetAccessControl(file);
                        AuthorizationRuleCollection fileRules = fileSecurity.GetAccessRules(true, true, typeof(NTAccount));
                        filesCard card = new filesCard();
                        card.Dock = DockStyle.Fill;
                        card.TopLevel = false;
                        card.fileName = Path.GetFileName(file);
                        card.filePath = Path.GetDirectoryName(file);
                        card.fileExt = Path.GetExtension(file);
                        pageViewer.Controls.Add(card);
                        card.Show();
                        filesCardList.Add(card);
                        long fileSize = GetFileSize(Path.GetFullPath(file));
                        totalFileSize += int.Parse(fileSize.ToString());
                        totalFiles++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata: {ex.Message}");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
            totalSizelbl.Text = "Boyut: " + totalFileSize.ToString();
            infoLbl.Text = "Tüm dosyalar listeleniyor... "+totalFiles.ToString();
            SoundPlayer sound = new SoundPlayer(@"sounds\ui.wav");
            sound.Play();
            sound.Dispose();
            GC.SuppressFinalize(sound);
        }

        void loadImages()
        {
            totalFileSize = 0;
            infoLbl.Text = "Tüm görüntü dosyaları listeleniyor...";
            for (int i = 0; i < filesCardList.Count; i++)
            {
                filesCardList[i].Dispose();
                GC.SuppressFinalize(filesCardList[i]);
            }
            pageViewer.Controls.Clear();
            // Bilgisayardaki tüm sabit sürücülerin yollarını al
            string[] drives = Environment.GetLogicalDrives();

            // Her sürücü için dosyaların bilgilerini al ve yazdır
            foreach (string drive in drives)
            {
                try
                {
                    // Klasöre erişim izni alınması
                    DirectorySecurity security = Directory.GetAccessControl(drive);
                    AuthorizationRuleCollection rules = security.GetAccessRules(true, true, typeof(NTAccount));
                    var files = Directory.EnumerateFiles(drive, "*.*", SearchOption.AllDirectories)
                        .Where(file => file.EndsWith(".jpg") || file.EndsWith(".png") || file.EndsWith(".bmp") || file.EndsWith(".gif") || file.EndsWith(".jpeg") || file.EndsWith(".tif") || file.EndsWith(".tiff") || file.EndsWith(".ai") || file.EndsWith(".psd"));

                    foreach (var file in files)
                    {
                        // Dosyaya erişim izni alınması
                        FileSecurity fileSecurity = File.GetAccessControl(file);
                        AuthorizationRuleCollection fileRules = fileSecurity.GetAccessRules(true, true, typeof(NTAccount));
                        filesCard card = new filesCard();
                        card.Dock = DockStyle.Fill;
                        card.TopLevel = false;
                        card.fileName = Path.GetFileName(file);
                        card.filePath = Path.GetDirectoryName(file);
                        card.fileExt = Path.GetExtension(file);
                        pageViewer.Controls.Add(card);
                        card.Show();
                        filesCardList.Add(card);
                        long fileSize = GetFileSize(Path.GetFullPath(file));
                        totalFileSize += int.Parse(fileSize.ToString());
                        totalFiles++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata: {ex.Message}");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
            totalSizelbl.Text = "Boyut: " + totalFileSize.ToString();
            infoLbl.Text = "Tüm görüntü dosyaları listeleniyor... "+totalFiles.ToString();
            SoundPlayer sound = new SoundPlayer(@"sounds\ui.wav");
            sound.Play();
            sound.Dispose();
            GC.SuppressFinalize(sound);
        }


        void loadVideos()
        {
            totalFileSize = 0;
            infoLbl.Text = "Tüm video dosyaları listeleniyor...";
            for (int i = 0; i < filesCardList.Count; i++)
            {
                filesCardList[i].Dispose();
                GC.SuppressFinalize(filesCardList[i]);
            }
            pageViewer.Controls.Clear();
            // Bilgisayardaki tüm sabit sürücülerin yollarını al
            string[] drives = Environment.GetLogicalDrives();

            // Her sürücü için dosyaların bilgilerini al ve yazdır
            foreach (string drive in drives)
            {
                try
                {
                    // Klasöre erişim izni alınması
                    DirectorySecurity security = Directory.GetAccessControl(drive);
                    AuthorizationRuleCollection rules = security.GetAccessRules(true, true, typeof(NTAccount));
                    var files = Directory.EnumerateFiles(drive, "*.*", SearchOption.AllDirectories)
       .Where(file => file.EndsWith(".mp4") || file.EndsWith(".avi") || file.EndsWith(".mov") || file.EndsWith(".wmv") || file.EndsWith(".flv") || file.EndsWith(".mkv") || file.EndsWith(".m4v") || file.EndsWith(".webm"));

                    foreach (var file in files)
                    {
                        // Dosyaya erişim izni alınması
                        FileSecurity fileSecurity = File.GetAccessControl(file);
                        AuthorizationRuleCollection fileRules = fileSecurity.GetAccessRules(true, true, typeof(NTAccount));
                        filesCard card = new filesCard();
                        card.Dock = DockStyle.Fill;
                        card.TopLevel = false;
                        card.fileName = Path.GetFileName(file);
                        card.filePath = Path.GetDirectoryName(file);
                        card.fileExt = Path.GetExtension(file);
                        pageViewer.Controls.Add(card);
                        card.Show();
                        filesCardList.Add(card);
                        long fileSize = GetFileSize(Path.GetFullPath(file));
                        totalFileSize += int.Parse(fileSize.ToString());
                        totalFiles++;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata: {ex.Message}");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
            totalSizelbl.Text = "Boyut: " + totalFileSize.ToString();
            infoLbl.Text = "Tüm video dosyaları listeleniyor... "+totalFiles.ToString();
            SoundPlayer sound = new SoundPlayer(@"sounds\ui.wav");
            sound.Play();
            sound.Dispose();
            GC.SuppressFinalize(sound);
        }
        static long GetFileSize(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            return fileInfo.Length;
        }

        private void FilesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < filesCardList.Count; i++)
            {
                filesCardList[i].Dispose();
                GC.SuppressFinalize(filesCardList[i]);
            }
        }
    }
}
