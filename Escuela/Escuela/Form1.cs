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
        // Declara la lista y le asigna un espacio de memoria
        public List<Persona> listaPersona = new List<Persona>();
        public frmMain()
        {
            InitializeComponent();
            //declara el espacio de memoria que le llega para agregar persona
            formAgregarPersona = new frmAgregarPersona(this);
        }
        // Declara la funcion para refrescar el data grid
        public void refrescarDataGrid()
        {
            // Los primeros dos ifs son cortafuegos para que no haya inconvenientes en el código siguiente

            // Si la lista de personas no guarda nada sigue con la funcion
            if(listaPersona==null)
            {
                return;
            }
            // Si la lista de personas guarda valores menores a 0 sigue con el código
            if(listaPersona.Count <= 0)
            {
                return;
            }
            // Limpia si había algo previamente en el data grid view
            dgvPersona.Rows.Clear();
            // Recorre la lista de personas y le pasa por parametro los valores que requiere el dgv
            foreach(Persona p in listaPersona)
            {
                dgvPersona.Rows.Add(p.Nombre,p.Apellido,p.Dni);
            }
        }
        // Cuando se hace click en el boton agregar persona oculta el form frmMain y muestra el form agregar persona
        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            formAgregarPersona.Show();
            this.Hide();
        }
        // Cuando se activa el frmMain llama a la función refrescarDataGrid para mostrar los datos del agregar persona
        private void frmMain_Activated(object sender, EventArgs e)
        {
            refrescarDataGrid();
        }
    }
}
