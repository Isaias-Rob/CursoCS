using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploHeranca.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }
        public void MostraNota()
        {
            Console.WriteLine($"A nota do aluno {Nome} foi de {Nota}.");
        }
    }
}