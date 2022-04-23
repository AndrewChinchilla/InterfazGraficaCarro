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
    public partial class FrmInicio : Form
    {
        Carro Carro1;
        public FrmInicio()
        {
            InitializeComponent();
        }
        private void CrearCarro()
        {
            string marca = textBoxMarca.Text;
            int modelo =int.Parse(textBoxModelo.Text);
            string color = textBoxColor.Text;
            int MaxVelocidad = int.Parse(textBoxVelocidadMax.Text);
            Carro1 = new Carro(marca, modelo, color, MaxVelocidad);


        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            CrearCarro();
            FrmCarro formulario = new FrmCarro(Carro1);
            formulario.Show();
        }
    }
}
