using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CAS_CATEGORİE_ANALYZ_SYSTEM
{
    public partial class AllFolderAndDocsPage : Form
    {
        private const string Info = "";
        public Panel viewPanel = new Panel();
        public bool foldersBtn = false;
        public bool onlyFiles = true;
        public bool onlyFolders = true;
        private List<filesCard> fcardlist = new List<filesCard>();
        private List<subfoldersCard> subFolderlist = new List<subfoldersCard>();
        private List<folderCard> folderCardlist = new List<folderCard>();
        int totalFileSize = 0;
        private string info = "";

        public AllFolderAndDocsPage()
        {
            InitializeComponent();
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;
        }

        private void AllFolderAndDocsPage_Load(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"sounds\data.wav");
            info = "Tümü listeleniyor";
            sound.Play();
            sound.Dispose();
            GC.SuppressFinalize(sound);
            loadFolders();
            if (foldersBtn)
            {
                panel1.Visible = false;
            }
        }
        private void loadFolders()
        {
            totalFileSize = 0;
            infoLbl.Text = info;
            for (int i=0;i<folderCardlist.Count;i++)
            {
                folderCardlist[i].Dispose();
                GC.SuppressFinalize(folderCardlist[i]);
            }
            for (int i = 0; i < fcardlist.Count; i++)
            {
                fcardlist[i].Dispose();
                GC.SuppressFinalize(fcardlist[i]);
            }
            for (int i = 0; i < subFolderlist.Count; i++)
            {
                subFolderlist[i].Dispose();
                GC.SuppressFinalize(subFolderlist[i]);
            }
            viewerPanel.Controls.Clear();//paneli temizle
            DriveInfo[] drives = DriveInfo.GetDrives();//sabit sürücüleri al
            //sabit sürücülerin hepsini oku
            foreach (DriveInfo drive in drives)
            {
                //sabit sürücü kontrolü
                if (drive.DriveType == DriveType.Fixed) // yalnızca sabit sürücüler
                {
                    //sürücülerin path'ini al
                    string[] directories = Directory.GetDirectories(drive.RootDirectory.FullName, "*", SearchOption.TopDirectoryOnly);
                    //ve sürücülerdeki klasörleri okul
                    foreach (string directory in directories)
                    {
                        try
                        {
                            // Klasöre erişim izni alınması
                            DirectorySecurity security = Directory.GetAccessControl(directory);
                            AuthorizationRuleCollection rules = security.GetAccessRules(true, true, typeof(NTAccount));
                            string folderPath = Path.GetDirectoryName(directory);//klasör yolunu al
                            string folderName = Path.GetFileName(directory);//klasör ismini al
                            if (onlyFolders) {
                                folderCard card = new folderCard(); //görüntülenecek form kartını oluştur
                                card.Dock = DockStyle.Top;
                                card.TopLevel = false;
                                card.viewPAnel = viewPanel;
                                card.viewerPanel = viewerPanel;
                                card.folderName = folderName;
                                card.folderDisk = folderPath;
                                card.onlyFiles = onlyFiles;
                                card.onlyFolders = onlyFolders;
                                card.folderCardList = folderCardlist;
                                card.filesCardList = fcardlist;
                                card.subFolderCardList = subFolderlist;
                                viewerPanel.Controls.Add(card);//panele ekle
                                card.Show();//göster
                                folderCardlist.Add(card);
                            }

                            if (onlyFiles)
                            {
                                //alt dizindeki dosyalarıda al
                                string[] files = Directory.GetFiles(directory, "*", SearchOption.TopDirectoryOnly);
                                //kaç tane dosya varsa oku
                                foreach (string file in files)
                                {
                                    try
                                    {
                                        // Dosyaya erişim izni alınması
                                        FileSecurity fileSecurity = File.GetAccessControl(file);
                                        AuthorizationRuleCollection fileRules = fileSecurity.GetAccessRules(true, true, typeof(NTAccount));
                                        string filePath = Path.GetDirectoryName(file);//dosya yolunu al
                                        string fileName = Path.GetFileName(file);//dosya ismini al
                                                                                 //dosya uzantılarını da almak için
                                        string fileExtension = Path.GetExtension(file);//uzantıyı alır
                                        filesCard fCard = new filesCard();
                                        fCard.Dock = DockStyle.Top;
                                        fCard.TopLevel = false;
                                        fCard.fileName = fileName;
                                        fCard.filePath = filePath;
                                        fCard.fileExt = fileExtension;
                                        fCard.viewPAnel = viewPanel;
                                        fCard.viewerPanel = viewerPanel;
                                        viewerPanel.Controls.Add(fCard);
                                        fCard.Show();
                                        fcardlist.Add(fCard);
                                        long fileSize = GetFileSize(filePath+"//"+fileName+fileExtension);
                                        totalFileSize += int.Parse(fileSize.ToString());
                                    }
                                    catch (UnauthorizedAccessException ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                }
                            }
                            if (onlyFolders)
                            {

                                // Alt klasörleri alınması
                                string[] subdirectories = Directory.GetDirectories(directory, "*", SearchOption.TopDirectoryOnly);

                                foreach (string subdirectory in subdirectories)
                                {
                                    try
                                    {
                                        // Alt klasöre erişim izni alınması
                                        DirectorySecurity subdirectorySecurity = Directory.GetAccessControl(subdirectory);
                                        AuthorizationRuleCollection subdirectoryRules = subdirectorySecurity.GetAccessRules(true, true, typeof(NTAccount));
                                        string subdirectoryPath = Path.GetDirectoryName(subdirectory);
                                        string subdirectoryName = Path.GetFileName(subdirectory);


                                        subfoldersCard card2 = new subfoldersCard(); //görüntülenecek form kartını oluştur
                                        card2.Dock = DockStyle.Top;
                                        card2.TopLevel = false;
                                        card2.viewPAnel = viewPanel;
                                        card2.viewerPanel = viewerPanel;
                                        card2.folderName = subdirectoryName;
                                        card2.folderDisk = subdirectoryPath;
                                        card2.onlyFolders = onlyFolders;
                                        card2.onlyFiles = onlyFiles;
                                        viewerPanel.Controls.Add(card2);//panele ekle
                                        card2.Show();//göster
                                        subFolderlist.Add(card2);

                                    }
                                    catch (UnauthorizedAccessException ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                }
                            }
                        }
                        catch (UnauthorizedAccessException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }

            totalSizelbl.Text = totalFileSize.ToString()+" KB/GB";
            SoundPlayer sound = new SoundPlayer(@"sounds\ui.wav");
            sound.Play();
            sound.Dispose();
            GC.SuppressFinalize(sound);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            onlyFiles = true;
            onlyFolders = true;
            info = "Tümü listeleniyor...";
            loadFolders();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            onlyFolders = true;
            onlyFiles = false;
            info = "Klasörler listeleniyor...";
            loadFolders();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            onlyFiles = true;
            onlyFolders = false;
            info = "Kök dizini listeleniyor..";
            loadFolders();
        }
        static long GetFileSize(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            return fileInfo.Length;
        }

        private void AllFolderAndDocsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < folderCardlist.Count; i++)
            {
                folderCardlist[i].Dispose();
                GC.SuppressFinalize(folderCardlist[i]);
            }
            for (int i = 0; i < fcardlist.Count; i++)
            {
                fcardlist[i].Dispose();
                GC.SuppressFinalize(fcardlist[i]);
            }
            for (int i = 0; i < subFolderlist.Count; i++)
            {
                subFolderlist[i].Dispose();
                GC.SuppressFinalize(subFolderlist[i]);
            }
        }
    }
}
