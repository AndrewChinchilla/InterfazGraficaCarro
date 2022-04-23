using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazGraficaCarro.Clases;

namespace InterfazGraficaCarro
{
    public partial class FrmCarro : Form
    {
       public  Carro carrito { get; set; }
        public FrmCarro(Carro _tpmCarro)
        {
            InitializeComponent();
            carrito = _tpmCarro;
            labelDatosCarro.Text = $"MARCA:  {carrito.Marca}  MODELO: {carrito.Modelo}  COLOR:  {carrito.Color}  MAX VELOCIDAD:  {carrito.MAXVELOCIDAD}";
           // carrito = new Carro("HONDA", 2020, "AZUL", 180);

        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
            LabelEncender.Text = carrito.EncenderMotor();
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            labelAcelerar.Text = carrito.acelerar();
        }

        private void buttonDesacelerar_Click(object sender, EventArgs e)
        {
            LabelDesacelerar.Text = carrito.Desacelerar();
        }

        private void buttonFRENONORMAL_Click(object sender, EventArgs e)
        {
            labelFrenoNormal.Text = carrito.FrenadoNormal();
            labelVelActual1.Text = carrito.GetVelocidadActual();
        }

        private void buttonFrenoTotal_Click(object sender, EventArgs e)
        {
            labelFrenoTotal.Text = carrito.Frenado_total();
            labelVelactual2.Text = carrito.GetVelocidadActual();
        }

        private void buttonClaxon_Click(object sender, EventArgs e)
        {
            labelClaxon.Text = carrito.Claxón();

        }

        private void buttonApagarMotor_Click(object sender, EventArgs e)
        {
            LabelEncender.Text = carrito.ApagarMotor();
        }

        private void buttonRADIO_Click(object sender, EventArgs e)
        {
            FrmRadioMp3 formulario = new FrmRadioMp3();
            formulario.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
