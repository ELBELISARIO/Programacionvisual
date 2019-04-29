using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace _606Practica2
{
    public partial class Productos : Form
    {
        SqlConnection INTEGRAL;
        SqlCommand comando;
        SqlDataReader dr;
        string codigooriginal=null;

        public Productos()
        {
            InitializeComponent();
            string connnectionString = ConfigurationManager.ConnectionStrings["PV606"].ConnectionString;
            INTEGRAL = new SqlConnection(connnectionString);
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            groupBox1.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            groupBox1.Controls.OfType<RichTextBox>().ToList().ForEach(o => o.Text = "");
            //(groupBox2.Controls.OfType<ComboBox>().ToList().ForEach(o => o.Text = "");
            groupBox2.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
            mostrarelementoscmb();
        }

        private void Productos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            INTEGRAL.Close();
            INTEGRAL.Open();
            comando = new SqlCommand("Select Color_nombre from Color", INTEGRAL);
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                cmb_color.Items.Add(dr["Color_nombre"].ToString());
            }
            dr.Close();

            comando = new SqlCommand("Select Acabado_nombre from Acabado", INTEGRAL);
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                cmb_acabado.Items.Add(dr["Acabado_nombre"].ToString());
            }
            dr.Close();

            comando = new SqlCommand("Select Concepto_nombre from Concepto", INTEGRAL);
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                cmb_concepto.Items.Add(dr["Concepto_nombre"].ToString());
            }
            dr.Close();

            comando = new SqlCommand("Select Clasificacion_nombre from Clasificacion", INTEGRAL);
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                cmb_clasificacion.Items.Add(dr["Clasificacion_nombre"].ToString());
            }
            dr.Close();

            comando = new SqlCommand("Select Marca_nombre from Marca", INTEGRAL);
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                cmb_marca.Items.Add(dr["Marca_nombre"].ToString());
            }
            dr.Close();

            comando = new SqlCommand("Select Linea_nombre from Linea", INTEGRAL);
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                cmb_linea.Items.Add(dr["Linea_nombre"].ToString());
            }
            dr.Close();

            comando = new SqlCommand("Select Tienda_nombre from Tienda", INTEGRAL);
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                cmb_tienda.Items.Add(dr["Tienda_nombre"].ToString());
            }
            dr.Close();

            mostrarelementoscmb();
        }

        private void mostrarelementoscmb()
        {
            cmb_color.SelectedIndex = 0;
            cmb_acabado.SelectedIndex = 0;
            cmb_clasificacion.SelectedIndex = 0;
            cmb_concepto.SelectedIndex = 0;
            cmb_linea.SelectedIndex = 0;
            cmb_marca.SelectedIndex = 0;
            cmb_tienda.SelectedIndex = 0;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            comando = new SqlCommand("insert into Productos values('" + txt_codigo.Text + "','" + txt_nombre.Text + "','" + txt_descripcion.Text + "'," + Convert.ToDouble(txt_costo.Text) + ",'" + Convert.ToDouble(txt_siniva.Text) + "','" + txt_codigoalterno.Text + "','" + txt_nombrealterno.Text + "','" + txt_descripcioncorta.Text + "','" + txt_precioVenta.Text + "')", INTEGRAL);
            try
            {
                comando.ExecuteNonQuery();
                dr.Close();
                string consulta1 = "insert into Productos_detalle values((select max(IdProducto) from Productos)," + (Convert.ToInt32(cmb_color.SelectedIndex) + 1) + "," + (Convert.ToInt32(cmb_acabado.SelectedIndex) + 1) + "," + (Convert.ToInt32(cmb_concepto.SelectedIndex) + 1) + "," + (Convert.ToInt32(cmb_clasificacion.SelectedIndex) + 1) + "," + (Convert.ToInt32(cmb_marca.SelectedIndex) + 1) + "," + (Convert.ToInt32(cmb_linea.SelectedIndex) + 1) + "," + (Convert.ToInt32(cmb_tienda.SelectedIndex) + 1) + "," + Convert.ToDouble(txt_porcentajeiva.Text) + "," + Convert.ToDouble(txt_porcentajedescuento.Text) + ")";
                comando = new SqlCommand(consulta1, INTEGRAL);
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto guardado correctamente");
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.ToString());
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                INTEGRAL.Close();
                INTEGRAL.Open();

                comando = new SqlCommand("Select * from Productos where codigo_producto='" + txt_codigo.Text + "'", INTEGRAL);
                dr = comando.ExecuteReader();
                if (dr.Read())
                {
                    codigooriginal = txt_codigo.Text;
                    txt_nombre.Text = dr["nombre_producto"].ToString();
                    txt_descripcion.Text = dr["descripcion_producto"].ToString();
                    txt_costo.Text = dr["costoestandar_producto"].ToString();
                    txt_precioVenta.Text = dr["precioventa_producto"].ToString();
                    txt_siniva.Text = dr["preciosiniva_producto"].ToString();
                    txt_codigoalterno.Text = dr["codigoalterno_producto"].ToString();
                    txt_nombrealterno.Text = dr["nombrealterno_producto"].ToString();
                    txt_descripcioncorta.Text = dr["descripcioncorta_producto"].ToString();
                    string idProducto = dr["IdProducto"].ToString();
                    dr.Close();
                    comando = new SqlCommand("Select * from Productos_detalle where IdProducto='" + idProducto + "'", INTEGRAL);
                    dr = comando.ExecuteReader();
                    if (dr.Read())
                    {
                        cmb_color.SelectedIndex = (Convert.ToInt32(dr["IdColor"].ToString()) - 1);
                        cmb_acabado.SelectedIndex = Convert.ToInt32(dr["IdAcabado"].ToString()) - 1;
                        cmb_clasificacion.SelectedIndex = Convert.ToInt32(dr["IdClasificacion"].ToString()) - 1;
                        cmb_concepto.SelectedIndex = Convert.ToInt32(dr["IdConcepto"].ToString()) - 1;
                        cmb_linea.SelectedIndex = Convert.ToInt32(dr["IdLinea"].ToString()) - 1;
                        cmb_marca.SelectedIndex = Convert.ToInt32(dr["IdMarca"].ToString()) - 1;
                        cmb_tienda.SelectedIndex = Convert.ToInt32(dr["IdTienda"].ToString()) - 1;
                        txt_porcentajeiva.Text = dr["porcentaje_iva"].ToString();
                        txt_porcentajedescuento.Text = dr["descuento_producto"].ToString();
                        dr.Close();
                    }
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("No existe el producto");
                }
                dr.Close();
            }
            catch (Exception exe)
            {

                MessageBox.Show(exe.ToString());
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                INTEGRAL.Close();
                INTEGRAL.Open();

                comando = new SqlCommand("Select IdProducto from Productos where codigo_producto='" + txt_codigo.Text + "'", INTEGRAL);
                dr = comando.ExecuteReader();
                string IdProducto = null;
                if (dr.Read())
                {
                    IdProducto = dr["IdProducto"].ToString();
                }
                dr.Close();
                comando = new SqlCommand("DELETE FROM Productos_detalle WHERE IdProducto=" + IdProducto + "", INTEGRAL);
                comando.ExecuteNonQuery();

                comando = new SqlCommand("DELETE FROM Productos WHERE codigo_producto='" + txt_codigo.Text + "'", INTEGRAL);
                comando.ExecuteNonQuery();
           
                MessageBox.Show("Producto eliminado");
                
            }
            catch (Exception exe)
            {

                MessageBox.Show(exe.ToString());
            }
        }

        private void btn_eliminarError_Click(object sender, EventArgs e)
        {
            INTEGRAL.Close();
            INTEGRAL.Open();

            comando = new SqlCommand("Select * from Productos where codigo_producto='" + txt_codigo.Text + "'", INTEGRAL);
            dr = comando.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("El producto ya existe");
            }
            else
	        {
                dr.Close();
                comando = new SqlCommand("insert into Productos values('" + txt_codigo.Text + "','" + txt_nombre.Text + "','" + txt_descripcion.Text + "','" + Convert.ToDouble(txt_costo.Text) + "','" + Convert.ToDouble(txt_siniva.Text) + "','" + txt_codigoalterno.Text + "','" + txt_nombrealterno.Text + "','" + txt_descripcioncorta.Text + "','" + txt_precioVenta.Text + "')", INTEGRAL);
                try
                {
                    comando.ExecuteNonQuery();
                    string consulta1 = "insert into Productos_detalle values((select max(IdProducto) from Productos)," + (Convert.ToInt32(cmb_color.SelectedIndex) + 1) + "," + (Convert.ToInt32(cmb_acabado.SelectedIndex) + 1) + "," + (Convert.ToInt32(cmb_concepto.SelectedIndex) + 1) + "," + (Convert.ToInt32(cmb_clasificacion.SelectedIndex) + 1) + "," + (Convert.ToInt32(cmb_marca.SelectedIndex) + 1) + "," + (Convert.ToInt32(cmb_linea.SelectedIndex) + 1) + "," + (Convert.ToInt32(cmb_tienda.SelectedIndex) + 1) + "," + Convert.ToDouble(txt_porcentajeiva.Text) + "," + Convert.ToDouble(txt_porcentajedescuento.Text) + ")";
                    comando = new SqlCommand(consulta1, INTEGRAL);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Producto guardado correctamente");
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.ToString());
                }
            }
            dr.Close();
        }

        private void txt_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_costo_TextChanged(object sender, EventArgs e)
        {
            if (txt_costo.Text!="" && txt_porcentajeiva.Text!="")
            {
                txt_precioVenta.Text = (Convert.ToDouble(txt_costo.Text) * 3).ToString();
            }
            else
            {
                txt_precioVenta.Text = "";
            }
        }

        private void txt_porcentajeiva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_porcentajeiva_TextChanged(object sender, EventArgs e)
        {
            if (txt_costo.Text != "" && txt_porcentajeiva.Text != "")
            {
                txt_precioVenta.Text = (Convert.ToDouble(txt_costo.Text) * 3).ToString();
            }
            else
            {
                txt_precioVenta.Text = "";
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                INTEGRAL.Close();
                INTEGRAL.Open();

                comando = new SqlCommand("actualizarproductos", INTEGRAL);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codigoproductooriginal", codigooriginal);
                comando.Parameters.AddWithValue("@codigoproducto", txt_codigo.Text);
                comando.Parameters.AddWithValue("@nombreProducto", txt_nombre.Text);
                comando.Parameters.AddWithValue("@descripcionproducto", txt_descripcion.Text);
                comando.Parameters.AddWithValue("@costoestandarproducto", txt_costo.Text);
                comando.Parameters.AddWithValue("@preciosinivaproducto", txt_siniva.Text);
                comando.Parameters.AddWithValue("@preciodeventaproducto", txt_precioVenta.Text);
                comando.Parameters.AddWithValue("@codigoalternoproducto", txt_codigoalterno.Text);
                comando.Parameters.AddWithValue("@nombrealternoproducto", txt_nombrealterno.Text);
                comando.Parameters.AddWithValue("@descripcioncorta", txt_descripcioncorta.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto actualizado correctamente", "Producto modificado");
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.ToString());
            }
            
        }

        private void cmb_tienda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
