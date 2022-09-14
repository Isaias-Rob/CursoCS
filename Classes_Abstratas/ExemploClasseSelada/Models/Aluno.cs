using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploClasseSelada.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }
        public void MostraNota(){
            Console.WriteLine($"A nota do aluno {Nome} foi de {Nota}.");
        }

        public override void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e minha nota é {Nota}.");
        }
    }
}