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
    public partial class MenuAdministrador : Form
    {
        private Form VentanaActiva;
        public MenuAdministrador(string UsuarioNombre)
        {
            InitializeComponent();
            lblAdminNombre.Text = UsuarioNombre;
        }

        private void btnAdminInventario_Click(object sender, EventArgs e)
        {
            if (VentanaActiva != null)
            {
                VentanaActiva.Dispose();
            }
            MenuAdministradorInventario menu = new MenuAdministradorInventario();
            VentanaActiva = menu;
            menu.FormBorderStyle = FormBorderStyle.None;
            menu.TopLevel = false;
            menu.Visible = true;
            pnlAdminContenido.Controls.Add(menu);
            menu.WindowState = FormWindowState.Maximized;
        }

        private void btnAdminCerrar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea cerrar la aplicación?", "Confirmación de salida", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btnAdminMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnAdminSucursal_Click(object sender, EventArgs e)
        {
            if (VentanaActiva != null)
            {
                VentanaActiva.Dispose();
            }
            MenuAdministradorSucursal menu = new MenuAdministradorSucursal();
            VentanaActiva = menu;
            menu.FormBorderStyle = FormBorderStyle.None;
            menu.TopLevel = false;
            menu.Visible = true;
            pnlAdminContenido.Controls.Add(menu);
            menu.WindowState = FormWindowState.Maximized;
        }

        private void btnAdminMateriaPrima_Click(object sender, EventArgs e)
        {
            if (VentanaActiva != null)
            {
                VentanaActiva.Dispose();
            }
            MenuAdministradorMateriaPrima menu = new MenuAdministradorMateriaPrima();
            VentanaActiva = menu;
            menu.FormBorderStyle = FormBorderStyle.None;
            menu.TopLevel = false;
            menu.Visible = true;
            pnlAdminContenido.Controls.Add(menu);
            menu.WindowState = FormWindowState.Maximized;
        }

        private void btnAdminProducto_Click(object sender, EventArgs e)
        {
            if (VentanaActiva != null)
            {
                VentanaActiva.Dispose();
            }
            MenuAdministradorProducto menu = new MenuAdministradorProducto();
            VentanaActiva = menu;
            menu.FormBorderStyle = FormBorderStyle.None;
            menu.TopLevel = false;
            menu.Visible = true;
            pnlAdminContenido.Controls.Add(menu);
            menu.WindowState = FormWindowState.Maximized;
        }

        private void btnAdminProovedores_Click(object sender, EventArgs e)
        {
            if (VentanaActiva != null)
            {
                VentanaActiva.Dispose();
            }
            MenuAdministradorProovedores menu = new MenuAdministradorProovedores();
            VentanaActiva = menu;
            menu.FormBorderStyle = FormBorderStyle.None;
            menu.TopLevel = false;
            menu.Visible = true;
            pnlAdminContenido.Controls.Add(menu);
            menu.WindowState = FormWindowState.Maximized;
        }

       

        private void btnAdminTiendas_Click(object sender, EventArgs e)
        {
            PnlTiendaCRUD.Visible = true;

          /*  if (VentanaActiva != null)
            {
                VentanaActiva.Dispose();
            }



            MenuAdministradorTiendas menu = new MenuAdministradorTiendas();
            VentanaActiva = menu;
            menu.FormBorderStyle = FormBorderStyle.None;
            menu.TopLevel = false;
            menu.Visible = true;
            pnlAdminContenido.Controls.Add(menu);
            menu.WindowState = FormWindowState.Maximized;*/
        }

        private void btnSurtido_Click(object sender, EventArgs e)
        {
            if (VentanaActiva != null)
            {
                VentanaActiva.Dispose();
            }
            MenuAdministradorSurtido menu = new MenuAdministradorSurtido();
            VentanaActiva = menu;
            menu.FormBorderStyle = FormBorderStyle.None;
            menu.TopLevel = false;
            menu.Visible = true;
            pnlAdminContenido.Controls.Add(menu);
            menu.WindowState = FormWindowState.Maximized;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (VentanaActiva != null)
            {
                VentanaActiva.Dispose();
            }
            MenuAdministradorUsuarios menu = new MenuAdministradorUsuarios();
            VentanaActiva = menu;
            menu.FormBorderStyle = FormBorderStyle.None;
            menu.TopLevel = false;
            menu.Visible = true;
            pnlAdminContenido.Controls.Add(menu);
            menu.WindowState = FormWindowState.Maximized;
        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Está seguro que desea cerrar su sesión?", "Confirmación de cierre de sesión", MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                Login CierreSesion = new Login();
                this.Hide();
                CierreSesion.ShowDialog();
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void flpAdminMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnTiendaAñadir_Click(object sender, EventArgs e)
        {
            if (VentanaActiva != null)
            {
                VentanaActiva.Dispose();
            }



            MenuAdministradorTiendas menu = new MenuAdministradorTiendas();
            VentanaActiva = menu;
            menu.FormBorderStyle = FormBorderStyle.None;
            menu.TopLevel = false;
            menu.Visible = true;
            pnlAdminContenido.Controls.Add(menu);
            menu.WindowState = FormWindowState.Maximized;
            
        }

        private void BtnElminarTienda_Click(object sender, EventArgs e)
        {
            if(VentanaActiva != null)
            {
                VentanaActiva.Dispose();
            }



            VentanaEliminarTienda menu = new VentanaEliminarTienda();
            VentanaActiva = menu;
            menu.FormBorderStyle = FormBorderStyle.None;
            menu.TopLevel = false;
            menu.Visible = true;
            pnlAdminContenido.Controls.Add(menu);
            menu.WindowState = FormWindowState.Maximized;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if(VentanaActiva != null)
            {
                VentanaActiva.Dispose();
            }



            ModificarDatosTienda menu = new ModificarDatosTienda();
            VentanaActiva = menu;
            menu.FormBorderStyle = FormBorderStyle.None;
            menu.TopLevel = false;
            menu.Visible = true;
            pnlAdminContenido.Controls.Add(menu);
            menu.WindowState = FormWindowState.Maximized;
        }
    }
}
