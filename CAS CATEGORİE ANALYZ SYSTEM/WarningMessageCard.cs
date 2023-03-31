using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAS_CATEGORİE_ANALYZ_SYSTEM
{
    public partial class WarningMessageCard : Form
    {
        public string header = "";
        public string description = "";
        public int Id = 0;
        public string mode = "";
        public string folderPath = "";
        public OpacityEffectForm opacity = new OpacityEffectForm();
        public HistoryCard card = new HistoryCard();
        public folderCard foldercard = new folderCard();
        public filesCard filecard = new filesCard();
        public subfoldersCard subFoldersCard = new subfoldersCard();
        public WarningMessageCard()
        {
            InitializeComponent();
        }

        private void WarningMessageCard_Load(object sender, EventArgs e)
        {
            headerLbl.Text = header;
            descriptionLbl.Text = description;
            if (mode != "database")
            {
                yesBtn.Text = "Tamam";
            }
        }

        private void processDataBase()
        {
            string query = "delete " + "Histories" + " where Id='" + Id + "'";
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + "'" + Application.StartupPath + "\\Database1.mdf'" + ";Integrated Security=True");
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            card.Dispose();
            GC.SuppressFinalize(card);
            foldercard.Dispose();
            subFoldersCard.Dispose();
            GC.SuppressFinalize(foldercard);
            GC.SuppressFinalize(subFoldersCard);
            closeButton.PerformClick();
        }
        private void Process()
        {
            if (mode == "folder")
            {
                if (Directory.Exists(folderPath))
                {
                    Directory.Delete(folderPath, true);
                    Console.WriteLine("Klasör ve içeriği silindi.");
                    foldercard.Dispose();
                    subFoldersCard.Dispose();
                    GC.SuppressFinalize(foldercard);
                    GC.SuppressFinalize(subFoldersCard);
                    closeButton.PerformClick();
                }
                else
                {
                    closeButton.PerformClick();
                }
            }
            else if(mode == "files")
            {
                if (File.Exists(folderPath))
                {
                    File.Delete(folderPath);
                    Console.WriteLine("Dosya silindi.");
                    filecard.Dispose();
                    GC.SuppressFinalize(filecard);
                    foldercard.Dispose();
                    subFoldersCard.Dispose();
                    GC.SuppressFinalize(foldercard);
                    GC.SuppressFinalize(subFoldersCard);
                    closeButton.PerformClick();
                }
                else
                {
                    closeButton.PerformClick();
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            opacity.Dispose();
            GC.SuppressFinalize(opacity);
            opacity.Close();
            this.Dispose();
            GC.SuppressFinalize(this);
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            opacity.Dispose();
            GC.SuppressFinalize(opacity);
            opacity.Close();
            this.Dispose();
            GC.SuppressFinalize(this);
            this.Close();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            if (mode == "database")
            {
                processDataBase();
            }
            else
            {
                Process();
            }
        }
    }
}
