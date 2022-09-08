// See https://aka.ms/new-console-template for more information

using ExemploHeranca.Models;

Aluno a1 = new Aluno();
Professor p1 = new Professor();
p1.Nome = "Luigi";
p1.Idade = 35;
p1.Salario = 1590;

a1.Nome = "Mario";
a1.Idade = 22;
a1.Nota = 10;

p1.Apresentar();
p1.MostraSalario();

a1.Apresentar();
a1.MostraNota();

