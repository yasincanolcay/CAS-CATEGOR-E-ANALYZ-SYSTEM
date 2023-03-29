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
    public partial class ExtensionCard : Form
    {
        //----FORM BORDER RADIUS DESIGN---//
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int NLeftRect
          , int NRightRect, int NTopRect, int NBottomRect, int NWidthEllipse, int NHeightEllipse);

        public List<string> extensionForNumber = new List<string>();
        public string extName = "";
        int total = 0;
        public ExtensionCard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void ExtensionCard_Load(object sender, EventArgs e)
        {
            total = 0;
            foreach(var name in extensionForNumber)
            {
                if (name.Contains(extName))
                {
                    total++;
                }
            }
            extensionNumberLbl.Text = total.ToString() + " ADET";
            extensionNameLbl.Text = extName;
        }
    }
}
