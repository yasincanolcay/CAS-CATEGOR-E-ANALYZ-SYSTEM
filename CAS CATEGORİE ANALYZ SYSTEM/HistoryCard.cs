using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAS_CATEGORİE_ANALYZ_SYSTEM
{
    public partial class HistoryCard : Form
    {
        //----FORM BORDER RADIUS DESIGN---//
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int NLeftRect
          , int NRightRect, int NTopRect, int NBottomRect, int NWidthEllipse, int NHeightEllipse);

        public string name = "";
        public string path = "";
        public string process = "";
        public string date = "";
        public string extension = "";
        public int Id = 0;
        public TableLayoutPanel pageViewerPanel = new TableLayoutPanel();

        private string[] audioExts = {
            ".mp3",
            ".m4a",
            ".midi",
            ".wav",
            ".mid",
        };
        private string[] imageExts = { ".bmp", ".gif", ".ico", ".jpeg", ".svg", ".tif", ".tiff", ".ai" };
        private string[] unityextensions = { ".unity", ".prefab", ".asset", ".anim", ".controller", ".mat", ".meta", ".physicMaterial", ".physicMaterial2D", ".mixer", ".overrideController", ".playable", ".renderTexture", ".spriteAtlas" };

        public HistoryCard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void HistoryCard_Load(object sender, EventArgs e)
        {
            writeLabel();
        }
        private void writeLabel()
        {
            nameLbl.Text = name;
            pathLbl.Text = path;
            processLbl.Text = process;
            datetimeLbl.Text = date;
            if (extension == "folder")
            {
                folderOrFilePic.Image = Image.FromFile("icons/folder_30px.png");
            }
            else
            {
                if (extension == ".apk")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/apk_30px.png");
                }
                else if (audioExts.Contains(extension))
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/audio_file_30px.png");
                }
                else if (extension == ".wma")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/wma_30px.png");
                }
                else if (extension == ".css")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/css_filetype_30px.png");
                }
                else if (extension == ".dll")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/dll_30px.png");
                }
                else if (extension == ".exe")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/exe_30px.png");
                }
                else if (extension == ".html")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/html_filetype_30px.png");
                }
                else if (extension == ".java")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/java_file_30px.png");
                }
                else if (extension == ".jpg")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/jpg_30px.png");
                }
                else if (extension == ".json")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/json_30px.png");
                }
                else if (extension == ".mpg")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/mpg_30px.png");
                }
                else if (extension == ".pdf")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/pdf_30px.png");
                }
                else if (extension == ".png")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/png_30px.png");
                }
                else if (extension == ".ps")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/ps_30px.png");
                }
                else if (extension == ".rar")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/rar_30px.png");
                }
                else if (extension == ".txt")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/txt_30px.png");
                }
                else if (extension == ".docx" || extension == ".docm" || extension == ".doc")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/word_30px.png");
                }
                else if (extension == ".xls")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/xls_30px.png");
                }
                else if (extension == ".xml")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/xml_file_30px.png");
                }
                else if (extension == ".zip")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/zip_30px.png");
                }
                else if (imageExts.Contains(extension))
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/image_file_30px.png");
                }
                else if (unityextensions.Contains(extension))
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/unity_30px.png");
                }
                else if (extension == ".py" || extension == ".pyw")
                {
                    folderOrFilePic.Image = Image.FromFile("icons/filesicons/python_30px.png");
                }
            }
        }

        private void deletePicture_Click(object sender, EventArgs e)
        {
            OpacityEffectForm opacity = new OpacityEffectForm();
            opacity.Show();
            WarningMessageCard warning = new WarningMessageCard();
            warning.header = "Bu Öğe Kaldırılacak";
            warning.description = "Bu öğe geçmişten kaldırılacak, bu işlem geri alınamaz.";
            warning.mode = "database";
            warning.Id = Id;
            warning.opacity = opacity;
            warning.card = this;
            warning.ShowDialog();
        }

        private void goFolderPicture_Click(object sender, EventArgs e)
        {
            if(extension!= "Klasör CAS ile silindi." && extension != "Dosya CAS ile silindi.")
            {
                System.Diagnostics.Process.Start(path);
            }
        }
    }
}
