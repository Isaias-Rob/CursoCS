using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploEncapsulamento.Models
{
    public class Retangulo
    {
        private double comprimento, largura;
        private bool valido; //padrao false
        public void DefinirMedidas(double comprimento, double largura){
            if(comprimento > 0 && largura > 0){
                this.comprimento = comprimento;
                this.largura = largura;
                valido = true;
                System.Console.WriteLine("Valores Validos");
            }
            else{
                System.Console.WriteLine("Valores Invalidos");
            }
        }

        public double ObterArea(){
            return (valido) ? comprimento * largura : -1;
        }
    }
}