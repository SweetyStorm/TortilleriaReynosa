namespace TortilleriaReynosa
{
    partial class MenuAdministradorTiendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTiendasNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTiendasTelefono = new System.Windows.Forms.TextBox();
            this.dgvTiendas = new System.Windows.Forms.DataGridView();
            this.btnTiendasCreate = new System.Windows.Forms.Button();
            this.btnTiendasUpdate = new System.Windows.Forms.Button();
            this.btnTiendasDelete = new System.Windows.Forms.Button();
            this.btnTiendasRead = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.tbxTiendasId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIENDAS";
            // 
            // tbxTiendasNombre
            // 
            this.tbxTiendasNombre.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTiendasNombre.Location = new System.Drawing.Point(24, 150);
            this.tbxTiendasNombre.Name = "tbxTiendasNombre";
            this.tbxTiendasNombre.Size = new System.Drawing.Size(221, 27);
            this.tbxTiendasNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teléfono";
            // 
            // tbxTiendasTelefono
            // 
            this.tbxTiendasTelefono.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTiendasTelefono.Location = new System.Drawing.Point(24, 207);
            this.tbxTiendasTelefono.Name = "tbxTiendasTelefono";
            this.tbxTiendasTelefono.Size = new System.Drawing.Size(221, 27);
            this.tbxTiendasTelefono.TabIndex = 3;
            // 
            // dgvTiendas
            // 
            this.dgvTiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiendas.Location = new System.Drawing.Point(292, 74);
            this.dgvTiendas.Name = "dgvTiendas";
            this.dgvTiendas.ReadOnly = true;
            this.dgvTiendas.Size = new System.Drawing.Size(482, 314);
            this.dgvTiendas.TabIndex = 5;
            // 
            // btnTiendasCreate
            // 
            this.btnTiendasCreate.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiendasCreate.Location = new System.Drawing.Point(32, 274);
            this.btnTiendasCreate.Name = "btnTiendasCreate";
            this.btnTiendasCreate.Size = new System.Drawing.Size(94, 47);
            this.btnTiendasCreate.TabIndex = 6;
            this.btnTiendasCreate.Text = "Añadir";
            this.btnTiendasCreate.UseVisualStyleBackColor = true;
            this.btnTiendasCreate.Click += new System.EventHandler(this.btnTiendasCreate_Click);
            // 
            // btnTiendasUpdate
            // 
            this.btnTiendasUpdate.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiendasUpdate.Location = new System.Drawing.Point(132, 274);
            this.btnTiendasUpdate.Name = "btnTiendasUpdate";
            this.btnTiendasUpdate.Size = new System.Drawing.Size(94, 47);
            this.btnTiendasUpdate.TabIndex = 7;
            this.btnTiendasUpdate.Text = "Modificar";
            this.btnTiendasUpdate.UseVisualStyleBackColor = true;
            this.btnTiendasUpdate.Click += new System.EventHandler(this.btnTiendasUpdate_Click);
            // 
            // btnTiendasDelete
            // 
            this.btnTiendasDelete.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiendasDelete.Location = new System.Drawing.Point(32, 341);
            this.btnTiendasDelete.Name = "btnTiendasDelete";
            this.btnTiendasDelete.Size = new System.Drawing.Size(94, 47);
            this.btnTiendasDelete.TabIndex = 8;
            this.btnTiendasDelete.Text = "Eliminar";
            this.btnTiendasDelete.UseVisualStyleBackColor = true;
            this.btnTiendasDelete.Click += new System.EventHandler(this.btnTiendasDelete_Click);
            // 
            // btnTiendasRead
            // 
            this.btnTiendasRead.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiendasRead.Location = new System.Drawing.Point(132, 341);
            this.btnTiendasRead.Name = "btnTiendasRead";
            this.btnTiendasRead.Size = new System.Drawing.Size(94, 47);
            this.btnTiendasRead.TabIndex = 9;
            this.btnTiendasRead.Text = "Refrescar";
            this.btnTiendasRead.UseVisualStyleBackColor = true;
            this.btnTiendasRead.Click += new System.EventHandler(this.btnTiendasRead_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(20, 74);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(26, 19);
            this.ID.TabIndex = 11;
            this.ID.Text = "ID";
            // 
            // tbxTiendasId
            // 
            this.tbxTiendasId.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTiendasId.Location = new System.Drawing.Point(24, 96);
            this.tbxTiendasId.Name = "tbxTiendasId";
            this.tbxTiendasId.Size = new System.Drawing.Size(77, 27);
            this.tbxTiendasId.TabIndex = 10;
            // 
            // MenuAdministradorTiendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.tbxTiendasId);
            this.Controls.Add(this.btnTiendasRead);
            this.Controls.Add(this.btnTiendasDelete);
            this.Controls.Add(this.btnTiendasUpdate);
            this.Controls.Add(this.btnTiendasCreate);
            this.Controls.Add(this.dgvTiendas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxTiendasTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxTiendasNombre);
            this.Controls.Add(this.label1);
            this.Name = "MenuAdministradorTiendas";
            this.Text = "MenuAdministradorTiendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTiendasNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTiendasTelefono;
        private System.Windows.Forms.DataGridView dgvTiendas;
        private System.Windows.Forms.Button btnTiendasCreate;
        private System.Windows.Forms.Button btnTiendasUpdate;
        private System.Windows.Forms.Button btnTiendasDelete;
        private System.Windows.Forms.Button btnTiendasRead;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox tbxTiendasId;
    }
}