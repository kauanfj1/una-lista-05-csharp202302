using System;

class Atividades_04
{
    static void Main()
    {
        char[] caracteres = new char[10];
        int contConsoantes = 0;
        string consoantes = "";

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite o " + (i+1) + "º figura: ");
            caracteres[i] = Convert.ToChar(Console.ReadLine());

            if (!"aeiou".Contains(char.ToLower(caracteres[i])))
            {
                contConsoantes++;
                consoantes += caracteres[i] + " ";
            }
        }

        Console.WriteLine("\nNúmero de consoantes lidas: " + contConsoantes);
        Console.WriteLine("As consoantes lidas foram: " + consoantes);
    }
}

