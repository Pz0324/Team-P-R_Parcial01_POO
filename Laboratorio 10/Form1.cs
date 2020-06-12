using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_10
{
    public partial class Form1 : Form
    {
        private UserControl current = null;

        public Form1()
        {
            InitializeComponent();
            current = bienvenido2;

        }

        private void agregarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new AgregarCuenta();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
        }

        private void verCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new VerCuentas();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
        }

        private void verCuentasYSusTotalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new VerCuentas_Total();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
        }

        private void verCuentasYTotalesSiIniciaConVocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new VerCuentasVocal();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Salir",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)

                Application.Exit();

        }


        private void bienvenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Bienvenido();
            tableLayoutPanel1.Controls.Add(current, 0, 0);
        }
    }
}