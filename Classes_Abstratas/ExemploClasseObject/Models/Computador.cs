using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploClasseObject.Models
{
    public class Computador // : System.Object oculto
    {
        public override string ToString() //sobrescrevendo metodo da classe System.Object
        {
            return "Sou uma classe computador "+base.ToString();
        }
    }
}