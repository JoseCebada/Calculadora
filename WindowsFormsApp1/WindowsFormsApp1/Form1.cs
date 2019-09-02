using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Conversor : Form
    {
        int bandera = 0;
        public Conversor()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Conversor_Load(object sender, EventArgs e)
        {
            btnConvertir.Focus();
        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                double grados;
                //Si se escribio en centigrados
                if (bandera == 1)
                {
                    grados = Convert.ToDouble(txtC.Text) * 9 / 5.0 + 32.0;
                    //Mostramos el resultado
                    textBox2.Text = string.Format("{0:F2}", grados);
                }
                if (bandera == 2)
                {
                    grados = (Convert.ToDouble(textBox2.Text) - 32) * 5.0 / 9.0;
                    //Mostramos el resultado
                    txtC.Text = string.Format("{0:F2}", grados);
                }
            }
            catch(FormatException)
            {
                txtC.Text = "0.0";
                textBox2.Text = "32.00";
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtC_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            bandera = 1;
            if (e.KeyChar == 13)
            {
                BtnConvertir_Click(sender, e);
            }
        }

        private void TextBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            bandera = 2;
            if (e.KeyChar == 13)
            {
                BtnConvertir_Click(sender, e);
            }
        }
    }
}
