using System.Diagnostics.Eventing.Reader;

namespace Descuentos
{
    public partial class frmDescuentos : Form
    {
        double descuento;
        public frmDescuentos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado, precio;
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Por Favor no dejes campos vacios");


            }
            else
            {
                precio = double.Parse(txtPrecio.Text);
                //el radio button tiene el evento checked
                //que me sirve para saber que radiobtn seleccione


                if (rbn5Descuento.Checked == true)
                {
                    descuento = 0.05 * precio;
                    resultado = precio - descuento;
                    txtTotal.Text = resultado.ToString("N2");


                }
                else if (rbn10Descuento.Checked == true)
                {

                    descuento = 0.10 * precio;
                    resultado = precio - descuento;
                    txtTotal.Text = resultado.ToString("N2");




                }

                else if (rbn20Descuento.Checked == true)
                {

                    descuento = 0.20 * precio;
                    resultado = precio - descuento;
                    txtTotal.Text = resultado.ToString("N2");




                }

                else
                {
                    lblError.ForeColor = Color.Yellow;
                    lblError.BackColor = Color.White;
                    lblError.Text = "No se aplico ningun descuento";
                    txtTotal.Text = precio.ToString("N2");
                }







            }



















        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtPrecio.Clear();
            txtTotal.Clear();
        }
    }
}
