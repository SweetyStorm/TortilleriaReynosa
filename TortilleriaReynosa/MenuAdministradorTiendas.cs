using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TortilleriaReynosa
{
    public partial class MenuAdministradorTiendas : Form
    {
        public MenuAdministradorTiendas()
        {
            InitializeComponent();
        }

        private void btnTiendasCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTiendasNombre.Text) || string.IsNullOrEmpty(tbxTiendasTelefono.Text))
            {
                MessageBox.Show("Asegúrese que todos los campos estén llenos.");
            }
            else
            {
                string connStr = "server=127.0.0.1;user=root;database=tortilleria_reynosa;password=";
                string query = "INSERT INTO tiendas(id,nombre,telefono)VALUES('', '" + this.tbxTiendasNombre.Text + "', '" + this.tbxTiendasTelefono.Text + "')";
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Nueva tienda añadida exitosamente.");
                Actualizar();//Actualiza los datos de Tienda
                conn.Close();
            }

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
                string query = "UPDATE tiendas SET nombre='" + this.tbxTiendasNombre.Text + "',telefono='" + this.tbxTiendasTelefono.Text + "' WHERE id='"+ this.tbxTiendasId.Text + "'";
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

        private void btnTiendasRead_Click(object sender, EventArgs e)
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


        public void Borrar()
        {
            if (string.IsNullOrEmpty(tbxTiendasNombre.Text) || string.IsNullOrEmpty(tbxTiendasTelefono.Text) || string.IsNullOrEmpty(tbxTiendasId.Text))
            {
                MessageBox.Show("Asegúrese que todos los campos estén llenos.");
            }
            else
            {
                string connStr = "server=127.0.0.1;user=root;database=tortilleria_reynosa;password=";
                string query = "DELETE FROM tiendas WHERE id='" + this.tbxTiendasId.Text + "'";
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Los datos han sido eliminados exitosamente.");
                conn.Close();
            }
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

        private void btnTiendasDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTiendasNombre.Text) || string.IsNullOrEmpty(tbxTiendasTelefono.Text) || string.IsNullOrEmpty(tbxTiendasId.Text))
            {
                MessageBox.Show("Asegúrese que todos los campos estén llenos.");
            }
            else
            {
                string connStr = "server=127.0.0.1;user=root;database=tortilleria_reynosa;password=";
                string query = "DELETE FROM tiendas WHERE id='" + this.tbxTiendasId.Text + "'";
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                conn.Open();
                dr = cmd.ExecuteReader();
                MessageBox.Show("Los datos han sido eliminados exitosamente.");
                conn.Close();
            }

        }

        private void MenuAdministradorTiendas_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
