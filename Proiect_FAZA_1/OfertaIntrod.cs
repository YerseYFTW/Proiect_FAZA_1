using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_FAZA_1
{
    public partial class OfertaIntrod : Form
    {
        private Form1 form1;
        public OfertaIntrod(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelIMBINS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveIMBINS_Click(object sender, EventArgs e)
        {
            form1.addOferta(tb1.Text,int.Parse(tb2.Text), int.Parse(tb3.Text));
            this.Close() ;
        }
    }
}
