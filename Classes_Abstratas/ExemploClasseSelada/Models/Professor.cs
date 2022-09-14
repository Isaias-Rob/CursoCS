using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploClasseSelada.Models
{
    public class Professor: Pessoa
    {
        public double Salario { get; set; }
        public void MostraSalario(){
            Console.WriteLine($"O salário do professor {Nome} é de {Salario}.");
        }

        public sealed override void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e meu salário é de {Salario}.");
        }
    }
}