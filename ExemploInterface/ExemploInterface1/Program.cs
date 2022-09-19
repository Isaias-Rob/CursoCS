// See https://aka.ms/new-console-template for more information

using ExemploInterface1.Interfaces;
using ExemploInterface1.Models;

//ICalculadora calc = new ICalculadora();//errado
ICalculadora calc = new Calculadora(); //correto
System.Console.WriteLine(calc.Dividir(1,2)); //inteiro ira retornar truncado
System.Console.WriteLine(calc.Multiplicar(1,2));
