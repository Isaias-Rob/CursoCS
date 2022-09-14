using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploClasseAbstrata.Models
{
    public abstract class Conta
    {
        protected double saldo;

        public abstract void Creditar(double valor);

        public void ExibirSaldo(){
            System.Console.WriteLine($"Seu saldo é R${saldo}");
        }
    }
}