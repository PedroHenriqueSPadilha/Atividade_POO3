using System;

class Program
{
    struct Pessoa
    {
        public string nome;
        public double peso;
        public double altura;
        public double imc;
    }

    static double CalcularIMC(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    static void Main(string[] args)
    {
        Pessoa pessoa;
        int obesos = 0, abaixos = 0, acimas = 0, normais = 0;
        double imcSoma = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.Write($"Digite o nome {i+1}: ");
            pessoa.nome = Console.ReadLine();

            Console.Write($"Digite a altura: ");
            pessoa.altura = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Digite o peso: ");
            pessoa.peso = Convert.ToDouble(Console.ReadLine());

            pessoa.imc = CalcularIMC(pessoa.peso, pessoa.altura);

            imcSoma += pessoa.imc;

            if (pessoa.imc < 18.5)
                abaixos++;

            if (pessoa.imc > 18.5 && pessoa.imc < 24.9)
                normais++;

            if (pessoa.imc > 25 && pessoa.imc < 39.9)
                acimas++;

            if (pessoa.imc > 40)
                obesos++;

            Console.WriteLine();
        }

        Console.Clear() ;

        Console.WriteLine($"Abaixo Do Peso: {abaixos}");
        Console.WriteLine($"Normal: {normais}");
        Console.WriteLine($"Acima do Peso: {acimas}");
        Console.WriteLine($"Obesos:{obesos}");
    }
}