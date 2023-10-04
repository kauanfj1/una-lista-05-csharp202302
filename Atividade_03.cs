using System;

class Atividades_03
{
    static void Main()
    {
        double[] notas = new double[4];
        double soma = 0;
        for (int i = 0; i < 4; i++)
        {
            Console.Write("Digite a " + (i+1) + "ª nota: ");
            notas[i] = Convert.ToDouble(Console.ReadLine());
            soma += notas[i];
        }

        Console.WriteLine("\nAs notas digitadas foram:");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(notas[i]);
        }

        double media = soma / 4;
        Console.WriteLine("\nA média das notas é: " + media);
    }
}
