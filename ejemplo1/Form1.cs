using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("Verde");
            cboColorFavorito.Items.Add("Negro");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            //DateTime para poner una fecha
            DateTime fecha = dtpFechaNacimiento.Value;
            //operador ternario, es un IF en una sola linea
            //si el chetbot esta checked si es tru le pone el primero y si es false el segundo
            string chocolate = ckbChocolate.Checked == true ? "Le Gusta el chocolate" : "No le gusta el chocolate";
            string tipo;
            if (rbtMuggle.Checked)
                tipo = "Muggle";
            else if (rdtWizard.Checked)
                tipo = "Wizard";
            else
                tipo = "Squibs";

            string colorFavorito = cboColorFavorito.SelectedItem.ToString();
            string numeroFavorito = numNumeroFavorito.Value.ToString();

            string mensaje = chocolate + ", es " + tipo + ", su color es " + colorFavorito + ", su numero es: " + numeroFavorito;
            MessageBox.Show("Nombre: " + nombre + " Fecha: " + fecha + ", " + mensaje);
        }

       
    }
}
