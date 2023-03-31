using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAS_CATEGORİE_ANALYZ_SYSTEM
{
    public partial class filesCard : Form
    {


        public TableLayoutPanel viewerPanel = new TableLayoutPanel();
        public Panel viewPAnel = new Panel();
        public string fileName = "";
        public string filePath = "";
        public string fileExt = "";
        private string[] audioExts = {
            ".mp3",
            ".m4a",
            ".midi",
            ".wav",
            ".mid",
        };
        private string[] imageExts = { ".bmp", ".gif", ".ico", ".jpeg", ".svg", ".tif", ".tiff",".ai" };
        private string[] unityFileExts = { ".unity", ".prefab", ".asset", ".anim", ".controller", ".mat", ".meta", ".physicMaterial", ".physicMaterial2D", ".mixer", ".overrideController", ".playable", ".renderTexture", ".spriteAtlas" };

        public filesCard()
        {
            InitializeComponent();
        }

        private void filesCard_Load(object sender, EventArgs e)
        {
            writeLabel();
        }
        private void writeLabel()
        {
            fileNamelbl.Text = fileName;
            filePathlbl.Text = filePath+"\\"+fileName;
            if(fileExt == ".apk")
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/apk_30px.png");
            }
            else if(audioExts.Contains(fileExt))
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/audio_file_30px.png");
            }
            else if(fileExt == ".wma")
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/wma_30px.png");
            }
            else if (fileExt == ".css")
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/css_filetype_30px.png");
            }
            else if (fileExt == ".dll")
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/dll_30px.png");
            }
            else if (fileExt == ".exe")
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/exe_30px.png");
            }
            else if (fileExt == ".html")
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/html_filetype_30px.png");
            }
            else if(fileExt == ".java")
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/java_file_30px.png");
            }
            else if (fileExt == ".jpg")
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/jpg_30px.png");
            }
            else if(fileExt == ".json")
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/json_30px.png");
            }
            else if(fileExt == ".mpg")
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/mpg_30px.png");
            }
            else if(fileExt == ".pdf")
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/pdf_30px.png");
            }
            else if(fileExt == ".png")
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/png_30px.png");
            }
            else if(fileExt == ".ps")
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/ps_30px.png");
            }
            else if(fileExt == ".rar")
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/rar_30px.png");
            }
            else if(fileExt == ".txt")
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/txt_30px.png");
            }
            else if(fileExt == ".docx" || fileExt == ".docm" || fileExt == ".doc")
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/word_30px.png");
            }
            else if(fileExt == ".xls")          
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/xls_30px.png");
            }
            else if(fileExt == ".xml")
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/xml_file_30px.png");
            }                         
            else if(fileExt == ".zip")
            {                         
                fileIcon.Image = Image.FromFile("icons/filesicons/zip_30px.png");
            }
            else if (imageExts.Contains(fileExt))
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/image_file_30px.png");
            }
            else if (unityFileExts.Contains(fileExt))
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/unity_30px.png");
            }
            else if(fileExt == ".py" || fileExt == ".pyw")
            {
                fileIcon.Image = Image.FromFile("icons/filesicons/python_30px.png");
            }
        }

        private void listCardPAnel_MouseHover(object sender, EventArgs e)
        {
            listCardPAnel.BackColor = Color.FromArgb(0, 80, 120);
        }

        private void listCardPAnel_MouseLeave(object sender, EventArgs e)
        {
            listCardPAnel.BackColor = Color.FromArgb(30, 95, 130);
        }

        private void fileNamelbl_MouseHover(object sender, EventArgs e)
        {
            listCardPAnel.BackColor = Color.FromArgb(0, 80, 120);
        }

        private void fileNamelbl_MouseLeave(object sender, EventArgs e)
        {
            listCardPAnel.BackColor = Color.FromArgb(30, 95, 130);
        }

        private void filePathlbl_MouseHover(object sender, EventArgs e)
        {
            listCardPAnel.BackColor = Color.FromArgb(0, 80, 120);
        }

        private void filePathlbl_MouseLeave(object sender, EventArgs e)
        {
            listCardPAnel.BackColor = Color.FromArgb(30, 95, 130);
        }

        private void klasördeGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(filePath + "\\");
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + "'" + Application.StartupPath + "\\Database1.mdf'" + ";Integrated Security=True");

            string query = "INSERT INTO [Histories] (ProcessName,ProcessTime,ProcessPath,ProcessExtension,ProcessStatus) VALUES (@name,@time,@path,@extension,@status)";
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@name", fileName);
                command.Parameters.AddWithValue("@time", DateTime.Now);
                command.Parameters.AddWithValue("@path", filePath);
                command.Parameters.AddWithValue("@extension", fileExt);
                command.Parameters.AddWithValue("@status", "Dosya Klasörde Gösterildi.");
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        private void şimdiAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(filePath + "\\"+fileName);
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + "'" + Application.StartupPath + "\\Database1.mdf'" + ";Integrated Security=True");

            string query = "INSERT INTO [Histories] (ProcessName,ProcessTime,ProcessPath,ProcessExtension,ProcessStatus) VALUES (@name,@time,@path,@extension,@status)";
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@name", fileName);
                command.Parameters.AddWithValue("@time", DateTime.Now);
                command.Parameters.AddWithValue("@path", filePath);
                command.Parameters.AddWithValue("@extension", fileExt);
                command.Parameters.AddWithValue("@status", "Dosya CAS İle Açıldı.");
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpacityEffectForm opacity = new OpacityEffectForm();
            opacity.Show();
            WarningMessageCard warning = new WarningMessageCard();
            warning.header = "Bu Dosya silinecek";
            warning.description = "Bu dosya kalıcı olarak silinecek, bu işlem geri alınamaz.";
            warning.mode = "files";
            warning.opacity = opacity;
            warning.filecard = this;
            warning.folderPath = filePath + "\\" + fileName;
            warning.ShowDialog();
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + "'" + Application.StartupPath + "\\Database1.mdf'" + ";Integrated Security=True");
            string query = "INSERT INTO [Histories] (ProcessName,ProcessTime,ProcessPath,ProcessExtension,ProcessStatus) VALUES (@name,@time,@path,@extension,@status)";
            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@name", fileName);
                command.Parameters.AddWithValue("@time", DateTime.Now);
                command.Parameters.AddWithValue("@path", filePath);
                command.Parameters.AddWithValue("@extension", fileExt);
                command.Parameters.AddWithValue("@status", "Dosya CAS ile silindi.");
                sqlConnection.Open();
                command.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
