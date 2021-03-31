using System;
using System.Collections.Generic;

namespace paradigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cenario01 = { 3, 2, 1, 6, 0, 5 };
            int[] cenario02 = { 7, 5, 13, 9, 1, 6, 4 };

            processarCenario("Cenário 1", cenario01);
            System.Console.WriteLine();
            processarCenario("Cenário 2", cenario02);
        }

        static public void processarCenario(String cenario, int[] array)
        {
            var raizDoCenario = int.MinValue;
            var indiceDaRaiz = -1;

            List<int> galhosDaEsquerda = new List<int>();
            List<int> galhosDaDireita = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > raizDoCenario)
                {
                    raizDoCenario = array[i];
                    indiceDaRaiz = i;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (i < indiceDaRaiz)
                {
                    galhosDaEsquerda.Add(array[i]);
                }

                if (i > indiceDaRaiz)
                {
                    galhosDaDireita.Add(array[i]);
                }
            }

            galhosDaEsquerda.Sort();
            galhosDaEsquerda.Reverse();
            galhosDaDireita.Sort();
            galhosDaDireita.Reverse();

            Console.WriteLine(cenario);
            Console.WriteLine($"Array de entrada: [{string.Join(",", array)}]");
            Console.WriteLine($"Raiz: {raizDoCenario}");
            Console.WriteLine($"Galhos da esquerda: [{string.Join(", ", galhosDaEsquerda.ToArray())}]");
            Console.WriteLine($"Galhos da direita: [{string.Join(", ", galhosDaDireita.ToArray())}]");
        }
    }
}
