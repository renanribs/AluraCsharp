using System;
using Aula2;
using Aula2.operacoes;
class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Construindo uma calculadora");
        Console.WriteLine();

        Operacoes operacoes = new Operacoes();

        var numeroUm = 10;
        var numeroDois = 2;

        Console.WriteLine($"Soma: {operacoes.Soma.Calcular(numeroUm, numeroDois)}");
        Console.WriteLine($"Subtracao: {operacoes.Subtracao.Calcular(numeroUm, numeroDois)}");
        Console.WriteLine($"Multiplicacao: {operacoes.Multiplicacao.Calcular(numeroUm, numeroDois)}");
        Console.WriteLine($"Divisao: {operacoes.Divisao.Calcular(numeroUm, numeroDois)}");




        Console.WriteLine("Tecle enter para fechar....");
        Console.ReadLine();
    }
}