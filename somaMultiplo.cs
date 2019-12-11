using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DeveresEAD
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Exercício 5: Faça um programa em C# para calcular a soma dos N primeiros múltiplos de um inteiro K, onde N e K são lidos e são números inteiros e positivos. 
             */
            int numero = int.Parse( Input("Insira o numero: ") );
            int qtd = int.Parse(Input("Insira a quantidade de numeros: "));
            Msg("Soma: "+numeroMultiplos(qtd, numero).Sum(o => o).ToString());
        }

        public static List<int> numeroMultiplos(int qtd, int numero)
        {
            List<int> numeros = new List<int>();
            for (int i = 1; i < numero && numeros.Count < qtd; i++)
            {
                if (numero % i == 0)
                    numeros.Add(i);
            }
            return numeros;
        }

        public static void Msg(string msg)
        {
            Console.WriteLine(msg);
        }
        public static string Input(string msg = null)
        {
            if (msg != null)
                Console.Write(msg);
            return Console.ReadLine();
        }
    }
}
