using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace calculoFaturamento
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valorDiaFaturamento = new double[] {
                22174.1664,
                24537.6698,
                26139.6134,
                0.0,
                0.0,
                26742.6612,
                0.0,
                42889.2258,
				46251.174,
				11191.4722,
				0.0,
				0.0,
				3847.4823,
				373.7838,
				2659.7563,
				48924.2448,
				18419.2614,
				0.0,
				0.0,
				35240.1826,
				43829.1667,
				18235.6852,
				4355.0662,
				13327.1025,
				0.0,
				0.0,
				25681.8318,
				1718.1221,
				13220.495,
				8414.61,
			};

			int diaFaturamento      = 0;
			double menorValorMensal = 0;
			double maiorValorMensal = 0;

			double mediaFaturamentoMensal = 0;
			double somaFaturamentoMensal  = 0;
			int contDiasFaturamento       = 0;

			int contFatDiaMaiorqMedia = 0;

			//Menor valor de faturamento ocorrido em um dia do mês

			menorValorMensal = valorDiaFaturamento[0];
			diaFaturamento = 1;
			for (int i = 1; i < valorDiaFaturamento.Length; i++)
            {
				if (menorValorMensal > valorDiaFaturamento[i] && valorDiaFaturamento[i] != 0)
                {
					menorValorMensal = valorDiaFaturamento[i];
					diaFaturamento = i + 1;
                }
            }

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine("Menor Valor de Faturamento Mensal = " + menorValorMensal + " | [Dia de Referência = " + diaFaturamento +" ]");
			Console.WriteLine(" ");

			//Maior valor de faturamento ocorrido em um dia do mês

			maiorValorMensal = valorDiaFaturamento[0];
			diaFaturamento = 1;
			for (int i = 1; i < valorDiaFaturamento.Length; i++)
			{
				if (maiorValorMensal < valorDiaFaturamento[i] && valorDiaFaturamento[i] != 0)
				{
					maiorValorMensal = valorDiaFaturamento[i];
					diaFaturamento = i + 1;
				}
			}

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine("Maior Valor de Faturamento Mensal = " + maiorValorMensal + " | [Dia de Referência = " + diaFaturamento + " ]");
			Console.WriteLine(" ");

			//Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

			for (int i = 0; i < valorDiaFaturamento.Length; i++)
            {
				if (valorDiaFaturamento[i] != 0)
				{
					somaFaturamentoMensal += valorDiaFaturamento[i];
					contDiasFaturamento++;
				}
            }

			mediaFaturamentoMensal = somaFaturamentoMensal / contDiasFaturamento;

			for (int i = 0; i < valorDiaFaturamento.Length; i++)
			{
				if (valorDiaFaturamento[i] > mediaFaturamentoMensal)
                {
					contFatDiaMaiorqMedia++;
                }
			}

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine("Média Mensal = " + mediaFaturamentoMensal);
			Console.WriteLine("Em " + contFatDiaMaiorqMedia + " dias o faturamento foi maior que a média mensal.");
			Console.WriteLine(" ");

			Console.ReadKey();
        }


    }
}

