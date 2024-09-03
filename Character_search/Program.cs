using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase:");
        string a = Console.ReadLine();

        int x = 0;

        foreach (char c in a)
        {

            if (c == 'a' || c == 'A')
            {
                x++;
            }
        }

        if (x == 0)
        {
            Console.WriteLine("A letra 'a' não aparece na frase.");
        }
        else
        {
            Console.WriteLine($"A letra 'a' aparece {x} vezes na frase.");
        }
    }
}