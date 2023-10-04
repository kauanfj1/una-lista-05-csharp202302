using System;

class Atividade_01
{
    static void Main()
    {
        int[] numeros = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite o " + (i+1) + "º número: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nOs números digitados foram:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
