using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploInterface1.Interfaces;

namespace ExemploInterface1.Models
{
    public class Calculadora : Interfaces.ICalculadora
    {
        /*public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }*/ 
        
        //_____________so sou obrigado a sobrescrever o metodo quando não ha implementacao pela interface (salvo se eu queira modificar a implementacao)________________

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar(int num1, int num2){
            return num1 + num2;
        }
        public int Somar(int num1, int num2, int num3){
            return num1 + num2 + num3;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}