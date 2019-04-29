using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _606Practica2
{
    public partial class MainMenu : Form
    {
        public int userid =0;
        public int usertype =0;

        public MainMenu()
        {
            InitializeComponent();
        }

        //public MainMenu(int userid, int usertype)
        //{
        //    InitializeComponent();
        //    this.userid = userid;
        //    this.usertype = usertype;
        //}

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (usertype>1)
            {
                utilidadesToolStripMenuItem.Visible = false;
                if(usertype > 2)
                {
                    reportesToolStripMenuItem.Visible = false;
                }
            }
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos prodalta = new Productos();
            prodalta.btn_guardar.Visible = true;
            prodalta.btn_limpiar.Visible = true;
            prodalta.btn_eliminar.Visible = false;
            prodalta.btn_modificar.Visible = false;
            prodalta.btn_buscar.Visible = false;
            prodalta.btn_eliminarError.Visible = false;
            prodalta.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente quieres salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { Close(); }
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos prodalta = new Productos();
            prodalta.btn_guardar.Visible = false;
            prodalta.btn_limpiar.Visible = false;
            prodalta.btn_eliminar.Visible = true;
            prodalta.btn_modificar.Visible = false;
            prodalta.btn_buscar.Visible = true;
            prodalta.btn_eliminarError.Visible = true;
            prodalta.Show();
        }

        private void modificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos prodalta = new Productos();
            prodalta.btn_guardar.Visible = false;
            prodalta.btn_limpiar.Visible = false;
            prodalta.btn_eliminar.Visible = false;
            prodalta.btn_modificar.Visible = true;
            prodalta.btn_buscar.Visible = true;
            prodalta.btn_eliminarError.Visible = false;
            prodalta.Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
        }
    }
}
