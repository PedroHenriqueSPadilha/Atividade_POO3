﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalCidades = 3;
            int cidadesAdicionais;

            do
            {
                double totalPopulacao = 0;
                double totalVacinados = 0;
                double totalNaoVacinados = 0;

                for (int i = 0; i < totalCidades; i++)
                {
                    Console.Write("Informe o nome do estado brasileiro: ");
                    string cidade = Console.ReadLine();

                    Console.Write("Informe a população: ");
                    double populacao = double.Parse(Console.ReadLine());

                    Console.Write("Informe a quantidade de pessoas vacinadas: ");
                    double vacinados = double.Parse(Console.ReadLine());

                    Console.Clear();

                    totalVacinados += vacinados;
                    totalNaoVacinados += populacao - vacinados;
                    totalPopulacao += populacao;
                }

                double porcentagemFaltamVacinar = (totalNaoVacinados / totalPopulacao) * 100;

                Console.WriteLine($"Total de pessoas que ainda falta vacinar: {totalNaoVacinados}");
                Console.WriteLine($"Porcentagem de pessoas que ainda falta vacinar: {porcentagemFaltamVacinar}%");

                Console.WriteLine("Deseja adicionar mais três estados? (Digite 1 para sim ou 0 para não):");
                cidadesAdicionais = int.Parse(Console.ReadLine());
                Console.Clear();

            } while (cidadesAdicionais == 1);

            Console.ReadKey();
        }
    }
}
