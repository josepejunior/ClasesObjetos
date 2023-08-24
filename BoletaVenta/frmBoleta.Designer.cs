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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblNumero = new Label();
            label5 = new Label();
            txtCliente = new TextBox();
            txtDireccion = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtFecha = new TextBox();
            txtCedula = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            txtCantidad = new TextBox();
            label11 = new Label();
            txtPrecio = new TextBox();
            label10 = new Label();
            label9 = new Label();
            cboProducto = new ComboBox();
            lvDetalle = new ListView();
            ColumnHeader = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            btnRegistrar = new Button();
            lblTotal = new Label();
            label13 = new Label();
            label14 = new Label();
            lvEstadisticas = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(125, 23);
            label1.Name = "label1";
            label1.Size = new Size(292, 37);
            label1.TabIndex = 0;
            label1.Text = "CONTROL DE VENTA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(443, 9);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "RUC 54512348";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(443, 32);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 2;
            label3.Text = "BOLETA DE VENTA";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(443, 58);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(37, 15);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "00000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 95);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "CLIENTE";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(84, 92);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(236, 23);
            txtCliente.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(84, 129);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(236, 23);
            txtDireccion.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 132);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 6;
            label6.Text = "DIRECCIÓN";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(339, 95);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 8;
            label7.Text = "FECHA";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(396, 92);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(147, 23);
            txtFecha.TabIndex = 9;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(396, 129);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(147, 23);
            txtCedula.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(339, 133);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 10;
            label8.Text = "CÉDULA";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cboProducto);
            groupBox1.Location = new Point(14, 173);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(529, 72);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DEL PRODUCTO";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(446, 15);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "AGRAGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(325, 37);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(325, 19);
            label11.Name = "label11";
            label11.Size = new Size(65, 15);
            label11.TabIndex = 4;
            label11.Text = "CANTIDAD";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(200, 37);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(200, 19);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 2;
            label10.Text = "PRECIO";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 19);
            label9.Name = "label9";
            label9.Size = new Size(81, 15);
            label9.TabIndex = 1;
            label9.Text = "DESCRIPCIÓN";
            // 
            // cboProducto
            // 
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.FormattingEnabled = true;
            cboProducto.Items.AddRange(new object[] { "PS5 + 1 MANDO DS5", "PS4(1TB) + 1 MANDO DS4", "MANDO PS5/ DS5", "MANDO PS4/ DS4" });
            cboProducto.Location = new Point(6, 37);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(173, 23);
            cboProducto.TabIndex = 0;
            cboProducto.SelectedIndexChanged += cboProducto_SelectedIndexChanged;
            // 
            // lvDetalle
            // 
            lvDetalle.Columns.AddRange(new ColumnHeader[] { ColumnHeader, columnHeader1, columnHeader2, columnHeader7 });
            lvDetalle.GridLines = true;
            lvDetalle.Location = new Point(20, 251);
            lvDetalle.Name = "lvDetalle";
            lvDetalle.Size = new Size(523, 122);
            lvDetalle.TabIndex = 13;
            lvDetalle.UseCompatibleStateImageBehavior = false;
            lvDetalle.View = View.Details;
            // 
            // ColumnHeader
            // 
            ColumnHeader.Text = "CANTIDAD";
            ColumnHeader.Width = 80;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "DESCRIPCION";
            columnHeader1.Width = 205;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "PREC. UNIT.";
            columnHeader2.Width = 117;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "IMPORTE";
            columnHeader7.Width = 117;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(20, 379);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "REGISTRAR BOLETA";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(447, 378);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(66, 21);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "label12";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(402, 383);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 16;
            label13.Text = "TOTAL";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 423);
            label14.Name = "label14";
            label14.Size = new Size(199, 15);
            label14.TabIndex = 17;
            label14.Text = "RESUMEN DE REGISTRO DE BOLETAS";
            // 
            // lvEstadisticas
            // 
            lvEstadisticas.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lvEstadisticas.GridLines = true;
            lvEstadisticas.Location = new Point(20, 441);
            lvEstadisticas.Name = "lvEstadisticas";
            lvEstadisticas.Size = new Size(523, 121);
            lvEstadisticas.TabIndex = 18;
            lvEstadisticas.UseCompatibleStateImageBehavior = false;
            lvEstadisticas.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "NUM BOLETAS";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "FECHA";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "TOTAL PRODUCTOS";
            columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "MONTO TOTAL";
            columnHeader6.Width = 124;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(20, 568);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmBoleta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(562, 613);
            Controls.Add(btnSalir);
            Controls.Add(lvEstadisticas);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(lblTotal);
            Controls.Add(btnRegistrar);
            Controls.Add(lvDetalle);
            Controls.Add(groupBox1);
            Controls.Add(txtCedula);
            Controls.Add(label8);
            Controls.Add(txtFecha);
            Controls.Add(label7);
            Controls.Add(txtDireccion);
            Controls.Add(label6);
            Controls.Add(txtCliente);
            Controls.Add(label5);
            Controls.Add(lblNumero);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBoleta";
            Text = "Control de Venta";
            Load += frmBoleta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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