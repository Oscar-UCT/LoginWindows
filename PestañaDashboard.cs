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
    public partial class PestañaDashboard : Form
    {
        string usuarioIngresado;
        public PestañaDashboard(string usuarioIngresado)
        {
            InitializeComponent();
            this.usuarioIngresado = usuarioIngresado;
            usuarioDashboard.Text = usuarioIngresado;
            ProcesoMain();
        }

        void ProcesoMain()
        {
            using (SQLiteConnection baseDatos = new SQLiteConnection("Data source=usuariosdb.db"))
            {
                baseDatos.Open();

                var command = baseDatos.CreateCommand();
                command.CommandText = $"SELECT * FROM Usuarios WHERE nombre = '{usuarioIngresado}'";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usuarioDashboard.Text = reader.GetString(1);
                        direccionUsuarioLabel.Text = reader.GetString(3);
                        telefonoUsuarioLabel.Text = reader.GetString(4);
                    }
                }
            }
        }
    }
}
