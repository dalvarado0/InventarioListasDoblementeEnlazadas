namespace InvetarioDoblementeEnlazado
{
    partial class Form1
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbReporte = new System.Windows.Forms.TextBox();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.txbPosicion = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.txbCandidad = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReporteInv = new System.Windows.Forms.Button();
            this.btnAddFirst = new System.Windows.Forms.Button();
            this.btnDeleteLast = new System.Windows.Forms.Button();
            this.btnDeleteFirst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(14, 226);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 20);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txbReporte
            // 
            this.txbReporte.Enabled = false;
            this.txbReporte.Location = new System.Drawing.Point(196, 11);
            this.txbReporte.Multiline = true;
            this.txbReporte.Name = "txbReporte";
            this.txbReporte.Size = new System.Drawing.Size(477, 345);
            this.txbReporte.TabIndex = 32;
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(74, 227);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(106, 20);
            this.txbBuscar.TabIndex = 36;
            // 
            // txbPosicion
            // 
            this.txbPosicion.Location = new System.Drawing.Point(74, 201);
            this.txbPosicion.Name = "txbPosicion";
            this.txbPosicion.Size = new System.Drawing.Size(106, 20);
            this.txbPosicion.TabIndex = 37;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(74, 89);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(106, 20);
            this.txbPrecio.TabIndex = 35;
            // 
            // txbCandidad
            // 
            this.txbCandidad.Location = new System.Drawing.Point(74, 63);
            this.txbCandidad.Name = "txbCandidad";
            this.txbCandidad.Size = new System.Drawing.Size(106, 20);
            this.txbCandidad.TabIndex = 34;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(74, 37);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(106, 20);
            this.txbNombre.TabIndex = 33;
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(74, 11);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(106, 20);
            this.txbCodigo.TabIndex = 27;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(74, 253);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(106, 39);
            this.btnReporte.TabIndex = 28;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(14, 198);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(54, 25);
            this.btnInsertar.TabIndex = 29;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(130, 115);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(50, 39);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "-";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(74, 115);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 39);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Código";
            // 
            // btnReporteInv
            // 
            this.btnReporteInv.Location = new System.Drawing.Point(74, 298);
            this.btnReporteInv.Name = "btnReporteInv";
            this.btnReporteInv.Size = new System.Drawing.Size(106, 39);
            this.btnReporteInv.TabIndex = 39;
            this.btnReporteInv.Text = "Reporte Invertido";
            this.btnReporteInv.UseVisualStyleBackColor = true;
            this.btnReporteInv.Click += new System.EventHandler(this.btnReporteInv_Click);
            // 
            // btnAddFirst
            // 
            this.btnAddFirst.Location = new System.Drawing.Point(14, 160);
            this.btnAddFirst.Name = "btnAddFirst";
            this.btnAddFirst.Size = new System.Drawing.Size(50, 35);
            this.btnAddFirst.TabIndex = 40;
            this.btnAddFirst.Text = "Add First";
            this.btnAddFirst.UseVisualStyleBackColor = true;
            this.btnAddFirst.Click += new System.EventHandler(this.btnAddFirst_Click);
            // 
            // btnDeleteLast
            // 
            this.btnDeleteLast.Location = new System.Drawing.Point(130, 160);
            this.btnDeleteLast.Name = "btnDeleteLast";
            this.btnDeleteLast.Size = new System.Drawing.Size(50, 35);
            this.btnDeleteLast.TabIndex = 40;
            this.btnDeleteLast.Text = "Delete Last";
            this.btnDeleteLast.UseVisualStyleBackColor = true;
            this.btnDeleteLast.Click += new System.EventHandler(this.btnDeleteLast_Click);
            // 
            // btnDeleteFirst
            // 
            this.btnDeleteFirst.Location = new System.Drawing.Point(70, 160);
            this.btnDeleteFirst.Name = "btnDeleteFirst";
            this.btnDeleteFirst.Size = new System.Drawing.Size(54, 35);
            this.btnDeleteFirst.TabIndex = 41;
            this.btnDeleteFirst.Text = "Delete First";
            this.btnDeleteFirst.UseVisualStyleBackColor = true;
            this.btnDeleteFirst.Click += new System.EventHandler(this.btnDeleteFirst_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 389);
            this.Controls.Add(this.btnDeleteFirst);
            this.Controls.Add(this.btnDeleteLast);
            this.Controls.Add(this.btnAddFirst);
            this.Controls.Add(this.btnReporteInv);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbReporte);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.txbPosicion);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbCandidad);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbReporte;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.TextBox txbPosicion;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.TextBox txbCandidad;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReporteInv;
        private System.Windows.Forms.Button btnAddFirst;
        private System.Windows.Forms.Button btnDeleteLast;
        private System.Windows.Forms.Button btnDeleteFirst;
    }
}

