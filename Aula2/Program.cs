using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Estudo de variaveis.");
        int idade = 7;

      
            if (idade < 18)
            {
                Console.WriteLine("Você tem menos que 18 anos");
                Console.WriteLine("Adicionando idade");
            for (int i = 0; idade < 19; i++)
            {
               
                Console.WriteLine($"Idade atual: {idade}");
                ++idade;
            }

            } 
            if (idade > 18)
            {
                Console.WriteLine("Voce ja possui mais de 18 anos");
                
            }
        




        Console.WriteLine("Tecle enter para fechar....");
        Console.ReadLine();
    }
}