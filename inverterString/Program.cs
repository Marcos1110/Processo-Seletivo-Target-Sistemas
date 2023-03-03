using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inverterString
{
    class Program
    {
        static void Main(string[] args)
        {
            string txtEntrada = "";
            int contAuxiliar  = 0;

            Console.WriteLine("Insira uma cadeia de caracteres (palavra, frase, número, etc.)" +
                " que você deseja inverter");
            Console.Write("-> ");
            txtEntrada = Console.ReadLine();

            char [] vetorInversao = new char[txtEntrada.Length];
            contAuxiliar = txtEntrada.Length - 1;

            for (int i = 0; i < txtEntrada.Length; i++)
            {
                vetorInversao[i] = txtEntrada[contAuxiliar];
                contAuxiliar--;
            }

            Console.WriteLine("");

            Console.WriteLine("Cadeia de caracteres inserida  = " + txtEntrada);
            Console.Write("Cadeia de caracteres invertida = ");
            for (int j = 0; j < vetorInversao.Length; j++)
            {
                Console.Write(vetorInversao[j]);
            }

            Console.ReadKey();
        }
    }
}