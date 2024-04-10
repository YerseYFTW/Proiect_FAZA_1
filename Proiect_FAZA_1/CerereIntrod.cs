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
    public partial class CerereIntrod : Form
    {
        Form1 form1 = new Form1();
        public CerereIntrod(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnCancelIMBINS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveIMBINS_Click(object sender, EventArgs e)
        {
            form1.addCerere(tb1.Text, tb2.Text, tb3.Text);
            this.Close();
        }
    }
}
