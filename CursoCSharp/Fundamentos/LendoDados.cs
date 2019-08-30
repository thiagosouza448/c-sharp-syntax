using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("{0}, Você tem {1} Anos! \n pode Dirigir!!!!", nome, idade);
            }
            else
            {
                Console.WriteLine("{0}, você tem {1} e Não pode dirigir", nome, idade);
            }


        }


    }
}
