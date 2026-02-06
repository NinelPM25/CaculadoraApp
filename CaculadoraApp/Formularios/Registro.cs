using CaculadoraApp.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaculadoraApp.Formularios
{
    public partial class Registro : Form
    {
        List<Persona> Persona = new List<Persona>();
        public Registro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void butRegistrar_Click(object sender, EventArgs e)
        {
            Persona.Add(new Persona()
            {
                Nombre = textNombre.Text,
                Apellido = textApellido.Text,
                Fecha = dTFecha.Value
            });
            MessageBox.Show("Datos registrados", "Sistema");
        }

        private void tabRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabRegistro.SelectedIndex == 1)
            {
                dgvPersona.DataSource = null;
                dgvPersona.DataSource = Persona;
            }

        }
    }
}
