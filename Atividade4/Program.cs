using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Atividade4
    {
    internal class Program
    {
        static void Main(string[] args)
        {
            int obesos = 0, normais = 0, abaixo = 0, acimaPeso = 0;
            float[] p = new float[5];
            float[] a = new float[5];
            float[] imc = new float[5];
            string[] nome = new string[5];


            for (int i = 0; i < 5; i++) {

                Console.Clear();

                Console.Write("Digite o nome: ");
                nome[i] = Console.ReadLine();

                Console.Write("Digite sua altura: ");
                a[i] = float.Parse(Console.ReadLine());

                Console.Write("Digite seu Peso: ");
                p[i] = float.Parse(Console.ReadLine());

                imc[i] = p[i] / (a[i] * a[i]);
            }

            Console.Clear();

            for(int i = 0;i < 5; i++)
            {
                if (imc[i] < 18.5) {

                    abaixo++;
                }
                if (imc[i] > 18.5 && imc[i] < 24.9){

                    normais++;
                }
                if (imc[i] > 25.00 && imc[i] < 39.9){

                    acimaPeso++;
                }
                if (imc[i] > 40) {

                    obesos++;
                }

                Console.WriteLine(nome[i]);
                Console.WriteLine($"Seu Imc é: {imc[i].ToString("00.0")}");
                Console.WriteLine();
            }

            Console.WriteLine($"Número de pessoas abaixo do peso: {abaixo}");
            Console.WriteLine($"Número de pessoas com peso normal: {normais}");
            Console.WriteLine($"Número de pessoas acima do peso: {acimaPeso}");
            Console.WriteLine($"Número de pessoas obesas: {obesos}");
            Console.WriteLine("");
        }

    }
    }
