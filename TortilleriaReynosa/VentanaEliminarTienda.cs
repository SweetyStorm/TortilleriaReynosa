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
    public partial class VentanaEliminarTienda : Form
    {
        public VentanaEliminarTienda()
        {
            InitializeComponent();
        }



        private void btnTiendasDelete_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(tbxTiendasId.Text))
            {
                MessageBox.Show("Por favor, introduzca un ID para eliminar.");
            }
            else
            {
                string connStr = "server=127.0.0.1;user=root;database=tortilleria_reynosa;password=";
                string query = "DELETE FROM tiendas WHERE id=@Id"; // Usamos parámetros para prevenir inyección SQL
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Usamos parámetros para evitar la inyección de SQL y asegurar una consulta segura
                cmd.Parameters.AddWithValue("@Id", tbxTiendasId.Text);
                
                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery(); // Ejecuta la consulta DELETE y devuelve el número de filas afectadas

                    if (rowsAffected > 0)
                    {
                        Actualizar();
                        MessageBox.Show("La tienda ha sido eliminada exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ninguna tienda con el ID proporcionado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la tienda: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

        }

        private void VentanaEliminarTienda_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
        //Actualiza datos de Tienda
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

    }
}
