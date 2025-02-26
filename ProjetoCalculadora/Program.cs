



using System;

Console.WriteLine("Projeto Calculadora Matheus e João");


Console.WriteLine("Escreva o primeiro número");
decimal primeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Escreva o segundo numero");
decimal segundoNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a operação desejada: 1=> soma 2=> subtração 3=> multiplicação 4=> divisão ");
int operacao = Convert.ToInt32(Console.ReadLine());


if (operacao == 1) { Console.WriteLine($"O Resultado de {primeiroNumero} + {segundoNumero} é igual a: {primeiroNumero + segundoNumero}"); }
if (operacao == 2) { Console.WriteLine($"O Resultado de {primeiroNumero} - {segundoNumero} é igual a: {primeiroNumero - segundoNumero}"); }
if (operacao == 3){Console.WriteLine($"O resutlado da operação é {primeiroNumero * segundoNumero}");}
if (operacao == 4){Console.WriteLine($"O resutlado da operação é {primeiroNumero / segundoNumero}");}


