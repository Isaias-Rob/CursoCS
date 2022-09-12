// See https://aka.ms/new-console-template for more information
using ExemploPolimorfismo_2.Models;

Calculadora calc = new Calculadora();
System.Console.WriteLine("Resultado soma 2+2: "+calc.Somar(2,2));
System.Console.WriteLine("Resultado soma 2+1+3: "+calc.Somar(2,1,3));