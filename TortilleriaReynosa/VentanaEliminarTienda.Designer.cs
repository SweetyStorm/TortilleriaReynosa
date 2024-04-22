namespace TortilleriaReynosa
{
    partial class VentanaEliminarTienda
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
            this.ID = new System.Windows.Forms.Label();
            this.PnlTiendaEliminar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTiendasId = new System.Windows.Forms.TextBox();
            this.dgvTiendas = new System.Windows.Forms.DataGridView();
            this.btnTiendasDelete = new System.Windows.Forms.Button();
            this.PnlTiendaEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendas)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(343, 253);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 20);
            this.ID.TabIndex = 12;
            // 
            // PnlTiendaEliminar
            // 
            this.PnlTiendaEliminar.Controls.Add(this.btnTiendasDelete);
            this.PnlTiendaEliminar.Controls.Add(this.dgvTiendas);
            this.PnlTiendaEliminar.Controls.Add(this.tbxTiendasId);
            this.PnlTiendaEliminar.Controls.Add(this.label1);
            this.PnlTiendaEliminar.Controls.Add(this.label2);
            this.PnlTiendaEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTiendaEliminar.Location = new System.Drawing.Point(0, 0);
            this.PnlTiendaEliminar.Name = "PnlTiendaEliminar";
            this.PnlTiendaEliminar.Size = new System.Drawing.Size(714, 526);
            this.PnlTiendaEliminar.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "TIENDAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // tbxTiendasId
            // 
            this.tbxTiendasId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTiendasId.Location = new System.Drawing.Point(72, 122);
            this.tbxTiendasId.Name = "tbxTiendasId";
            this.tbxTiendasId.Size = new System.Drawing.Size(77, 26);
            this.tbxTiendasId.TabIndex = 13;
            // 
            // dgvTiendas
            // 
            this.dgvTiendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiendas.Location = new System.Drawing.Point(220, 99);
            this.dgvTiendas.Name = "dgvTiendas";
            this.dgvTiendas.ReadOnly = true;
            this.dgvTiendas.Size = new System.Drawing.Size(482, 314);
            this.dgvTiendas.TabIndex = 14;
            // 
            // btnTiendasDelete
            // 
            this.btnTiendasDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiendasDelete.Location = new System.Drawing.Point(72, 191);
            this.btnTiendasDelete.Name = "btnTiendasDelete";
            this.btnTiendasDelete.Size = new System.Drawing.Size(94, 47);
            this.btnTiendasDelete.TabIndex = 15;
            this.btnTiendasDelete.Text = "Eliminar";
            this.btnTiendasDelete.UseVisualStyleBackColor = true;
            this.btnTiendasDelete.Click += new System.EventHandler(this.btnTiendasDelete_Click);
            // 
            // VentanaEliminarTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 526);
            this.Controls.Add(this.PnlTiendaEliminar);
            this.Controls.Add(this.ID);
            this.Name = "VentanaEliminarTienda";
            this.Text = "VentanaEliminarTienda";
            this.Load += new System.EventHandler(this.VentanaEliminarTienda_Load);
            this.PnlTiendaEliminar.ResumeLayout(false);
            this.PnlTiendaEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Panel PnlTiendaEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTiendasId;
        private System.Windows.Forms.DataGridView dgvTiendas;
        private System.Windows.Forms.Button btnTiendasDelete;
    }
}