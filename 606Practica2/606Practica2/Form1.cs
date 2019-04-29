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
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Globalization;
using System.Data.OleDb;

namespace _606Practica2
{
    public partial class frmLogin : Form
    {
        SqlConnection INTEGRAL;
        public int usertype;
        public int userid;

        public frmLogin()
        {
            InitializeComponent();
            string connnectionString = ConfigurationManager.ConnectionStrings["PV606"].ConnectionString;
            INTEGRAL = new SqlConnection(connnectionString);
            try
            {
                INTEGRAL.Close();
                INTEGRAL.Open();
            }
            catch (Exception exe)
            {
                MessageBox.Show("Hubo un error al conectarse a la base de datos, intente mas tarde","Error al conectarse",MessageBoxButtons.OK,MessageBoxIcon.Error);
                MessageBox.Show(exe.ToString());
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_user.Text != "" && txt_password.Text != "")
                {
                    string consulta = "Select * from Users where UserName='" + txt_user.Text + "' and UserPassword='" + txt_password.Text + "'";
                    SqlCommand sql = new SqlCommand(consulta,INTEGRAL);
                    SqlDataReader dr = null;
                    if (sql.ExecuteScalar() != null)
                    {
                        dr = sql.ExecuteReader();
                        if(dr.Read())
                        {
                            userid = dr.GetInt32(0);
                            usertype = dr.GetInt32(3);
                            dr.Close();
                            MainMenu menu = new MainMenu();
                            menu.userid = userid;
                            menu.usertype = usertype;
                            menu.Show();
                            MessageBox.Show("Bienvenido: " + txt_user.Text);
                            
                        }
                        else
                        {
                            MessageBox.Show("Error inesperado");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecto", "Credenciales incorrectas");
                        txt_password.Clear();
                        txt_user.Clear();
                        txt_user.Focus();
                    }
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("Por favor llene todos los campos.","Llenar todos los campos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message,"Error");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente deseas salir del sistema?", "Salir del sistema", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { Application.Exit(); }
        }
    }
}
