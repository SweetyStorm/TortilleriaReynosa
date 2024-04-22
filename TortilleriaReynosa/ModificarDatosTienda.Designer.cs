namespace TortilleriaReynosa
{
    partial class ModificarDatosTienda
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
            this.dgvTiendas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.Label();
            this.tbxTiendasId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTiendasNombre = new System.Windows.Forms.TextBox();
            this.tbxTiendasTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTiendasUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTiendas
            // 
            this.dgvTiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiendas.Location = new System.Drawing.Point(235, 83);
            this.dgvTiendas.Name = "dgvTiendas";
            this.dgvTiendas.ReadOnly = true;
            this.dgvTiendas.Size = new System.Drawing.Size(482, 314);
            this.dgvTiendas.TabIndex = 6;
            this.dgvTiendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiendas_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(12, 107);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(28, 20);
            this.ID.TabIndex = 12;
            this.ID.Text = "ID";
            // 
            // tbxTiendasId
            // 
            this.tbxTiendasId.Enabled = false;
            this.tbxTiendasId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTiendasId.Location = new System.Drawing.Point(12, 144);
            this.tbxTiendasId.Name = "tbxTiendasId";
            this.tbxTiendasId.Size = new System.Drawing.Size(77, 26);
            this.tbxTiendasId.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre";
            // 
            // tbxTiendasNombre
            // 
            this.tbxTiendasNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTiendasNombre.Location = new System.Drawing.Point(8, 223);
            this.tbxTiendasNombre.Name = "tbxTiendasNombre";
            this.tbxTiendasNombre.Size = new System.Drawing.Size(221, 26);
            this.tbxTiendasNombre.TabIndex = 15;
            // 
            // tbxTiendasTelefono
            // 
            this.tbxTiendasTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTiendasTelefono.Location = new System.Drawing.Point(8, 309);
            this.tbxTiendasTelefono.Name = "tbxTiendasTelefono";
            this.tbxTiendasTelefono.Size = new System.Drawing.Size(221, 26);
            this.tbxTiendasTelefono.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Teléfono";
            // 
            // btnTiendasUpdate
            // 
            this.btnTiendasUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiendasUpdate.Location = new System.Drawing.Point(54, 367);
            this.btnTiendasUpdate.Name = "btnTiendasUpdate";
            this.btnTiendasUpdate.Size = new System.Drawing.Size(94, 47);
            this.btnTiendasUpdate.TabIndex = 18;
            this.btnTiendasUpdate.Text = "Modificar";
            this.btnTiendasUpdate.UseVisualStyleBackColor = true;
            this.btnTiendasUpdate.Click += new System.EventHandler(this.btnTiendasUpdate_Click);
            // 
            // ModificarDatosTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 462);
            this.Controls.Add(this.btnTiendasUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxTiendasTelefono);
            this.Controls.Add(this.tbxTiendasNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxTiendasId);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.dgvTiendas);
            this.Name = "ModificarDatosTienda";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.ModificarDatosTienda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTiendas;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox tbxTiendasId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTiendasNombre;
        private System.Windows.Forms.TextBox tbxTiendasTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTiendasUpdate;
    }
}