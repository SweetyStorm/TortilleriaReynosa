using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TortilleriaReynosa
{
    public partial class ModificarDatosTienda : Form
    {
        public ModificarDatosTienda()
        {
            InitializeComponent();
        }

        private void dgvTiendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si el clic ocurrió en una celda que no es el encabezado
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtiene el valor de la celda de la columna del ID
                object idValue = dgvTiendas.Rows[e.RowIndex].Cells[0].Value;

                // Verifica si el valor no es nulo
                if (idValue != null)
                {
                    // Asigna el valor al TextBox tbxTiendasId
                    tbxTiendasId.Text = idValue.ToString();
                }
            }
        }

        private void ModificarDatosTienda_Load(object sender, EventArgs e)
        {
            
                string connStr = "server=127.0.0.1;user=root;database=tortilleria_reynosa;password=";
                string query = "SELECT * FROM tiendas";
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTiendas.DataSource = dt;
            
        }
        public void Actualizar()
        {
            string connStr = "server=127.0.0.1;user=root;database=tortilleria_reynosa;password=";
            string query = "SELECT * FROM tiendas";
            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTiendas.DataSource = dt;
        }
        private void btnTiendasUpdate_Click(object sender, EventArgs e)
        {




            if (string.IsNullOrEmpty(tbxTiendasNombre.Text) || string.IsNullOrEmpty(tbxTiendasTelefono.Text) || string.IsNullOrEmpty(tbxTiendasId.Text))
            {
                MessageBox.Show("Asegúrese que todos los campos estén llenos.");
            }
            else
            {
                string connStr = "server=127.0.0.1;user=root;database=tortilleria_reynosa;password=";
                string query = "UPDATE tiendas SET nombre='" + this.tbxTiendasNombre.Text + "',telefono='" + this.tbxTiendasTelefono.Text + "' WHERE id='" + this.tbxTiendasId.Text + "'";
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Los datos han sido actualizados exitosamente.");
                Actualizar();
                conn.Close();
            }
        }
    }
}
