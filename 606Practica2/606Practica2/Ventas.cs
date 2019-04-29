using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace _606Practica2
{
    public partial class Ventas : Form
    {
        SqlCommand cmd;
        SqlConnection ConnectionString;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds=new DataSet();
        DataTable dt;

        public Ventas()
        {
            InitializeComponent();
            ConnectionString = new SqlConnection(ConfigurationManager.ConnectionStrings["PV606"].ConnectionString);
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            try
            {
                ConnectionString.Close();
                ConnectionString.Open();
                //da= new SqlDataAdapter("Select * from Productos", ConnectionString);
                //da.Fill(ds);
                //da = new SqlDataAdapter("Select * from Productos_detalle", ConnectionString);
                //da.Fill(ds);
                //dataGridView1.DataSource = ds.Tables[0];
                cmd = new SqlCommand("Select * from Productos where precioventa_producto>0", ConnectionString);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb_producto.Items.Add(dr["codigo_producto"].ToString());
                }
                dr.Close();
                //dataGridView1.DataSource = ds.Tables[1];
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.ToString());
            }
           
        }

        private void ckb_articuloapartado_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_articuloapartado.Checked)
            {
                panel_apartado.Visible = true;
            }
            else
            {
                panel_apartado.Visible = false;
            }
            
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            ConnectionString.Close();
            ConnectionString.Open();
            
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                MessageBox.Show("El precio del producto es $"+dr["precioventa_producto"].ToString());
            }
            else
            {
                MessageBox.Show("No se encuentra el producto");
            }
            dr.Close();
        }

        private void cmb_producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)13)
            {
                e.Handled=true;
                try
                {
                    if (ckb_codigoalterno.Checked)
                    {
                        buscarproductocodigoalterno();
                    }
                    else
                    {
                        buscarproducto();
                    }
                    cmb_producto.DroppedDown = true;
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.ToString());
                }
            }
        }

        private void buscarproducto()
        {
                ConnectionString.Close();
                ConnectionString.Open();
                cmd = new SqlCommand("Select codigo_producto from Productos", ConnectionString);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                DataView dataview1 = dt.DefaultView;
                dataview1.RowFilter = "codigo_producto like '%" + cmb_producto.Text+"%'";
                this.cmb_producto.Items.Clear();
                foreach (DataRowView dr in dataview1)
                {
                    this.cmb_producto.Items.Add(dr["codigo_producto"].ToString());
                }
        }

        private void buscarproductocodigoalterno()
        {
            ConnectionString.Close();
            ConnectionString.Open();
            cmd = new SqlCommand("Select codigoalterno_producto from Productos", ConnectionString);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            DataView dataview1 = dt.DefaultView;
            dataview1.RowFilter = "codigoalterno_producto like '%" + cmb_producto.Text + "%'";
            this.cmb_producto.Items.Clear();
            foreach (DataRowView dr in dataview1)
            {
                this.cmb_producto.Items.Add(dr["codigoalterno_producto"].ToString());
            }
        }

        private void datagridproductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cmb_producto.Text = datagridproductos.Rows[datagridproductos.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionString.Close();
                ConnectionString.Open();
                if (ckb_codigoalterno.Checked)
                {
                    da = new SqlDataAdapter("Select * from Productos where codigoalterno_producto like '%" + cmb_producto.Text + "%'", ConnectionString);
                }
                else
                {
                    da = new SqlDataAdapter("Select * from Productos where codigo_producto like '%" + cmb_producto.Text + "%'", ConnectionString);
                }
                   
                dt = new DataTable();
                //da.Fill(dt);
                da.Fill(ds);
               
                datagridproductos.DataSource = ds.Tables[0];
                datagridproductos.Visible = true;
                datagridventa.Visible = false;
                panel_apartado.Visible = false;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.ToString());
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string codigo=null;
            double precio = 0;
            double descuento = 0;
            try
            {
                ConnectionString.Close();
                ConnectionString.Open();
                if (ckb_codigoalterno.Checked)
                {
                    cmd = new SqlCommand("Select codigo_producto,preciosiniva_producto,descuento_producto from Productos inner join Productos_detalle on Productos.IdProducto=Productos_detalle.IdProducto and Productos.codigoalterno_producto='" + cmb_producto.Text + "'", ConnectionString);

                }
                else
                {
                    cmd = new SqlCommand("Select codigo_producto,preciosiniva_producto,descuento_producto from Productos inner join Productos_detalle on Productos.IdProducto=Productos_detalle.IdProducto and Productos.codigo_producto='" + cmb_producto.Text + "'", ConnectionString);

                }
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    codigo = dr["codigo_producto"].ToString();
                    precio = Convert.ToDouble(dr["preciosiniva_producto"].ToString());
                    descuento = Convert.ToDouble(dr["descuento_producto"].ToString());
                }
                dr.Close();
                cmd = new SqlCommand("insert into ventas_detalle_temporal values(" + txt_numeroventa.Text + ",'" + cmb_producto.Text + "','" + txt_cantidad.Text + "'," + precio + ",'" + ((precio * 3) - precio) + "','" + (precio * 0.1) + "','" + ((precio * 3) - (precio * 0.1)) + "','caja1')", ConnectionString);
                cmd.ExecuteNonQuery();
                dr.Close();
                datagridventa.Refresh();
                da = new SqlDataAdapter("Select * from ventas_detalle_temporal where folio=" + txt_numeroventa.Text, ConnectionString);
                dt = new DataTable();
                da.Fill(ds);
                datagridventa.DataSource = ds.Tables[0];
                datagridventa.Visible = true;
                datagridproductos.Visible = false;
                panel_apartado.Visible = false;
                MessageBox.Show("Venta guardado correctamente");
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.ToString());
            }
        }

        private void txt_numeroventa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
