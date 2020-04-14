namespace Facturador_EFCore3.Formas
{
    partial class frmProveedores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvProvProductos = new System.Windows.Forms.DataGridView();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnTodo = new System.Windows.Forms.Button();
            this.btnProProveedor = new System.Windows.Forms.Button();
            this.dgvTodo = new System.Windows.Forms.DataGridView();
            this.dgvPorProveedor = new System.Windows.Forms.DataGridView();
            this.dgvOrigen = new System.Windows.Forms.DataGridView();
            this.btnOrigen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cboOrigen2 = new System.Windows.Forms.ComboBox();
            this.dgvHerencia = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerencia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.cboOrigen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvProveedores);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 303);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Proveedores ";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(281, 13);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 14;
            this.btnCrear.Text = "Crear...";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // cboOrigen
            // 
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Items.AddRange(new object[] {
            "Nacional",
            "EE.UU.",
            "Mexico",
            "Argentina",
            "Alemania",
            "China",
            "Corea del sur"});
            this.cboOrigen.Location = new System.Drawing.Point(196, 83);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(169, 21);
            this.cboOrigen.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pais";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(6, 110);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(359, 182);
            this.dgvProveedores.TabIndex = 11;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(20, 84);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(169, 20);
            this.txtCorreo.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(63, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(20, 40);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(37, 20);
            this.txtCodigo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvProductos);
            this.groupBox2.Location = new System.Drawing.Point(480, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 119);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Productos ";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(6, 19);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(393, 92);
            this.dgvProductos.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvProvProductos);
            this.groupBox3.Location = new System.Drawing.Point(480, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 115);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Proveedor - Productos ";
            // 
            // dgvProvProductos
            // 
            this.dgvProvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProvProductos.Location = new System.Drawing.Point(6, 19);
            this.dgvProvProductos.Name = "dgvProvProductos";
            this.dgvProvProductos.Size = new System.Drawing.Size(393, 90);
            this.dgvProvProductos.TabIndex = 1;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(399, 160);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 8;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnTodo
            // 
            this.btnTodo.Location = new System.Drawing.Point(12, 433);
            this.btnTodo.Name = "btnTodo";
            this.btnTodo.Size = new System.Drawing.Size(75, 23);
            this.btnTodo.TabIndex = 9;
            this.btnTodo.Text = "Todo, todo";
            this.btnTodo.UseVisualStyleBackColor = true;
            this.btnTodo.Click += new System.EventHandler(this.btnTodo_Click);
            // 
            // btnProProveedor
            // 
            this.btnProProveedor.Location = new System.Drawing.Point(617, 433);
            this.btnProProveedor.Name = "btnProProveedor";
            this.btnProProveedor.Size = new System.Drawing.Size(144, 24);
            this.btnProProveedor.TabIndex = 9;
            this.btnProProveedor.Text = "Por proveedor";
            this.btnProProveedor.UseVisualStyleBackColor = true;
            this.btnProProveedor.Click += new System.EventHandler(this.btnProProveedor_Click);
            // 
            // dgvTodo
            // 
            this.dgvTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodo.Location = new System.Drawing.Point(12, 462);
            this.dgvTodo.Name = "dgvTodo";
            this.dgvTodo.Size = new System.Drawing.Size(586, 76);
            this.dgvTodo.TabIndex = 12;
            // 
            // dgvPorProveedor
            // 
            this.dgvPorProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPorProveedor.Location = new System.Drawing.Point(617, 462);
            this.dgvPorProveedor.Name = "dgvPorProveedor";
            this.dgvPorProveedor.Size = new System.Drawing.Size(421, 76);
            this.dgvPorProveedor.TabIndex = 12;
            // 
            // dgvOrigen
            // 
            this.dgvOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrigen.Location = new System.Drawing.Point(12, 351);
            this.dgvOrigen.Name = "dgvOrigen";
            this.dgvOrigen.Size = new System.Drawing.Size(365, 76);
            this.dgvOrigen.TabIndex = 12;
            // 
            // btnOrigen
            // 
            this.btnOrigen.Location = new System.Drawing.Point(159, 325);
            this.btnOrigen.Name = "btnOrigen";
            this.btnOrigen.Size = new System.Drawing.Size(75, 23);
            this.btnOrigen.TabIndex = 9;
            this.btnOrigen.Text = "Por Origen";
            this.btnOrigen.UseVisualStyleBackColor = true;
            this.btnOrigen.Click += new System.EventHandler(this.btnOrigen_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 607);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Por Origen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cboOrigen2
            // 
            this.cboOrigen2.FormattingEnabled = true;
            this.cboOrigen2.Items.AddRange(new object[] {
            "Proveedor",
            "Proveedor Interno",
            "Proveedor Externo"});
            this.cboOrigen2.Location = new System.Drawing.Point(12, 325);
            this.cboOrigen2.Name = "cboOrigen2";
            this.cboOrigen2.Size = new System.Drawing.Size(141, 21);
            this.cboOrigen2.TabIndex = 13;
            // 
            // dgvHerencia
            // 
            this.dgvHerencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHerencia.Location = new System.Drawing.Point(486, 286);
            this.dgvHerencia.Name = "dgvHerencia";
            this.dgvHerencia.Size = new System.Drawing.Size(393, 104);
            this.dgvHerencia.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Include de herencia";
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 550);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboOrigen2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPorProveedor);
            this.Controls.Add(this.dgvHerencia);
            this.Controls.Add(this.dgvOrigen);
            this.Controls.Add(this.dgvTodo);
            this.Controls.Add(this.btnProProveedor);
            this.Controls.Add(this.btnOrigen);
            this.Controls.Add(this.btnTodo);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHerencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvProvProductos;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnTodo;
        private System.Windows.Forms.Button btnProProveedor;
        private System.Windows.Forms.DataGridView dgvTodo;
        private System.Windows.Forms.DataGridView dgvPorProveedor;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox cboOrigen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvOrigen;
        private System.Windows.Forms.Button btnOrigen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboOrigen2;
        private System.Windows.Forms.DataGridView dgvHerencia;
        private System.Windows.Forms.Label label5;
    }
}