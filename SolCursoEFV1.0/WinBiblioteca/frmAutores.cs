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
    public partial class frmAutores : Form
    {
        Logica.Autor objLogicaAutor = new Logica.Autor();

        public frmAutores()
        {
            InitializeComponent();
            TraerAutores();
        }

        void TraerAutores()
        {
            dgvAutores.DataSource = objLogicaAutor.TraerTodos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvAutores.DataSource = objLogicaAutor.TraerTodos(txtFiltro.Text);
        }

        private void dgvAutores_DoubleClick(object sender, EventArgs e)
        {
            Modelo.Autor objAutor = new Modelo.Autor
            {
                ID = Convert.ToInt32(dgvAutores.CurrentRow.Cells["ID"].Value),
                Apellido = dgvAutores.CurrentRow.Cells["Apellido"].Value.ToString(),
                Nombre = dgvAutores.CurrentRow.Cells["Nombre"].Value.ToString()
            };

            frmAutor objForm = new frmAutor(objAutor);
            objForm.StartPosition = FormStartPosition.CenterScreen;
            objForm.ShowDialog();
        }



    private void btnActualizar_Click(object sender, EventArgs e)
        {
            TraerAutores();
        }
    }
}