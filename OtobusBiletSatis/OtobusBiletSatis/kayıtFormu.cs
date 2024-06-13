using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletSatis
{
    public partial class kayıtFormu : Form
    {
        public kayıtFormu()
        {
            InitializeComponent();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
