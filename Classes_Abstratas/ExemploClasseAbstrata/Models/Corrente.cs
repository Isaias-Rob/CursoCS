using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploClasseAbstrata.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            base.saldo = valor; //this tambem funcionaria, porem base diz respeito da classe mãe
        }
    }
}