using System;

class Atividades_05
{
    static void Main()
    {
        int[] numeros = new int[20];
        int[] pares = new int[10];
        int[] impares = new int[10];
        int contPar = 0, contImpar = 0;

        for (int i = 0; i < 20; i++)
        {
            Console.Write("Digite o " + (i+1) + "º número: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());

            if (numeros[i] % 2 == 0)
            {
                pares[contPar] = numeros[i];
                contPar++;
            }
            else
            {
                impares[contImpar] = numeros[i];
                contImpar++;
            }
        }

        Console.WriteLine("\nOs números digitados foram:");
        Imprimir(numeros);

        Console.WriteLine("\nOs números pares são:");
        Imprimir(pares);

        Console.WriteLine("\nOs números ímpares são:");
        Imprimir(impares);
    }

    static void Imprimir(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] != 0)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}