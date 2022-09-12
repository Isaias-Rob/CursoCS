// See https://aka.ms/new-console-template for more information
using ExemploPolimorfismo.Models;

//Este exemplo trata-se do polimorfismo em tempo de execução.

Aluno a1 = new Aluno();
a1.Nome = "Mario";
a1.Idade = 16;
a1.Nota = 10;
a1.Apresentar();
Professor p1 = new Professor();
p1.Nome = "Luigi";
p1.Idade = 27;
p1.Salario = 5000;
p1.Apresentar();