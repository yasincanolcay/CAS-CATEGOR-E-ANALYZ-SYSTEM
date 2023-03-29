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
    public partial class ExtensionsPage : Form
    {
        List<string> extensions = new List<string>();
        List<string> extensionForNumber = new List<string>();
        List<ExtensionCard> extensionsCardList = new List<ExtensionCard>();
        public ExtensionsPage()
        {
            InitializeComponent();
        }

        private void ExtensionsPage_Load(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(@"sounds\data.wav");
            sound.Play();
            sound.Dispose();
            GC.SuppressFinalize(sound);
            loadExtensions();
        }
 
        private void loadExtensions()
        {
            for (int i =0;i<extensionsCardList.Count;i++)
            {
                extensionsCardList[i].Dispose();
                GC.SuppressFinalize(extensionsCardList[i]);
            }
            flowLayoutPanel1.Controls.Clear();
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
                        string ext = Path.GetExtension(file);
                        extensionForNumber.Add(ext);
                        if (!extensions.Contains(ext))
                        {
                            extensions.Add(ext);
                        }
                    }

                    foreach(var exts in extensions)
                    {
                        ExtensionCard card = new ExtensionCard();
                        card.TopLevel = false;
                        card.extName = exts;
                        card.extensionForNumber = extensionForNumber;
                        flowLayoutPanel1.Controls.Add(card);
                        card.Show();
                        extensionsCardList.Add(card);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata: {ex.Message}");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
            SoundPlayer sound = new SoundPlayer(@"sounds\ui.wav");
            sound.Play();
            sound.Dispose();
            GC.SuppressFinalize(sound);
        }

        private void ExtensionsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < extensionsCardList.Count; i++)
            {
                extensionsCardList[i].Dispose();
                GC.SuppressFinalize(extensionsCardList[i]);
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            OpacityEffectForm opacity = new OpacityEffectForm();
            opacity.Show();
            MessageBox box = new MessageBox();
            box.opacity = opacity;
            box.ShowDialog();
        }
    }
}
