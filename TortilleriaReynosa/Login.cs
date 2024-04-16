using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;

namespace TortilleriaReynosa
{
    public partial class Login : Form
    {
        //Ventana redondeada
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );
        
        //Se declara un Point para manipular la posición de ventana
        public Point mouseLocation;

        //Conexion a SQL
        static MySqlConnection conn = null;

        public Login()
        {
            InitializeComponent();
            Connection();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            cbxLoginRol.SelectedIndex = 0;
        }

        static void Connection()
        {
            string connStr = "server=127.0.0.1;user=root;database=tortilleria_reynosa;password=";

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                MessageBox.Show("Conexión a la base de datos exitosa.");
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        void LoginValidation()
        {
            string Username = tbxLoginNombre.Text;
            string Password = tbxLoginClave.Text;
            string Role = cbxLoginRol.SelectedItem.ToString();

            try
            {
                conn.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM usuarios", conn);
                MySqlDataReader Reader = mySqlCommand.ExecuteReader();
                while (Reader.Read())
                {
                    if(Username == Reader.GetString("nombre") && Password == Reader.GetString("clave") && Role == Reader.GetString("rol"))
                    {
                        if (Role == "Administrador")
                        {
                            //MessageBox.Show("Administrador Autorizado.");
                            MenuAdministrador nextForm = new MenuAdministrador();
                            this.Hide();
                            nextForm.ShowDialog();
                            this.Close();
                        }
                        else if (Role == "Empleado")
                        {
                            //MessageBox.Show("Usuario Autorizado.");
                            MenuEmpleado nextForm = new MenuEmpleado();
                            this.Hide();
                            nextForm.ShowDialog();
                            this.Close();
                        }
                        conn.Close();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            MessageBox.Show("Credenciales no válidas.");
        }
 
        private void pnlBordeLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void pnlBordeLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void btnLoginCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoginMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tbxLoginNombre_Click(object sender, EventArgs e)
        {
            if (tbxLoginNombre.Text == "Nombre.")
            {
                tbxLoginNombre.Clear();
                tbxLoginNombre.ForeColor = Color.FromArgb(28, 28, 28);
            }
        }

        private void tbxLoginClave_Click(object sender, EventArgs e)
        {
            if (tbxLoginClave.Text == "Clave.")
            {
                tbxLoginClave.Clear();
                tbxLoginClave.ForeColor = Color.FromArgb(28, 28, 28);
            } 
        }

        private void btnLoginIngresar_Click(object sender, EventArgs e)
        {
            LoginValidation();
        }

        private void CbxLoginRol_Click(object sender, EventArgs e)
        {
            cbxLoginRol.ForeColor = Color.FromArgb(28, 28, 28);
        }
    }
}
