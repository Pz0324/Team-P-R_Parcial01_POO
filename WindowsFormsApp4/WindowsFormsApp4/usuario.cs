using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class usuario : Form
    {
        public usuario(string idusuario,string usuario)
        {
            InitializeComponent();
            int id = Int32.Parse(idusuario);
            label2.Text = "bienvenido " + usuario;
        }
        //y aca
    }
}