using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LoginWindows
{
    public partial class FormularioRegistro : Form
    {
        public FormularioRegistro()
        {
            InitializeComponent();
        }

        private async void ingresarBtn_Click(object sender, EventArgs e)
        {
            if (DatosValidos())
            {
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection("Data source = usuariosdb.db"))
                    {
                        connection.Open();
                        var command = connection.CreateCommand();
                        command.CommandText = $"INSERT INTO Usuarios (nombre, contraseña, ciudad, telefono) VALUES ('{usuarioInput.Text}', '{contraseñaInput.Text}', '{ciudadInput.Text}', '{telefonoInput.Text}');";

                        command.ExecuteNonQuery();
                    }
                }
                catch { MessageBox.Show("No se pudo guardar en la base de datos."); }

                estadoRegistroLabel.Text = "Registro exitoso. Volviendo a pestaña de login...";
                await Task.Delay(1000);
                Form1 loginFormulario = new Form1();
                loginFormulario.Show();
                this.Hide();
            }
        }

        bool DatosValidos()
        {
            if (usuarioInput.TextLength > 3 &&
                contraseñaInput.TextLength > 3 &&
                ciudadInput.TextLength > 3 &&
                telefonoInput.TextLength > 3
                ) return true;
            else return false;
        }
    }
}
