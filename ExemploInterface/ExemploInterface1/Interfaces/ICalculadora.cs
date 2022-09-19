using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploInterface1.Interfaces
{
    public interface ICalculadora //usar I de interface = boas praticas :)
    {
        int Somar(int num1, int num2); // na interface por padrao sao publicos
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2){
            return num1 * num2;
        }
        int Dividir(int num1, int num2){
            return num1 / num2;
        }

    }
}