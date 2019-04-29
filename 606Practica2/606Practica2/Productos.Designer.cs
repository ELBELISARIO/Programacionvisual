using System.Windows.Forms;

namespace _606Practica2
{
    partial class Productos
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
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_descripcioncorta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nombrealterno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_codigoalterno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_siniva = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_precioVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmb_tienda = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmb_linea = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_marca = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_clasificacion = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_concepto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_acabado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_color = new System.Windows.Forms.ComboBox();
            this.txt_porcentajedescuento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_porcentajeiva = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_eliminarError = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.txt_descripcioncorta);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_nombrealterno);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_codigoalterno);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_siniva);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_precioVenta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_costo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(67, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_buscar.Location = new System.Drawing.Point(331, 29);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_descripcioncorta
            // 
            this.txt_descripcioncorta.Location = new System.Drawing.Point(162, 311);
            this.txt_descripcioncorta.MaxLength = 120;
            this.txt_descripcioncorta.Multiline = true;
            this.txt_descripcioncorta.Name = "txt_descripcioncorta";
            this.txt_descripcioncorta.Size = new System.Drawing.Size(157, 20);
            this.txt_descripcioncorta.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "DESCRIPCIÓN CORTA:";
            // 
            // txt_nombrealterno
            // 
            this.txt_nombrealterno.Location = new System.Drawing.Point(162, 285);
            this.txt_nombrealterno.MaxLength = 30;
            this.txt_nombrealterno.Name = "txt_nombrealterno";
            this.txt_nombrealterno.Size = new System.Drawing.Size(100, 20);
            this.txt_nombrealterno.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = " NOMBRE ALTERNO:";
            // 
            // txt_codigoalterno
            // 
            this.txt_codigoalterno.Location = new System.Drawing.Point(162, 259);
            this.txt_codigoalterno.MaxLength = 15;
            this.txt_codigoalterno.Name = "txt_codigoalterno";
            this.txt_codigoalterno.Size = new System.Drawing.Size(100, 20);
            this.txt_codigoalterno.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "CODIGO ALTERNO:";
            // 
            // txt_siniva
            // 
            this.txt_siniva.Location = new System.Drawing.Point(162, 233);
            this.txt_siniva.MaxLength = 21;
            this.txt_siniva.Name = "txt_siniva";
            this.txt_siniva.Size = new System.Drawing.Size(100, 20);
            this.txt_siniva.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = " Precio sin IVA:";
            // 
            // txt_precioVenta
            // 
            this.txt_precioVenta.Enabled = false;
            this.txt_precioVenta.Location = new System.Drawing.Point(162, 207);
            this.txt_precioVenta.Name = "txt_precioVenta";
            this.txt_precioVenta.Size = new System.Drawing.Size(100, 20);
            this.txt_precioVenta.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio de venta:";
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(162, 181);
            this.txt_costo.MaxLength = 21;
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(100, 20);
            this.txt_costo.TabIndex = 4;
            this.txt_costo.TextChanged += new System.EventHandler(this.txt_costo_TextChanged);
            this.txt_costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = " Costo estandar:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(162, 88);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(223, 84);
            this.txt_descripcion.TabIndex = 3;
            this.txt_descripcion.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripción:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(162, 57);
            this.txt_nombre.MaxLength = 30;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(145, 20);
            this.txt_nombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = " NOMBRE:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(162, 31);
            this.txt_codigo.MaxLength = 15;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(145, 20);
            this.txt_codigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO PRODUCTO:";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(321, 411);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(84, 50);
            this.btn_limpiar.TabIndex = 22;
            this.btn_limpiar.Text = " Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(411, 411);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(84, 50);
            this.btn_guardar.TabIndex = 19;
            this.btn_guardar.Text = " Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(501, 411);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(84, 50);
            this.btn_modificar.TabIndex = 20;
            this.btn_modificar.Text = " Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(591, 411);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(84, 50);
            this.btn_eliminar.TabIndex = 21;
            this.btn_eliminar.Text = " Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(755, 472);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(93, 25);
            this.btn_salir.TabIndex = 23;
            this.btn_salir.Text = " Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.cmb_tienda);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.cmb_linea);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cmb_marca);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cmb_clasificacion);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cmb_concepto);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmb_acabado);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmb_color);
            this.groupBox2.Controls.Add(this.txt_porcentajedescuento);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_porcentajeiva);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(501, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 288);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Clasificaciones";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(113, 196);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "Tienda:";
            // 
            // cmb_tienda
            // 
            this.cmb_tienda.FormattingEnabled = true;
            this.cmb_tienda.Location = new System.Drawing.Point(162, 193);
            this.cmb_tienda.Name = "cmb_tienda";
            this.cmb_tienda.Size = new System.Drawing.Size(197, 21);
            this.cmb_tienda.TabIndex = 16;
            this.cmb_tienda.SelectedIndexChanged += new System.EventHandler(this.cmb_tienda_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(118, 169);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Línea:";
            // 
            // cmb_linea
            // 
            this.cmb_linea.FormattingEnabled = true;
            this.cmb_linea.Location = new System.Drawing.Point(162, 166);
            this.cmb_linea.Name = "cmb_linea";
            this.cmb_linea.Size = new System.Drawing.Size(197, 21);
            this.cmb_linea.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(113, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = " Marca:";
            // 
            // cmb_marca
            // 
            this.cmb_marca.FormattingEnabled = true;
            this.cmb_marca.Location = new System.Drawing.Point(162, 139);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(197, 21);
            this.cmb_marca.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(84, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = " Clasificación:";
            // 
            // cmb_clasificacion
            // 
            this.cmb_clasificacion.FormattingEnabled = true;
            this.cmb_clasificacion.Location = new System.Drawing.Point(162, 112);
            this.cmb_clasificacion.Name = "cmb_clasificacion";
            this.cmb_clasificacion.Size = new System.Drawing.Size(197, 21);
            this.cmb_clasificacion.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(100, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Concepto:";
            // 
            // cmb_concepto
            // 
            this.cmb_concepto.FormattingEnabled = true;
            this.cmb_concepto.Location = new System.Drawing.Point(162, 85);
            this.cmb_concepto.Name = "cmb_concepto";
            this.cmb_concepto.Size = new System.Drawing.Size(197, 21);
            this.cmb_concepto.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(100, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = " Acabado:";
            // 
            // cmb_acabado
            // 
            this.cmb_acabado.FormattingEnabled = true;
            this.cmb_acabado.Location = new System.Drawing.Point(162, 58);
            this.cmb_acabado.Name = "cmb_acabado";
            this.cmb_acabado.Size = new System.Drawing.Size(197, 21);
            this.cmb_acabado.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(119, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = " Color:";
            // 
            // cmb_color
            // 
            this.cmb_color.FormattingEnabled = true;
            this.cmb_color.Location = new System.Drawing.Point(162, 31);
            this.cmb_color.Name = "cmb_color";
            this.cmb_color.Size = new System.Drawing.Size(197, 21);
            this.cmb_color.TabIndex = 10;
            // 
            // txt_porcentajedescuento
            // 
            this.txt_porcentajedescuento.Location = new System.Drawing.Point(162, 246);
            this.txt_porcentajedescuento.Name = "txt_porcentajedescuento";
            this.txt_porcentajedescuento.Size = new System.Drawing.Size(100, 20);
            this.txt_porcentajedescuento.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "% de descuento:";
            // 
            // txt_porcentajeiva
            // 
            this.txt_porcentajeiva.Location = new System.Drawing.Point(162, 220);
            this.txt_porcentajeiva.Name = "txt_porcentajeiva";
            this.txt_porcentajeiva.Size = new System.Drawing.Size(100, 20);
            this.txt_porcentajeiva.TabIndex = 17;
            this.txt_porcentajeiva.TextChanged += new System.EventHandler(this.txt_porcentajeiva_TextChanged);
            this.txt_porcentajeiva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_porcentajeiva_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(100, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "% de  IVA:";
            // 
            // btn_eliminarError
            // 
            this.btn_eliminarError.Location = new System.Drawing.Point(67, 411);
            this.btn_eliminarError.Name = "btn_eliminarError";
            this.btn_eliminarError.Size = new System.Drawing.Size(84, 50);
            this.btn_eliminarError.TabIndex = 24;
            this.btn_eliminarError.Text = " ¿Eliminaste por error?";
            this.btn_eliminarError.UseVisualStyleBackColor = true;
            this.btn_eliminarError.Click += new System.EventHandler(this.btn_eliminarError_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 522);
            this.Controls.Add(this.btn_eliminarError);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Productos";
            this.Text = "Productos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Productos_FormClosed);
            this.Load += new System.EventHandler(this.Productos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_descripcioncorta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_siniva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_precioVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txt_descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmb_tienda;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmb_linea;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_marca;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb_clasificacion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_concepto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_acabado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_color;
        private System.Windows.Forms.TextBox txt_porcentajedescuento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_porcentajeiva;
        private System.Windows.Forms.Label label13;
        public Button btn_limpiar;
        public Button btn_guardar;
        public Button btn_modificar;
        public Button btn_eliminar;
        public Button btn_buscar;
        public TextBox txt_nombrealterno;
        public TextBox txt_codigoalterno;
        public Button btn_eliminarError;
    }
}