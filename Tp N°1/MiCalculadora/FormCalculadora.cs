using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        

        public FormCalculadora()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
          
        }

        void Limpiar()
        {
            this.txbPriOperando.Text = "";
            this.txbSegOperando.Text = "";
            this.cmbSigno.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double aux = 0;
            if (double.TryParse(txbPriOperando.Text, out aux) && double.TryParse(txbSegOperando.Text, out aux) && (aux != 0 || cmbSigno.Text != "/"))
            {
                Entidades.Numero operador1 = new Entidades.Numero(txbPriOperando.Text);
                Entidades.Numero operador2 = new Entidades.Numero(txbSegOperando.Text);
                lblResultado.Text = Entidades.Calculadora.Operar(operador1, operador2, cmbSigno.Text).ToString();

            }
            else
            {

                MessageBox.Show("No se puede operar");
                Limpiar();
            }
        }

        private void cmbSigno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            Entidades.Numero resultado = new Entidades.Numero();

            lblResultado.Text = resultado.DecimalBinario(lblResultado.Text).ToString();

        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            Entidades.Numero resultado = new Entidades.Numero();
            
            if (lblResultado.Text == "" || lblResultado.Text == "error")
            {
                lblResultado.Text = "error";
            }else
            {
                lblResultado.Text = resultado.BinarioDecimal(lblResultado.Text).ToString();
            }
        }

        private void btnBin_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
