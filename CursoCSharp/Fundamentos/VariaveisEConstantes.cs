using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area de  circuferencia 
            double raio = 4.5;
            const double PI = 3.14;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);



            //Booleanos
            bool estaChovendo = true;
            Console.WriteLine("Esta chovendo " + estaChovendo);


            //byte ( so aceita valores positivos ) ;
            byte idade = 26;
            Console.WriteLine("idade " +  idade);

            //sbyte pode ter valor negativo (de -128 a + 127)
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols " + saldoDeGols);

            //short
            short salario = short.MaxValue;
            Console.WriteLine("salario "+ salario);


            //int
            int menorValorInt = int.MinValue;  //mais usados dos inteiros  
            Console.WriteLine("Menor Valor" + menorValorInt);

            //uint  
            uint populacaoBrasileira = 20_600__000;
            Console.WriteLine("Popoulacao Brasileira " + populacaoBrasileira);
           
            //LONG 
            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor Long " + menorValorLong);

            //ulong 
            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial " + populacaoMundial);


            //float
            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador  "+precoComputador);

            //double
            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor de mercado da apple " + valorDeMercadoDaApple);

            //decimal
            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas " + distanciaEntreAsEstrelas);

            //char
            char letra = 'a';
            Console.WriteLine("Letra >> " +  letra);

            //string
            string texto = "Seja bem vindo ";
            Console.WriteLine(texto);
        }

    }
}
