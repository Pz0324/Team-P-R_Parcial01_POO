using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class LogIn : UserControl
    {
        public LogIn()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("")||textBox1.Text.Equals("USUARIO")||textBox2.Text.Equals("CONTRASEÑA"))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    var valido = ConnectionDB.ExecuteQuery(
                        $"SELECT * FROM USUARIO WHERE nombreUsuario ='{textBox1.Text}' AND contraseña ='{textBox2.Text}'");

                    if (valido.Rows.Count > 0)
                    {

                        if (valido.Rows[0][2].ToString() == "Admin")
                        {
                            new admin(valido.Rows[0][0].ToString(), valido.Rows[0][1].ToString()).Show();

                        }
                        else
                        {
                            new usuario(valido.Rows[0][0].ToString(), valido.Rows[0][1].ToString()).Show();
                        }
                        
                    }
                    
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ah ocurrido un error");
                }
                
            }

        }

     
    }
}