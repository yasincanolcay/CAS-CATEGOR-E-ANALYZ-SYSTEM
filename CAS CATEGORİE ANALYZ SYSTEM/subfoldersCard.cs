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

namespace CAS_CATEGORİE_ANALYZ_SYSTEM
{
    public partial class subfoldersCard : Form
    {
        public List<folderCard> folderCardList = new List<folderCard>();
        public List<filesCard> filesCardList = new List<filesCard>();
        public List<subfoldersCard> subFolderCardList = new List<subfoldersCard>();
        public bool onlyFolders = true;
        public bool onlyFiles = true;
        public string folderName = "";
        public string folderDisk = "";
        public TableLayoutPanel viewerPanel = new TableLayoutPanel();
        public Panel viewPAnel = new Panel();
        public subfoldersCard()
        {
            InitializeComponent();
        }

        private void subfoldersCard_Load(object sender, EventArgs e)
        {
            writeLabel();
        }
        private void writeLabel()
        {
            folderNamelbl.Text = folderName;
            folderDisklbl.Text = folderDisk+"\\"+folderName;
        }

        private void klasördeGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(folderDisk+"\\"+folderName);
        }

        private void şimdiAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moreMenu2.Dispose();
            folderIcon.Dispose();
            folderNamelbl.Dispose();
            folderDisklbl.Dispose();
            pictureBox1.Dispose();
            panel1.Dispose();
            panel2.Dispose();
            panel3.Dispose();
            openFolderNow();
            this.Dispose();
            GC.SuppressFinalize(this);
        }
        private void openFolderNow()
        {
            for (int i = 0; i < folderCardList.Count; i++)
            {
                folderCardList[i].Dispose();
                GC.SuppressFinalize(folderCardList[i]);
            }
            for (int i = 0; i < filesCardList.Count; i++)
            {
                filesCardList[i].Dispose();
                GC.SuppressFinalize(filesCardList[i]);
            }
            for (int i = 0; i < subFolderCardList.Count; i++)
            {
                subFolderCardList[i].Dispose();
                GC.SuppressFinalize(subFolderCardList[i]);
            }
            viewerPanel.Controls.Clear();
            string[] directories = Directory.GetDirectories(folderDisk + "\\" + folderName + "\\", "*", SearchOption.TopDirectoryOnly);
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

                    folderCard card = new folderCard(); //görüntülenecek form kartını oluştur
                    card.Dock = DockStyle.Top;
                    card.TopLevel = false;
                    card.viewPAnel = viewPAnel;
                    card.folderName = folderName;
                    card.folderDisk = folderPath;
                    card.viewerPanel = viewerPanel;
                    folderCardList.Add(card);
                    card.folderCardList = folderCardList;
                    card.filesCardList = filesCardList;
                    card.subFolderCardList = subFolderCardList;
                    viewerPanel.Controls.Add(card);//panele ekle
                    card.Show();//göster

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
                                fCard.viewPAnel = viewPAnel;
                                fCard.viewerPanel = viewerPanel;
                                viewerPanel.Controls.Add(fCard);
                                fCard.Show();
                                filesCardList.Add(fCard);
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
                            card2.viewPAnel = viewPAnel;
                            card2.viewerPanel = viewerPanel;
                            card2.folderName = subdirectoryName;
                            card2.folderDisk = subdirectoryPath;
                            card2.onlyFolders = onlyFolders;
                            card2.onlyFiles = onlyFiles;
                            card2.folderCardList = folderCardList;
                            card2.filesCardList = filesCardList;
                            card2.subFolderCardList = subFolderCardList;
                            subFolderCardList.Add(card2);
                            viewerPanel.Controls.Add(card2);//panele ekle
                            card2.Show();//göster

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
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            if (directories == null || directories.Length == 0&&onlyFiles)
            {
                //alt dizindeki dosyalarıda al
                string[] files = Directory.GetFiles(folderDisk + "\\" + folderName, "*", SearchOption.TopDirectoryOnly);
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
                        fCard.viewPAnel = viewPAnel;
                        fCard.viewerPanel = viewerPanel;
                        viewerPanel.Controls.Add(fCard);
                        fCard.Show();
                        filesCardList.Add(fCard);
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
    }
}
