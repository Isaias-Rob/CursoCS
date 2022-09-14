using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploClasseSelada.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar() {
            Console.WriteLine($"Olá, meu nome é Diretor {Nome}, tenho {Idade} anos e meu salário é de {Salario}.");
        }
    }
}