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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {   
            //le agrego un comentario al archivo
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            //esto es para que no se abra una ventana que ya esta abrierta
           
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    //si dentro de la coleccion en algunas de las vueltas encuentra un formulario que sea del mismo tipo que
                    //yo quiero abrir a continuacion, lo que va a ser es ir hasta el RETURN y lo demas no lo va a hacer
                    MessageBox.Show("Ya existe esta ventana abierta termine de trabajar alli..");
                    return;
                }
            }

            //con esto voy a otra ventana
            //creo la ventana
            Form1 ventana = new Form1();
            //le pido que a la ventana que se muestre

            ventana.MdiParent = this;
            //con este no me deja ir hasta que cierre la ventana
            ventana.Show();

            //Con esto puedo abrir muchas ventanas de la misma
            //ventana.Show();
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }
    }
}
