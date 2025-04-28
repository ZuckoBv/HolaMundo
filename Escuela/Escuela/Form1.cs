using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela
{
    public partial class frmMain : Form
    {
        frmAgregarPersona formAgregarPersona;
        public frmMain()
        {
            InitializeComponent();
            formAgregarPersona = new frmAgregarPersona(this);
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            formAgregarPersona.Show();
            this.Hide();
        }
    }
}
