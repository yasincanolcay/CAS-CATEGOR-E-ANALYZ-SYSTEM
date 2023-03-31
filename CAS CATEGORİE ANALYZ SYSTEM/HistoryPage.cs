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
    public partial class HistoryPage : Form
    {

        SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + "'" + Application.StartupPath + "\\Database1.mdf'" + ";Integrated Security=True");
        List<HistoryCard> historyCardsList = new List<HistoryCard>();
        public HistoryPage()
        {
            InitializeComponent();
        }

        private void HistoryPage_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }
        
        private void LoadHistory()
        {
            for(int i = 0; i< historyCardsList.Count; i++)
            {
                historyCardsList[i].Dispose();
                GC.SuppressFinalize(historyCardsList[i]);
            }
            using (SqlCommand command = new SqlCommand("SELECT * From [Histories]", sqlConnection))
            {
                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    HistoryCard card = new HistoryCard();
                    card.Dock = DockStyle.Top;
                    card.TopLevel = false;
                    card.name = reader["ProcessName"].ToString();
                    card.path = reader["ProcessPath"].ToString();
                    card.process = reader["ProcessStatus"].ToString();
                    card.date = reader["ProcessTime"].ToString();
                    card.extension = reader["ProcessExtension"].ToString();
                    card.Id = Int32.Parse(reader["Id"].ToString());
                    card.pageViewerPanel = pageviewer;
                    pageviewer.Controls.Add(card);
                    card.Show();
                    historyCardsList.Add(card);
                }
                reader.Close();
                sqlConnection.Close();
            }
        }

        private void HistoryPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < historyCardsList.Count; i++)
            {
                historyCardsList[i].Dispose();
                GC.SuppressFinalize(historyCardsList[i]);
            }
            sqlConnection.Dispose();
        }
    }
}
