// See https://aka.ms/new-console-template for more information

using ExemploEncapsulamento.Models;

Retangulo r1 = new Retangulo(); 
Retangulo r2 = new Retangulo();
r1.DefinirMedidas(30,30);
r2.DefinirMedidas(-1,-5);
System.Console.WriteLine($"Area 1: {r1.ObterArea()}\nArea 2: {r2.ObterArea()}");
