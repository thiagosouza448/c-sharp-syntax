using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritimeticos
    {
        public static void Executar()
        {

            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1; //10% de desconto

            double total = preco + imposto;
            var totalDesconto = total - (total * desconto); //valor total - ( valor total * desconto) = desconto de 10%
            Console.WriteLine($"O preço final é : {totalDesconto}" );


            double peso = 64.5;
            double altura = 1.84;
            double imc = peso / Math.Pow(altura,2); 
            Console.WriteLine($"Seu imc é {imc}" );


            var par = 24;
            var impar = 55;
            Console.WriteLine("{0}/2 tem o resto {1}", par, par % 2   );
            Console.WriteLine("{0}/ 2 tem o resto {1}",impar, impar % 2);


        }


    }
}
