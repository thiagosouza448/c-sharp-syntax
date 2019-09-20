using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {

        public static void Executar()
        {

            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada {0}", notaTruncada);
            Console.WriteLine($"A nota truncada é {notaTruncada}");



            Console.WriteLine("Digite sua idade?");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"idade inserida {idadeInteiro}");
            //or
            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Reesultado {0}", idadeInteiro);




            Console.WriteLine("Digite o primeiro número ??");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out  numero);
            Console.WriteLine($"Results 2  >>> {numero}");


            Console.WriteLine("Digite o segundo número número ??");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Results 2 >>> {numero2}");




        }

    }
}
