using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginWindows
{
    public partial class FormularioAdministracion : Form
    {
        int idSeleccionada = 0;
        public FormularioAdministracion()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var connection = new SQLiteConnection("Data Source=usuariosdb.db"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Usuarios";

                // "adapter" lo extraí de chatgpt. no sabía que existía este tipo de clase!
                using (var adapter = new SQLiteDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection("Data Source=usuariosdb.db"))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "UPDATE Usuarios SET nombre = @nombre, contraseña = @contraseña, ciudad = @ciudad, telefono = @telefono WHERE id = @id";
                command.Parameters.AddWithValue("@nombre", usuarioInput.Text);
                command.Parameters.AddWithValue("@contraseña", contraseñaInput.Text);
                command.Parameters.AddWithValue("@ciudad", ciudadInput.Text);
                command.Parameters.AddWithValue("@telefono", telefonoInput.Text);
                command.Parameters.AddWithValue("@id", idSeleccionada);
                command.ExecuteNonQuery();

                command.CommandText = "SELECT * FROM Usuarios";
                using (var adapter = new SQLiteDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idSeleccionada = e.RowIndex + 1;

            using (SQLiteConnection baseDatos = new SQLiteConnection("Data source=usuariosdb.db"))
            {
                baseDatos.Open();

                var command = baseDatos.CreateCommand();
                command.CommandText = @"SELECT * FROM Usuarios WHERE id = @idIngreso";
                command.Parameters.AddWithValue("@idIngreso", idSeleccionada);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        usuarioInput.Text = reader.GetString(1);
                        contraseñaInput.Text = reader.GetString(2);
                        ciudadInput.Text = reader.GetString(3);
                        telefonoInput.Text = reader.GetString(4);
                    }
                }
            }
        }
    }
}
