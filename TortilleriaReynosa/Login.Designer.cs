namespace TortilleriaReynosa
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLoginBarra = new System.Windows.Forms.Panel();
            this.btnLoginMinimizar = new System.Windows.Forms.Button();
            this.btnLoginCerrar = new System.Windows.Forms.Button();
            this.pnlLoginPanel = new System.Windows.Forms.Panel();
            this.cbxLoginRol = new System.Windows.Forms.ComboBox();
            this.btnLoginIngresar = new System.Windows.Forms.Button();
            this.tbxLoginClave = new System.Windows.Forms.TextBox();
            this.tbxLoginNombre = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pnlLoginBarra.SuspendLayout();
            this.pnlLoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLoginBarra
            // 
            this.pnlLoginBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(214)))), ((int)(((byte)(86)))));
            this.pnlLoginBarra.Controls.Add(this.btnLoginMinimizar);
            this.pnlLoginBarra.Controls.Add(this.btnLoginCerrar);
            this.pnlLoginBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoginBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginBarra.Name = "pnlLoginBarra";
            this.pnlLoginBarra.Size = new System.Drawing.Size(461, 30);
            this.pnlLoginBarra.TabIndex = 0;
            this.pnlLoginBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBordeLogin_MouseDown);
            this.pnlLoginBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBordeLogin_MouseMove);
            // 
            // btnLoginMinimizar
            // 
            this.btnLoginMinimizar.BackgroundImage = global::TortilleriaReynosa.Properties.Resources.minimizar;
            this.btnLoginMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoginMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLoginMinimizar.FlatAppearance.BorderSize = 0;
            this.btnLoginMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginMinimizar.Location = new System.Drawing.Point(401, 0);
            this.btnLoginMinimizar.Name = "btnLoginMinimizar";
            this.btnLoginMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnLoginMinimizar.TabIndex = 1;
            this.btnLoginMinimizar.UseVisualStyleBackColor = true;
            this.btnLoginMinimizar.Click += new System.EventHandler(this.btnLoginMinimizar_Click);
            // 
            // btnLoginCerrar
            // 
            this.btnLoginCerrar.BackgroundImage = global::TortilleriaReynosa.Properties.Resources.cerrar;
            this.btnLoginCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoginCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLoginCerrar.FlatAppearance.BorderSize = 0;
            this.btnLoginCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginCerrar.Location = new System.Drawing.Point(431, 0);
            this.btnLoginCerrar.Name = "btnLoginCerrar";
            this.btnLoginCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnLoginCerrar.TabIndex = 0;
            this.btnLoginCerrar.UseVisualStyleBackColor = true;
            this.btnLoginCerrar.Click += new System.EventHandler(this.btnLoginCerrar_Click);
            // 
            // pnlLoginPanel
            // 
            this.pnlLoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(214)))), ((int)(((byte)(86)))));
            this.pnlLoginPanel.Controls.Add(this.cbxLoginRol);
            this.pnlLoginPanel.Controls.Add(this.btnLoginIngresar);
            this.pnlLoginPanel.Controls.Add(this.tbxLoginClave);
            this.pnlLoginPanel.Controls.Add(this.tbxLoginNombre);
            this.pnlLoginPanel.Controls.Add(this.pictureBox2);
            this.pnlLoginPanel.Controls.Add(this.pictureBox1);
            this.pnlLoginPanel.Controls.Add(this.label1);
            this.pnlLoginPanel.Controls.Add(this.lblBienvenido);
            this.pnlLoginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginPanel.Location = new System.Drawing.Point(0, 30);
            this.pnlLoginPanel.Name = "pnlLoginPanel";
            this.pnlLoginPanel.Size = new System.Drawing.Size(461, 265);
            this.pnlLoginPanel.TabIndex = 1;
            // 
            // cbxLoginRol
            // 
            this.cbxLoginRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(69)))));
            this.cbxLoginRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoginRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxLoginRol.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoginRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(41)))));
            this.cbxLoginRol.FormattingEnabled = true;
            this.cbxLoginRol.Items.AddRange(new object[] {
            "-- Seleccione su rol. --",
            "Administrador",
            "Empleado"});
            this.cbxLoginRol.Location = new System.Drawing.Point(71, 149);
            this.cbxLoginRol.Name = "cbxLoginRol";
            this.cbxLoginRol.Size = new System.Drawing.Size(349, 26);
            this.cbxLoginRol.TabIndex = 9;
            this.cbxLoginRol.Click += new System.EventHandler(this.CbxLoginRol_Click);
            // 
            // btnLoginIngresar
            // 
            this.btnLoginIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLoginIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginIngresar.FlatAppearance.BorderSize = 0;
            this.btnLoginIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginIngresar.Font = new System.Drawing.Font("Roboto Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(214)))), ((int)(((byte)(86)))));
            this.btnLoginIngresar.Location = new System.Drawing.Point(142, 207);
            this.btnLoginIngresar.Name = "btnLoginIngresar";
            this.btnLoginIngresar.Size = new System.Drawing.Size(167, 46);
            this.btnLoginIngresar.TabIndex = 8;
            this.btnLoginIngresar.Text = "INGRESAR";
            this.btnLoginIngresar.UseVisualStyleBackColor = false;
            this.btnLoginIngresar.Click += new System.EventHandler(this.btnLoginIngresar_Click);
            // 
            // tbxLoginClave
            // 
            this.tbxLoginClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(69)))));
            this.tbxLoginClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxLoginClave.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLoginClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(41)))));
            this.tbxLoginClave.Location = new System.Drawing.Point(71, 114);
            this.tbxLoginClave.Multiline = true;
            this.tbxLoginClave.Name = "tbxLoginClave";
            this.tbxLoginClave.Size = new System.Drawing.Size(349, 20);
            this.tbxLoginClave.TabIndex = 7;
            this.tbxLoginClave.Text = "Clave.";
            this.tbxLoginClave.Click += new System.EventHandler(this.tbxLoginClave_Click);
            // 
            // tbxLoginNombre
            // 
            this.tbxLoginNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(202)))), ((int)(((byte)(69)))));
            this.tbxLoginNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxLoginNombre.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLoginNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(153)))), ((int)(((byte)(41)))));
            this.tbxLoginNombre.Location = new System.Drawing.Point(71, 77);
            this.tbxLoginNombre.Multiline = true;
            this.tbxLoginNombre.Name = "tbxLoginNombre";
            this.tbxLoginNombre.Size = new System.Drawing.Size(349, 20);
            this.tbxLoginNombre.TabIndex = 6;
            this.tbxLoginNombre.Text = "Nombre.";
            this.tbxLoginNombre.Click += new System.EventHandler(this.tbxLoginNombre_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::TortilleriaReynosa.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(40, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TortilleriaReynosa.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(40, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Por favor ingrese su nombre y clave.";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenido.Font = new System.Drawing.Font("Roboto", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblBienvenido.Location = new System.Drawing.Point(32, 6);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(233, 44);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "BIENVENIDO";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(461, 295);
            this.Controls.Add(this.pnlLoginPanel);
            this.Controls.Add(this.pnlLoginBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlLoginBarra.ResumeLayout(false);
            this.pnlLoginPanel.ResumeLayout(false);
            this.pnlLoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoginBarra;
        private System.Windows.Forms.Panel pnlLoginPanel;
        private System.Windows.Forms.Button btnLoginCerrar;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbxLoginNombre;
        private System.Windows.Forms.TextBox tbxLoginClave;
        private System.Windows.Forms.Button btnLoginMinimizar;
        private System.Windows.Forms.Button btnLoginIngresar;
        private System.Windows.Forms.ComboBox cbxLoginRol;
    }
}

