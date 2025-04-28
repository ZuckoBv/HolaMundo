using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Escuela
{
    public partial class frmAgregarPersona : Form
    {
        frmMain formularioPadre;

        public frmAgregarPersona(frmMain formPadre)
        {
            formularioPadre = formPadre;
            InitializeComponent();
        }

        private void rbtAlumno_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtAlumno.Checked == true)
            {
                grpProfesor.Visible = false;
                grpAlumno.Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntVolver_Click(object sender, EventArgs e)
        {
            formularioPadre.Show();
            this.Hide();
        }

        private void rbtProfesor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtProfesor.Checked == true)
            {
                grpProfesor.Visible = true;
                grpAlumno.Visible = false;
            }
        }

        private void rbtAlumno_Validated(object sender, EventArgs e)
        {

        }
        private void rbtProfesor_Validated(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona personaNueva;
            if(rbtAlumno.Checked)
            {
                personaNueva = new Alumno(int.Parse(txtGrupo.Text), txtCurso.Text, txtCurso.Text);
            }
            else
            {
                Categoria catProfesor;
                switch(cmbCategoria.Text)
                {
                    case "Titular":
                        catProfesor = Categoria.Titular;
                        break;
                    case "Suplente":
                        catProfesor = Categoria.Suplente;
                        break;
                    case "Provisional":
                        catProfesor = Categoria.Provisional;
                        break;
                    default:
                        catProfesor = Categoria.Titular;
                        break;

                }
                personaNueva = new Profesor(txtMateria.Text, txtTitulo.Text, catProfesor);
            }
        }
    }
}
