using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDatosPersonales
{
    public partial class Form1 : Form
    {
        string nombres, apellidos,genero,estadocivil;

       

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombres.Text) && string.IsNullOrEmpty(txtApellidos.Text)) {
                MessageBox.Show("Porfavor escribe tu nombre y tus apellidos");
            
            
            
            } 
            else { 
               nombres = txtNombres.Text;
                apellidos = txtApellidos.Text;
               

                if (rbnCasado.Checked == true) { estadocivil = "\nCasado"; }
                else { estadocivil = "\nSoltero"; }

                if (rbnMasculino.Checked==true) { genero = "\nMasculino"; } else { genero = "\nFemenino"; }

                lblRespuesta.Text = "\nNombre:" + nombres + "\nApellido:" + apellidos + "\nEstado civil:" + estadocivil + "\nGenero:" +genero;
            
            
            
            }
        }
    }
}
