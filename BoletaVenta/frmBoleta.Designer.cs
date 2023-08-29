namespace BoletaVenta
{
    partial class frmBoleta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.lvDetalle = new System.Windows.Forms.ListView();
            this.ColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lvEstadisticas = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(125, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE VENTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "RUC 54512348";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(443, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "BOLETA DE VENTA";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(443, 58);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(37, 15);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "00000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "CLIENTE";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(84, 92);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(236, 23);
            this.txtCliente.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(84, 129);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(236, 23);
            this.txtDireccion.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "DIRECCIÓN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "FECHA";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(396, 92);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(147, 23);
            this.txtFecha.TabIndex = 9;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(396, 129);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(147, 23);
            this.txtCedula.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "CÉDULA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboProducto);
            this.groupBox1.Location = new System.Drawing.Point(14, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 72);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL PRODUCTO";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(446, 15);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "AGRAGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(325, 37);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtCantidad.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(325, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "CANTIDAD";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(200, 37);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtPrecio.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "PRECIO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "DESCRIPCIÓN";
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Items.AddRange(new object[] {
            "PS5 + 1 MANDO DS5",
            "PS4(1TB) + 1 MANDO DS4",
            "MANDO PS5/ DS5",
            "MANDO PS4/ DS4"});
            this.cboProducto.Location = new System.Drawing.Point(6, 37);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(173, 23);
            this.cboProducto.TabIndex = 0;
            // 
            // lvDetalle
            // 
            this.lvDetalle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader7});
            this.lvDetalle.GridLines = true;
            this.lvDetalle.Location = new System.Drawing.Point(20, 251);
            this.lvDetalle.Name = "lvDetalle";
            this.lvDetalle.Size = new System.Drawing.Size(523, 122);
            this.lvDetalle.TabIndex = 13;
            this.lvDetalle.UseCompatibleStateImageBehavior = false;
            this.lvDetalle.View = System.Windows.Forms.View.Details;
            this.lvDetalle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvDetalle_MouseDoubleClick);
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.Text = "CANTIDAD";
            this.ColumnHeader.Width = 80;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DESCRIPCION";
            this.columnHeader1.Width = 205;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PREC. UNIT.";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "IMPORTE";
            this.columnHeader7.Width = 117;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(20, 379);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "REGISTRAR BOLETA";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(447, 378);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 21);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(402, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 15);
            this.label13.TabIndex = 16;
            this.label13.Text = "TOTAL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 423);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 15);
            this.label14.TabIndex = 17;
            this.label14.Text = "RESUMEN DE REGISTRO DE BOLETAS";
            // 
            // lvEstadisticas
            // 
            this.lvEstadisticas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvEstadisticas.GridLines = true;
            this.lvEstadisticas.Location = new System.Drawing.Point(20, 441);
            this.lvEstadisticas.Name = "lvEstadisticas";
            this.lvEstadisticas.Size = new System.Drawing.Size(523, 121);
            this.lvEstadisticas.TabIndex = 18;
            this.lvEstadisticas.UseCompatibleStateImageBehavior = false;
            this.lvEstadisticas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "NUM BOLETAS";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "FECHA";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "TOTAL PRODUCTOS";
            this.columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MONTO TOTAL";
            this.columnHeader6.Width = 124;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(20, 568);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(562, 613);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvEstadisticas);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lvDetalle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBoleta";
            this.Text = "Control de Venta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblNumero;
        private Label label5;
        private TextBox txtCliente;
        private TextBox txtDireccion;
        private Label label6;
        private Label label7;
        private TextBox txtFecha;
        private TextBox txtCedula;
        private Label label8;
        private GroupBox groupBox1;
        private Button btnAgregar;
        private TextBox txtCantidad;
        private Label label11;
        private TextBox txtPrecio;
        private Label label10;
        private Label label9;
        private ComboBox cboProducto;
        private ListView lvDetalle;
        private ColumnHeader ColumnHeader;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader7;
        private Button btnRegistrar;
        private Label lblTotal;
        private Label label13;
        private Label label14;
        private ListView lvEstadisticas;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnSalir;
    }
}