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
    public partial class Imobil_Insert : Form
    {
        private Form1 form1;
        public Imobil_Insert(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Imobil_Insert_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveIMBINS_Click(object sender, EventArgs e)
        {
            form1.addImobil(tb1.Text, Convert.ToInt32(nud1.Value), tb2.Text, int.Parse(tb3.Text));
            this.Close();
        }

        private void btnCancelIMBINS_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
