using RegistroPatronRespositorio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroPatronRespositorio.UI.Registros
{
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var guardar = new Usuarios();

            guardar.Nombre = nombreTextBox.Text;
            guardar.Clave = claveTextBox.Text;

            if (guardar != null)
            {
                BLL.RegistrosBLL.Guardar(guardar);
                MessageBox.Show("Correcto");
            }
        }
    }
}
