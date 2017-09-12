using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_practico_1
{
    class Calculadora
    {

        // metodo estatico para la operacion que devuelve un double con el resultado
        // si se divide por 0, entonces devolvemos 0
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            switch (validarOperador(operador))
            {
                case "+":
                    return numero1.getNumero() + numero2.getNumero();
                case "-":
                    return numero1.getNumero() - numero2.getNumero();
                case "*":
                    return numero1.getNumero() * numero2.getNumero();
                case "/":
                    if (numero2.getNumero() != 0) return numero1.getNumero() / numero2.getNumero();
                    else return 0;
                default:
                    return 0;
            }
        }

        // validacion del operador, si es invalido entonces devolvemos +
        public static string validarOperador(string operador)
        {
            switch (operador)
            {
                case "-": return "-";
                case "*": return "*";
                case "/": return "/";
                default: return "+";
            }
        }

    }
}
