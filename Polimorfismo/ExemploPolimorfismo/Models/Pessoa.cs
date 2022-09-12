using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPolimorfismo.Models
{
    public class Pessoa
    {
        public string Nome {get; set; }
        public int Idade {get; set; }

        public virtual void Apresentar() //pode ser sobrescrito
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}