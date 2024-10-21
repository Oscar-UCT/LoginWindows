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

                using (var adapter = new SQLiteDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable; // Set the DataSource of DataGridView
                }
            }
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
