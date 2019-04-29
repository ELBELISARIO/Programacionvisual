namespace _606Practica2
{
    partial class Ventas
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
            this.components = new System.ComponentModel.Container();
            this.datagridproductos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numeroventa = new System.Windows.Forms.TextBox();
            this.txt_caja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_descuentoadicional = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_vendedor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_producto = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ckb_codigoalterno = new System.Windows.Forms.CheckBox();
            this.ckb_articuloapartado = new System.Windows.Forms.CheckBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.panel_apartado = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_bucarcliente = new System.Windows.Forms.Button();
            this.cmb_clienteapartado = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_numeroapartado = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ckb_factura = new System.Windows.Forms.CheckBox();
            this.txt_apartadomonto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_movimientoapartado = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pV606DataSet = new _606Practica2.PV606DataSet();
            this.pV606DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pV606DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.datagridventa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridproductos)).BeginInit();
            this.panel_apartado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pV606DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pV606DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pV606DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridventa)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridproductos
            // 
            this.datagridproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridproductos.Location = new System.Drawing.Point(39, 225);
            this.datagridproductos.Name = "datagridproductos";
            this.datagridproductos.Size = new System.Drawing.Size(1010, 256);
            this.datagridproductos.TabIndex = 0;
            this.datagridproductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridproductos_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "# de venta:";
            // 
            // txt_numeroventa
            // 
            this.txt_numeroventa.Location = new System.Drawing.Point(101, 25);
            this.txt_numeroventa.Name = "txt_numeroventa";
            this.txt_numeroventa.Size = new System.Drawing.Size(83, 20);
            this.txt_numeroventa.TabIndex = 3;
            this.txt_numeroventa.TabStop = false;
            this.txt_numeroventa.TextChanged += new System.EventHandler(this.txt_numeroventa_TextChanged);
            // 
            // txt_caja
            // 
            this.txt_caja.Location = new System.Drawing.Point(254, 28);
            this.txt_caja.Name = "txt_caja";
            this.txt_caja.Size = new System.Drawing.Size(35, 20);
            this.txt_caja.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = " Caja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = " Cliente:";
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(359, 32);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(121, 21);
            this.cmb_cliente.TabIndex = 7;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(980, 37);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(83, 20);
            this.txt_subtotal.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(915, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subtotal:";
            // 
            // txt_iva
            // 
            this.txt_iva.Location = new System.Drawing.Point(980, 68);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(83, 20);
            this.txt_iva.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(934, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = " IVA:";
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(980, 96);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(33, 20);
            this.txt_descuento.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(885, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = " % de descuento:";
            // 
            // txt_descuentoadicional
            // 
            this.txt_descuentoadicional.Location = new System.Drawing.Point(980, 128);
            this.txt_descuentoadicional.Name = "txt_descuentoadicional";
            this.txt_descuentoadicional.Size = new System.Drawing.Size(83, 20);
            this.txt_descuentoadicional.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(864, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = " Descuento adicional:";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(980, 171);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(83, 20);
            this.txt_total.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(915, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "TOTAL:";
            // 
            // cmb_vendedor
            // 
            this.cmb_vendedor.FormattingEnabled = true;
            this.cmb_vendedor.Location = new System.Drawing.Point(634, 37);
            this.cmb_vendedor.Name = "cmb_vendedor";
            this.cmb_vendedor.Size = new System.Drawing.Size(121, 21);
            this.cmb_vendedor.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(572, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Vendedor:";
            // 
            // cmb_producto
            // 
            this.cmb_producto.FormattingEnabled = true;
            this.cmb_producto.Location = new System.Drawing.Point(101, 100);
            this.cmb_producto.Name = "cmb_producto";
            this.cmb_producto.Size = new System.Drawing.Size(162, 21);
            this.cmb_producto.TabIndex = 21;
            this.cmb_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_producto_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "PRODUCTO:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(127, 151);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(83, 20);
            this.textBox8.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Precio manual:";
            // 
            // ckb_codigoalterno
            // 
            this.ckb_codigoalterno.AutoSize = true;
            this.ckb_codigoalterno.Location = new System.Drawing.Point(104, 67);
            this.ckb_codigoalterno.Name = "ckb_codigoalterno";
            this.ckb_codigoalterno.Size = new System.Drawing.Size(159, 17);
            this.ckb_codigoalterno.TabIndex = 24;
            this.ckb_codigoalterno.Text = "¿Buscar por codigo alterno?";
            this.ckb_codigoalterno.UseVisualStyleBackColor = true;
            // 
            // ckb_articuloapartado
            // 
            this.ckb_articuloapartado.AutoSize = true;
            this.ckb_articuloapartado.Location = new System.Drawing.Point(99, 128);
            this.ckb_articuloapartado.Name = "ckb_articuloapartado";
            this.ckb_articuloapartado.Size = new System.Drawing.Size(155, 17);
            this.ckb_articuloapartado.TabIndex = 25;
            this.ckb_articuloapartado.Text = " ¿El articulo sera apartado?";
            this.ckb_articuloapartado.UseVisualStyleBackColor = true;
            this.ckb_articuloapartado.CheckedChanged += new System.EventHandler(this.ckb_articuloapartado_CheckedChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(277, 98);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 26;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(277, 144);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(107, 23);
            this.btn_consultar.TabIndex = 27;
            this.btn_consultar.Text = "Consultar precio";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_agregar.Location = new System.Drawing.Point(575, 88);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 42);
            this.btn_agregar.TabIndex = 28;
            this.btn_agregar.Text = " Agregar Producto";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(517, 100);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(35, 20);
            this.txt_cantidad.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(456, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = " Cantidad:";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_confirmar.Location = new System.Drawing.Point(658, 151);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 42);
            this.btn_confirmar.TabIndex = 33;
            this.btn_confirmar.Text = " Confirmar Actualizar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            // 
            // btn_quitar
            // 
            this.btn_quitar.BackColor = System.Drawing.Color.Crimson;
            this.btn_quitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_quitar.Location = new System.Drawing.Point(658, 88);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(75, 42);
            this.btn_quitar.TabIndex = 34;
            this.btn_quitar.Text = "Quitar Ultimo";
            this.btn_quitar.UseVisualStyleBackColor = false;
            // 
            // panel_apartado
            // 
            this.panel_apartado.Controls.Add(this.dataGridView2);
            this.panel_apartado.Controls.Add(this.btn_bucarcliente);
            this.panel_apartado.Controls.Add(this.cmb_clienteapartado);
            this.panel_apartado.Controls.Add(this.label17);
            this.panel_apartado.Controls.Add(this.textBox4);
            this.panel_apartado.Controls.Add(this.label16);
            this.panel_apartado.Controls.Add(this.txt_numeroapartado);
            this.panel_apartado.Controls.Add(this.label15);
            this.panel_apartado.Controls.Add(this.ckb_factura);
            this.panel_apartado.Controls.Add(this.txt_apartadomonto);
            this.panel_apartado.Controls.Add(this.label14);
            this.panel_apartado.Controls.Add(this.cmb_movimientoapartado);
            this.panel_apartado.Controls.Add(this.label13);
            this.panel_apartado.Location = new System.Drawing.Point(39, 225);
            this.panel_apartado.Name = "panel_apartado";
            this.panel_apartado.Size = new System.Drawing.Size(1010, 256);
            this.panel_apartado.TabIndex = 35;
            this.panel_apartado.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(23, 73);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(978, 178);
            this.dataGridView2.TabIndex = 52;
            // 
            // btn_bucarcliente
            // 
            this.btn_bucarcliente.Location = new System.Drawing.Point(489, 40);
            this.btn_bucarcliente.Name = "btn_bucarcliente";
            this.btn_bucarcliente.Size = new System.Drawing.Size(75, 23);
            this.btn_bucarcliente.TabIndex = 36;
            this.btn_bucarcliente.Text = "Buscar";
            this.btn_bucarcliente.UseVisualStyleBackColor = true;
            // 
            // cmb_clienteapartado
            // 
            this.cmb_clienteapartado.FormattingEnabled = true;
            this.cmb_clienteapartado.Location = new System.Drawing.Point(219, 37);
            this.cmb_clienteapartado.Name = "cmb_clienteapartado";
            this.cmb_clienteapartado.Size = new System.Drawing.Size(235, 21);
            this.cmb_clienteapartado.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(168, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = " Cliente:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(63, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 20);
            this.textBox4.TabIndex = 51;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "Clave:";
            // 
            // txt_numeroapartado
            // 
            this.txt_numeroapartado.Location = new System.Drawing.Point(679, 11);
            this.txt_numeroapartado.Name = "txt_numeroapartado";
            this.txt_numeroapartado.Size = new System.Drawing.Size(108, 20);
            this.txt_numeroapartado.TabIndex = 49;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(596, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 48;
            this.label15.Text = "# de apartado:";
            // 
            // ckb_factura
            // 
            this.ckb_factura.AutoSize = true;
            this.ckb_factura.Location = new System.Drawing.Point(505, 13);
            this.ckb_factura.Name = "ckb_factura";
            this.ckb_factura.Size = new System.Drawing.Size(74, 17);
            this.ckb_factura.TabIndex = 47;
            this.ckb_factura.Text = "¿Factura?";
            this.ckb_factura.UseVisualStyleBackColor = true;
            // 
            // txt_apartadomonto
            // 
            this.txt_apartadomonto.Location = new System.Drawing.Point(460, 10);
            this.txt_apartadomonto.Name = "txt_apartadomonto";
            this.txt_apartadomonto.Size = new System.Drawing.Size(35, 20);
            this.txt_apartadomonto.TabIndex = 46;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(366, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = " Apartado-monto:";
            // 
            // cmb_movimientoapartado
            // 
            this.cmb_movimientoapartado.FormattingEnabled = true;
            this.cmb_movimientoapartado.Location = new System.Drawing.Point(137, 10);
            this.cmb_movimientoapartado.Name = "cmb_movimientoapartado";
            this.cmb_movimientoapartado.Size = new System.Drawing.Size(203, 21);
            this.cmb_movimientoapartado.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Movimiento de apartado:";
            // 
            // pV606DataSet
            // 
            this.pV606DataSet.DataSetName = "PV606DataSet";
            this.pV606DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pV606DataSetBindingSource
            // 
            this.pV606DataSetBindingSource.DataSource = this.pV606DataSet;
            this.pV606DataSetBindingSource.Position = 0;
            // 
            // pV606DataSetBindingSource1
            // 
            this.pV606DataSetBindingSource1.DataSource = this.pV606DataSet;
            this.pV606DataSetBindingSource1.Position = 0;
            // 
            // datagridventa
            // 
            this.datagridventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridventa.Location = new System.Drawing.Point(39, 225);
            this.datagridventa.Name = "datagridventa";
            this.datagridventa.Size = new System.Drawing.Size(1019, 256);
            this.datagridventa.TabIndex = 36;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 538);
            this.Controls.Add(this.panel_apartado);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.ckb_articuloapartado);
            this.Controls.Add(this.ckb_codigoalterno);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb_producto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb_vendedor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_descuentoadicional);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_iva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_caja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_numeroventa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datagridproductos);
            this.Controls.Add(this.datagridventa);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridproductos)).EndInit();
            this.panel_apartado.ResumeLayout(false);
            this.panel_apartado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pV606DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pV606DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pV606DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridventa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridproductos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_numeroventa;
        private System.Windows.Forms.TextBox txt_caja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_descuentoadicional;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_vendedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_producto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ckb_codigoalterno;
        private System.Windows.Forms.CheckBox ckb_articuloapartado;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Panel panel_apartado;
        private System.Windows.Forms.TextBox txt_numeroapartado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox ckb_factura;
        private System.Windows.Forms.TextBox txt_apartadomonto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_movimientoapartado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_bucarcliente;
        private System.Windows.Forms.ComboBox cmb_clienteapartado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label16;
        private PV606DataSet pV606DataSet;
        private System.Windows.Forms.BindingSource pV606DataSetBindingSource;
        private System.Windows.Forms.BindingSource pV606DataSetBindingSource1;
        private System.Windows.Forms.DataGridView datagridventa;
    }
}