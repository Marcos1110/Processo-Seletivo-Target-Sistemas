using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeqDeFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de Variáveis

            //Início

            int numEscolhido       = 0;
            int primeiroValor      = 0;
            int segundoValor       = 1;
            int valorAuxiliar      = 0;
            Boolean statusPesquisa = false;
            
            //Fim

            Console.WriteLine("Sequência de Fibonacci");
            Console.WriteLine("");

            Console.WriteLine("O objetivo desse programa é verificar se determinado número" +
                "se faz presenta na sequência de Fibonacci.");
            Console.Write("Insira aqui o número que deseja pesquisar = ");
            numEscolhido = int.Parse(Console.ReadLine());

            while (primeiroValor < numEscolhido)
            {
                valorAuxiliar = primeiroValor;
                primeiroValor = segundoValor;
                segundoValor += valorAuxiliar;
                if(primeiroValor == numEscolhido)
                {
                    statusPesquisa = true;
                }
            }

            if (statusPesquisa)
            {
                Console.WriteLine("O número [" + numEscolhido + "] está presente na sequência de Fibonacci.");
            } else
            {
                Console.WriteLine("O número [" + numEscolhido + "] não está presente na sequência de Fibonacci.");
            }

            Console.ReadKey();
        }
    }
}
