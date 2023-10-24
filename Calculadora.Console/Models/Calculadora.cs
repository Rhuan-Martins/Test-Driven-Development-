using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Console.Models
{
    public class CalculadoraC
    {
        private List<string> listahistorico;

        public CalculadoraC()
        {
            listahistorico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            int soma = num1 + num2;
            listahistorico.Insert(0, "Resto: " + soma);
            return soma;
        }

        public int Subtrair(int num1, int num2)
        {
            int subtrair = num1 - num2;
            listahistorico.Insert(0, "Resto: " + subtrair);
            return subtrair;
        }

        public int Multiplicar(int num1, int num2)
        {
            int mult = num1 * num2;
             listahistorico.Insert(0, "Resto: " + mult);
            return mult;
        }

        public int Dividir(int num1, int num2)
        {
            int div = num1 / num2;
            listahistorico.Insert(0, "Resto: " + div);
            return div;
        }

        public List<string> historico()
        {
            List<string> resto;
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return new List<string>(listahistorico);
        }

    }
}