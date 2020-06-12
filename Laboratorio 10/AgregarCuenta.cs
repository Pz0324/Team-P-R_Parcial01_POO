using System;
using System.Windows.Forms;

namespace Laboratorio_10
{
    public partial class AgregarCuenta : UserControl
    {
        public AgregarCuenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(" ") || textBox2.Text.Equals(" "))
            {
                MessageBox.Show("No se pueden dejar espacios vacios ");
            }
            else
            {
                try
                {
                    string nombre = textBox1.Text;
                    double sueldo = Convert.ToDouble(textBox2.Text);
                    
                    CuentaBancaria.CuentasBancarias1.Add(new CuentaBancaria(nombre, sueldo));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocuurido un error");

                }
            }
        }
    }
}