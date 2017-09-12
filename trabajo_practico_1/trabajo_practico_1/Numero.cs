using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_practico_1
{
    class Numero
    {

        double numero;

        // getter de numero
        public double getNumero()
        {
            return this.numero;
        }

        // inicializador default
        public Numero()
        {
            this.numero = 0;
        }

        // inicializador con un numero en formato double
        public Numero(double numero)
        {
            this.numero = numero;
        }

        // inicializador con un numero en formato string
        public Numero(string numero)
        {
            this.setNumero(numero);
        }

        // setter de numero con string
        private void setNumero(string numero)
        {
            this.numero = this.validarNumero(numero);
        }

        // validacion del numero string, si es invalido devolvemos 0
        private double validarNumero(string numeroString)
        {
            double numero = 0;
            double.TryParse(numeroString, out numero);

            return numero;
        }

    }
}
