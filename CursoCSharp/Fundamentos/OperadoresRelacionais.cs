﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {

        public static void Executar()
        {
            Console.Write("DIgite sua nota?");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;
            //Console.WriteLine($"Nota invalida ?{nota > 10}"); // forma diferente
            Console.WriteLine("Nota invalida? {0}", nota >10);
            Console.WriteLine("Nota invalida {0}", nota < 0);
            Console.WriteLine("Perfeito ? {0}", nota == 10);
            Console.WriteLine("Tem como melhorar {0}", nota != 10);
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recuperação ? {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);



        }
    }
}
