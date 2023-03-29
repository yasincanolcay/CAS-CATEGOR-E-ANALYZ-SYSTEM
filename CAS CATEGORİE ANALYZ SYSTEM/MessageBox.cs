using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAS_CATEGORİE_ANALYZ_SYSTEM
{
    public partial class MessageBox : Form
    {
        public OpacityEffectForm opacity = new OpacityEffectForm();
        public MessageBox()
        {
            InitializeComponent();
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
    }
}
