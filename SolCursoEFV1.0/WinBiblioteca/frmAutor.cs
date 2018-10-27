using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBiblioteca
{
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }

        public frmAutor(Modelo.Autor pAutor)
        {
            InitializeComponent();

            lblAutorID.Text = pAutor.ID.ToString();
            txtApellido.Text = pAutor.Apellido;
            txtNombre.Text = pAutor.Nombre;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Logica.Autor objLogicaAutor = new Logica.Autor();

            Modelo.Autor pAutor = new Modelo.Autor
            {

                ID = Convert.ToInt32(lblAutorID.Text),
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text
            };
            

            objLogicaAutor.Modificar(pAutor);

            MessageBox.Show("Autor Modificado");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
