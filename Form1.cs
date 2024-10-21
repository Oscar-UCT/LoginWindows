using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace LoginWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void ingresarBtn_Click(object sender, EventArgs e)
        {
            if (usuarioInput.Text == "admin" && contraseñaInput.Text == "pass")
            {
                FormularioAdministracion formularioAdministracion = new FormularioAdministracion();
                formularioAdministracion.Show();
                this.Hide();
                return;
            }

            if (DatsoIngresadosValidos() && CredencialesValidas())
            {
                estadoVerifiacionLabel.ForeColor = Color.DarkGreen;
                estadoVerifiacionLabel.Text = "Ingreso exitoso. Abriendo dashboard...";
                await Task.Delay(2000);

                PestañaDashboard dashboard = new PestañaDashboard(usuarioInput.Text);
                dashboard.Show();
                this.Hide();
            }
            else
            {
                estadoVerifiacionLabel.ForeColor = Color.DarkRed;
                estadoVerifiacionLabel.Text = "Credenciales inválidas. Inténtelo nuevamente";
                await Task.Delay(3000);
                estadoVerifiacionLabel.Text = "";
            }
        }

        bool DatsoIngresadosValidos()
        {
            if (usuarioInput.TextLength > 3 && contraseñaInput.TextLength > 3)
            {
                return true;
            }
            else { return false; }
        }

        bool CredencialesValidas()
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data source = usuariosdb.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = $"SELECT contraseña FROM Usuarios WHERE nombre = '{usuarioInput.Text}'";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.GetString(0) == contraseñaInput.Text) return true;
                    }
                }
            }
            return false;
        }

        private void registrarBtn_Click(object sender, EventArgs e)
        {
            FormularioRegistro formularioRegistro = new FormularioRegistro();
            formularioRegistro.Show();
            this.Hide();
        }
    }
}
