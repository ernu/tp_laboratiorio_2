using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo_practico_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // limpiamos todos los campos
        private void limpiar(object sender, EventArgs e)
        {
            this.lblResultado.Text = "Resultado:";
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperacion.Text = "";
        }

        // realizamos la operacion con los campos dados
        // llamamos al metodo estatico operar que realiza la operacion y
        // devuelve un double y lo convertimos a string
        private void operar(object sender, EventArgs e)
        {
            this.lblResultado.Text = "Resultado: "
                + Calculadora.operar(new Numero(this.txtNumero1.Text)
                , new Numero(this.txtNumero2.Text)
                , this.cmbOperacion.Text).ToString();
        }
    }
}
