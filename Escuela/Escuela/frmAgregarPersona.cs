using System;
using System.Windows.Forms;

namespace Escuela
{
    public partial class frmAgregarPersona : Form
    {
        // Declara una variable con la clase del formulario padre main
        frmMain formularioPadre;
        // 
        public frmAgregarPersona(frmMain formPadre)
        {
            formularioPadre = formPadre;
            InitializeComponent();
        }
        // Declara el evento cuando se cambia el checked del rbtAlumno se ejecuta el código
        private void rbtAlumno_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica si el rbt de alumno esta seleccionado
            if (rbtAlumno.Checked == true)
            {
                //oculta el grp de profesor y muestra el de alumno
                grpProfesor.Visible = false;
                grpAlumno.Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        // Cuando se clickea el boton Volver oculta el formulario agregar persona y muestra el frmMain
        private void bntVolver_Click(object sender, EventArgs e)
        {
            formularioPadre.Show();
            this.Hide();
        }
        // Declara el evento cuando se cambia el checked del rbtProfesor se ejecuta el código
        private void rbtProfesor_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica si el rbt de profesor esta seleccionado
            if (rbtProfesor.Checked == true)
            {
                //oculta el grp de alumno y muestra el de profesor
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
        // Se declara el evento, cuando se clickea el boton de agregar persona se ejecuta el código
        private void button1_Click(object sender, EventArgs e)
        {
            // Declara la variable personaNueva con la clase de Persona
            Persona personaNueva;
            // Verifica si el rbtAlumno esta seleccionado
            if (rbtAlumno.Checked)
            {
                // Crea un espacio de memoria de clase Alumno en personaNueva y le pasa los valores ingresados en los txt
                personaNueva = new Alumno(int.Parse(txtGrupo.Text), txtCurso.Text, txtDivision.Text);
            }
            // Si el rbtAlumno no esta seleccionado, ejecuta el código
            else
            {
                // Crea la variable catProfesor con la clase Categoria
                Categoria catProfesor;
                // Segun la opción que este seleccionada en cmbCategoria guarda los valores declarados en Categoria
                switch (cmbCategoria.Text)
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
                // Crea un espacio de memoria en personaNueva con la clase hija Profesor y como parametros utiliza los txt
                personaNueva = new Profesor(txtMateria.Text, txtTitulo.Text, catProfesor);
            }
            // Guarda en los atributos de la clase padre Persona los valores de los txt
            personaNueva.Nombre = txtNombre.Text;
            personaNueva.Apellido = txtApellido.Text;
            personaNueva.Dni = int.Parse(txtDNI.Text);
            personaNueva.Email = txtEmail.Text;
            personaNueva.Domicilio = txtDomicilio.Text;
            personaNueva.FechaNacimiento = dtpFechaNac.Value;
            // Manda la variable personaNueva al formulario padre frmMain
            formularioPadre.listaPersona.Add(personaNueva);
            // Oculta el formulario agregar persona y muestra el formulario padre frmMain
            this.Hide();
            formularioPadre.Show();
        }
        // Utiliza el evento y cuando intenta cerrar el frmAgregarPersona ejecuta el código
        private void frmAgregarPersona_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cancela el cerrado del programa, oculta el form agregar persona y muestra el frmMain
            e.Cancel = true;
            this.Hide();
            formularioPadre.Show();
        }
    }
}
