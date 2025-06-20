using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piedra_papel_o_tijera
{
    public partial class frmPPT : Form
    {
        int contarPuntos = 0, contarPuntosPC = 0;
        string jugador = "", computadora = "";

        public frmPPT()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            string[] seleccion = { "Piedra","Papel","Tijera"};
            Random random = new Random();
            if (rbnPapel.Checked == true)
            {

                jugador = "Papel";


            }
            else if (rbnPiedra.Checked == true)
            { jugador = "Piedra"; }
            else if (rbnTijeras.Checked == true)
            {


                jugador = "Tijera";

            }
            else {

                MessageBox.Show("Selecciona una opcion disponible");
            
            
            }
            computadora = seleccion[random.Next(0,3)];

            if (computadora == "Piedra")
            {

                rbnPiedraM.Checked = true;

            }
            else if (computadora == "Papel")
            {

                rbnPapelM.Checked = true;

            }
            else { rbnTijerasM.Checked = true;  }

            //Comparando los resultados
            if (computadora == jugador)

            {
                lblResultado.ForeColor = Color.White;
                lblResultado.BackColor = Color.YellowGreen;
                lblResultado.Text = "Empate";


            }


            else if ((jugador == "Piedra" && computadora == "Tijera") || (jugador == "Papel" && computadora == "Piedra") || (jugador == "Tijera" && computadora == "Papel"))

            {

                lblResultado.BackColor = Color.DarkGoldenrod;
                lblResultado.ForeColor = Color.AliceBlue;
                lblResultado.Text = "Ganaste :3";
                contarPuntos++;
                txtScore.Text = contarPuntos.ToString();
            }
            else 
            {

                lblResultado.BackColor = Color.DarkRed;
                lblResultado.ForeColor = Color.Wheat;
                lblResultado.Text = "Perdiste malo  :3";
                contarPuntosPC++;
                txtScoreM.Text = contarPuntosPC.ToString();

             



            }
            if (contarPuntos == 3) { MessageBox.Show("Felicidades ganaste!! :D"); } else if (contarPuntosPC==3) { MessageBox.Show("La computadora gano D:"); Close() ; }











        }
    }
}
