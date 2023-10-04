using System;

class Atividades_06
{
    static void Main()
    {
        double[] medias = new double[10];
        int contAlunos = 0;

        for (int i = 0; i < 10; i++)
        {
            double soma = 0;
            for (int j = 0; j < 4; j++)
            {
                Console.Write("Digite a " + (j+1) + "ª nota do " + (i+1) + "º aluno: ");
                soma += Convert.ToDouble(Console.ReadLine());
            }
            medias[i] = soma / 4;

            if (medias[i] >= 7.0)
            {
                contAlunos++;
            }
        }

        Console.WriteLine("\nO número de alunos com média maior ou igual a 7.0 é: " + contAlunos);
    }
}
