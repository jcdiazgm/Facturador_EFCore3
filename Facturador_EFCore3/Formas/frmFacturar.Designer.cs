namespace Facturador_EFCore3.Formas
{
    partial class frmFacturar
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
            this.gbFacturar = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCorreoF = new System.Windows.Forms.Label();
            this.lblTelefonoF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDocumentoF = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblClientes = new System.Windows.Forms.Label();
            this.gbFacturas = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCofigo = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvFacturaDetalle = new System.Windows.Forms.DataGridView();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtTotalF = new System.Windows.Forms.TextBox();
            this.txtCorreoF = new System.Windows.Forms.TextBox();
            this.txtTelefonoF = new System.Windows.Forms.TextBox();
            this.txtDireccionF = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalF = new System.Windows.Forms.Label();
            this.txtDocumentoF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbFacturar.SuspendLayout();
            this.gbFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFacturar
            // 
            this.gbFacturar.Controls.Add(this.textBox1);
            this.gbFacturar.Controls.Add(this.lblCorreoF);
            this.gbFacturar.Controls.Add(this.lblTelefonoF);
            this.gbFacturar.Controls.Add(this.label2);
            this.gbFacturar.Controls.Add(this.lblDocumentoF);
            this.gbFacturar.Controls.Add(this.comboBox1);
            this.gbFacturar.Controls.Add(this.lblClientes);
            this.gbFacturar.Location = new System.Drawing.Point(13, 13);
            this.gbFacturar.Name = "gbFacturar";
            this.gbFacturar.Size = new System.Drawing.Size(429, 505);
            this.gbFacturar.TabIndex = 0;
            this.gbFacturar.TabStop = false;
            this.gbFacturar.Text = "Facturar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblCorreoF
            // 
            this.lblCorreoF.AutoSize = true;
            this.lblCorreoF.Location = new System.Drawing.Point(21, 147);
            this.lblCorreoF.Name = "lblCorreoF";
            this.lblCorreoF.Size = new System.Drawing.Size(44, 13);
            this.lblCorreoF.TabIndex = 0;
            this.lblCorreoF.Text = "Correo :";
            // 
            // lblTelefonoF
            // 
            this.lblTelefonoF.AutoSize = true;
            this.lblTelefonoF.Location = new System.Drawing.Point(21, 120);
            this.lblTelefonoF.Name = "lblTelefonoF";
            this.lblTelefonoF.Size = new System.Drawing.Size(55, 13);
            this.lblTelefonoF.TabIndex = 0;
            this.lblTelefonoF.Text = "Teléfono :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dirección :";
            // 
            // lblDocumentoF
            // 
            this.lblDocumentoF.AutoSize = true;
            this.lblDocumentoF.Location = new System.Drawing.Point(21, 66);
            this.lblDocumentoF.Name = "lblDocumentoF";
            this.lblDocumentoF.Size = new System.Drawing.Size(68, 13);
            this.lblDocumentoF.TabIndex = 0;
            this.lblDocumentoF.Text = "Documento :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Location = new System.Drawing.Point(21, 30);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(50, 13);
            this.lblClientes.TabIndex = 0;
            this.lblClientes.Text = "Clientes :";
            // 
            // gbFacturas
            // 
            this.gbFacturas.Controls.Add(this.txtTotal);
            this.gbFacturas.Controls.Add(this.txtDireccion);
            this.gbFacturas.Controls.Add(this.txtTelefono);
            this.gbFacturas.Controls.Add(this.txtCorreo);
            this.gbFacturas.Controls.Add(this.txtDocumento);
            this.gbFacturas.Controls.Add(this.txtCliente);
            this.gbFacturas.Controls.Add(this.txtFecha);
            this.gbFacturas.Controls.Add(this.txtCofigo);
            this.gbFacturas.Controls.Add(this.lblTotal);
            this.gbFacturas.Controls.Add(this.lblTelefono);
            this.gbFacturas.Controls.Add(this.lblCorreo);
            this.gbFacturas.Controls.Add(this.lblDireccion);
            this.gbFacturas.Controls.Add(this.lblDocumento);
            this.gbFacturas.Controls.Add(this.lblCliente);
            this.gbFacturas.Controls.Add(this.lblFecha);
            this.gbFacturas.Controls.Add(this.lblCodigo);
            this.gbFacturas.Controls.Add(this.dgvFacturaDetalle);
            this.gbFacturas.Controls.Add(this.dgvFacturas);
            this.gbFacturas.Location = new System.Drawing.Point(609, 12);
            this.gbFacturas.Name = "gbFacturas";
            this.gbFacturas.Size = new System.Drawing.Size(429, 505);
            this.gbFacturas.TabIndex = 0;
            this.gbFacturas.TabStop = false;
            this.gbFacturas.Text = "Facturas";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(330, 457);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(84, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(21, 304);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(354, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(139, 261);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(90, 20);
            this.txtTelefono.TabIndex = 3;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(235, 261);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(179, 20);
            this.txtCorreo.TabIndex = 3;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(19, 261);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(114, 20);
            this.txtDocumento.TabIndex = 3;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(211, 218);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(203, 20);
            this.txtCliente.TabIndex = 3;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(99, 218);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(106, 20);
            this.txtFecha.TabIndex = 3;
            // 
            // txtCofigo
            // 
            this.txtCofigo.Location = new System.Drawing.Point(20, 218);
            this.txtCofigo.Name = "txtCofigo";
            this.txtCofigo.Size = new System.Drawing.Size(73, 20);
            this.txtCofigo.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(274, 460);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "TOTAL";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(138, 245);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(232, 245);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(93, 13);
            this.lblCorreo.TabIndex = 1;
            this.lblCorreo.Text = "Correo electrónico";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(19, 288);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(16, 245);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 1;
            this.lblDocumento.Text = "Documento";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(208, 202);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(96, 202);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 202);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Factura No.";
            // 
            // dgvFacturaDetalle
            // 
            this.dgvFacturaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturaDetalle.Location = new System.Drawing.Point(20, 330);
            this.dgvFacturaDetalle.Name = "dgvFacturaDetalle";
            this.dgvFacturaDetalle.Size = new System.Drawing.Size(394, 121);
            this.dgvFacturaDetalle.TabIndex = 0;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(20, 30);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.Size = new System.Drawing.Size(394, 151);
            this.dgvFacturas.TabIndex = 0;
            this.dgvFacturas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_RowEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGrabar);
            this.groupBox1.Controls.Add(this.dgvDetalle);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.txtTotalF);
            this.groupBox1.Controls.Add(this.txtCorreoF);
            this.groupBox1.Controls.Add(this.txtTelefonoF);
            this.groupBox1.Controls.Add(this.txtDireccionF);
            this.groupBox1.Controls.Add(this.lblSubtotal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblTotalF);
            this.groupBox1.Controls.Add(this.txtDocumentoF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboProductos);
            this.groupBox1.Controls.Add(this.lblProductos);
            this.groupBox1.Controls.Add(this.cboClientes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 505);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturar";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(247, 29);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(116, 23);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "¡Hágale hermano!";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(24, 181);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(527, 217);
            this.dgvDetalle.TabIndex = 5;
            this.dgvDetalle.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellValueChanged);
            this.dgvDetalle.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvDetalle_CurrentCellDirtyStateChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(382, 404);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(382, 430);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 4;
            // 
            // txtTotalF
            // 
            this.txtTotalF.Location = new System.Drawing.Point(382, 456);
            this.txtTotalF.Name = "txtTotalF";
            this.txtTotalF.Size = new System.Drawing.Size(168, 20);
            this.txtTotalF.TabIndex = 4;
            // 
            // txtCorreoF
            // 
            this.txtCorreoF.Location = new System.Drawing.Point(95, 155);
            this.txtCorreoF.Name = "txtCorreoF";
            this.txtCorreoF.Size = new System.Drawing.Size(207, 20);
            this.txtCorreoF.TabIndex = 4;
            // 
            // txtTelefonoF
            // 
            this.txtTelefonoF.Location = new System.Drawing.Point(382, 129);
            this.txtTelefonoF.Name = "txtTelefonoF";
            this.txtTelefonoF.Size = new System.Drawing.Size(168, 20);
            this.txtTelefonoF.TabIndex = 4;
            // 
            // txtDireccionF
            // 
            this.txtDireccionF.Location = new System.Drawing.Point(95, 129);
            this.txtDireccionF.Name = "txtDireccionF";
            this.txtDireccionF.Size = new System.Drawing.Size(207, 20);
            this.txtDireccionF.TabIndex = 4;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(280, 410);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(96, 16);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "SUBTOTAL :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "IVA :";
            // 
            // lblTotalF
            // 
            this.lblTotalF.AutoSize = true;
            this.lblTotalF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalF.Location = new System.Drawing.Point(311, 458);
            this.lblTotalF.Name = "lblTotalF";
            this.lblTotalF.Size = new System.Drawing.Size(65, 16);
            this.lblTotalF.TabIndex = 0;
            this.lblTotalF.Text = "TOTAL :";
            // 
            // txtDocumentoF
            // 
            this.txtDocumentoF.Location = new System.Drawing.Point(382, 103);
            this.txtDocumentoF.Name = "txtDocumentoF";
            this.txtDocumentoF.Size = new System.Drawing.Size(168, 20);
            this.txtDocumentoF.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Teléfono :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dirección :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Documento :";
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(382, 155);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(168, 21);
            this.cboProductos.TabIndex = 1;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(308, 158);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(64, 13);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Productos : ";
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(95, 102);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(207, 21);
            this.cboClientes.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Clientes :";
            // 
            // frmFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 530);
            this.Controls.Add(this.gbFacturas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbFacturar);
            this.Name = "frmFacturar";
            this.Text = "frmFacturar";
            this.Load += new System.EventHandler(this.frmFacturar_Load);
            this.gbFacturar.ResumeLayout(false);
            this.gbFacturar.PerformLayout();
            this.gbFacturas.ResumeLayout(false);
            this.gbFacturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturaDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFacturar;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.GroupBox gbFacturas;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtCofigo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dgvFacturaDetalle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCorreoF;
        private System.Windows.Forms.Label lblTelefonoF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDocumentoF;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.TextBox txtTotalF;
        private System.Windows.Forms.TextBox txtCorreoF;
        private System.Windows.Forms.TextBox txtTelefonoF;
        private System.Windows.Forms.TextBox txtDireccionF;
        private System.Windows.Forms.Label lblTotalF;
        private System.Windows.Forms.TextBox txtDocumentoF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGrabar;
    }
}