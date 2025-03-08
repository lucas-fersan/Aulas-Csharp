using System;

Console.WriteLine("Hello, World!");
Console.WriteLine("lucas\n");
Console.WriteLine("santana \n");

string nomeCompleto = "lucas fernandes santana";
string primeiroNome = "lucas";
string ultimoNome = "santana";
string nomeMeio = "fernandes santana";

Console.WriteLine("Meu nome é " + primeiroNome + nomeMeio + ultimoNome);

int idade = 19;

Console.WriteLine($"Meu nome é   {primeiroNome}  {nomeMeio} {ultimoNome} e minha idade é {idade}");
Console.WriteLine("Escreva o seu Nome  ");

string nome = Console.ReadLine();

Console.WriteLine($"Ola {nome}, Boa noite !");