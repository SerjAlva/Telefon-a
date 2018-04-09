using System;
using System.Drawing;
using System.Windows.Forms;
using DatosTelefono;

namespace Telefonía
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvTelefonia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                //Hola hola hola 
                //hello xd
                TelefonoDatos telefonoDatos = new TelefonoDatos(txtTelefono.Text, txtLugar.Text);
                dgvTelefonia.Rows.Add(telefonoDatos.telefono, telefonoDatos.lugar);
            }
        }
    }
}
