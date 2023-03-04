using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcDistribuidora
{
    class Program
    {
        static void Main(string[] args)
        {
            double fatSaoPaulo      = 67836.43;
            double fatRioDeJaneiro  = 36678.66;
            double fatMinasGerais   = 29229.88;
            double fatEspiritoSanto = 27165.48;
            double fatOutrosEstados = 19849.53;

            double somaFaturamento = 0;

            double pcFatSP     = 0;
            double pcFatRJ     = 0;
            double pcFatMG     = 0;
            double pcFatES     = 0;
            double pcFatOutros = 0;

            somaFaturamento = fatSaoPaulo + fatRioDeJaneiro + 
                fatMinasGerais + fatEspiritoSanto + fatOutrosEstados;

            pcFatSP     = (fatSaoPaulo      / somaFaturamento) * 100;
            pcFatRJ     = (fatRioDeJaneiro  / somaFaturamento) * 100;
            pcFatMG     = (fatMinasGerais   / somaFaturamento) * 100;
            pcFatES     = (fatEspiritoSanto / somaFaturamento) * 100;
            pcFatOutros = (fatOutrosEstados / somaFaturamento) * 100;

            Console.WriteLine("== Relatório de Faturamento Mensal (Por Estado) ==");
            Console.WriteLine("");
            Console.WriteLine("São Paulo");
            Console.WriteLine("Faturamento = " + fatSaoPaulo.ToString("C"));
            Console.WriteLine("Percentual de Participação = " + pcFatSP.ToString("F") + "%");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Rio de Janeiro");
            Console.WriteLine("Faturamento = " + fatRioDeJaneiro.ToString("C"));
            Console.WriteLine("Percentual de Participação = " + pcFatRJ.ToString("F") + "%");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Minas GErais");
            Console.WriteLine("Faturamento = " + fatMinasGerais.ToString("C"));
            Console.WriteLine("Percentual de Participação = " + pcFatMG.ToString("F") + "%");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Espirito Santo");
            Console.WriteLine("Faturamento = " + fatEspiritoSanto.ToString("C"));
            Console.WriteLine("Percentual de Participação = " + pcFatES.ToString("F") + "%");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Demais Estados");
            Console.WriteLine("Faturamento = " + fatOutrosEstados.ToString("C"));
            Console.WriteLine("Percentual de Participação = " + pcFatOutros.ToString("F") + "%");
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();
        }
    }
}
