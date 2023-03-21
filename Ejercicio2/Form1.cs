using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    
    public partial class Form1 : Form
    {
        Persona miPersona = new Persona(0, "n/n", "n/n");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargarlbl();
            GboxInit();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            miPersona.CargarNombreApellido(txtNombre.Text, txtApellido.Text);
            MessageBox.Show("Bienvenido al Mundo " + miPersona.Nombre);
            LimpiarCampos();
            Cargarlbl();
            gbCrear.Enabled = false;
            GboxShow();
        }

        private void Cargarlbl()
        {
            lblNombre.Text = miPersona.Nombre;
            lblApellido.Text = miPersona.Apellido;
            
        }
        private void LimpiarCampos()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            lblApellido.Text = "n/n";
            lblNombre.Text = "n/n";
            lblPeso.Text = "0";
            lblYears.Text = "0";

        }
        private void GboxInit()
        {
            gbMorir.Enabled = false;
            gbPersona.Enabled = false;
        }
        private void GboxShow()
        {
            gbMorir.Enabled = true;
            gbPersona.Enabled = true;
        }

        private void btnMorir_Click(object sender, EventArgs e)
        {
            miPersona.Morir();
            LimpiarCampos();
            GboxInit();
            gbCrear.Enabled = true;
        }

        private void btnCreser_Click(object sender, EventArgs e)
        {
            miPersona.Creser(txtyears.Text);
            lblYears.Text = miPersona.Years.ToString();
            txtyears.Text = "";
            if (miPersona.Morir())
            {
                MessageBox.Show("Usted a Muerto por tantos A;os");
                LimpiarCampos();
                GboxInit();
                gbCrear.Enabled = true;
            }  
        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            miPersona.SubirPeso(txtPeso.Text);
            lblPeso.Text = miPersona.Peso.ToString();
            txtPeso.Text = "";
            if (miPersona.Morir())
            {
                MessageBox.Show("Usted a Muerto por tanto Peso");
                LimpiarCampos();
                GboxInit();
                gbCrear.Enabled = true;
            }
        }
    }
}
