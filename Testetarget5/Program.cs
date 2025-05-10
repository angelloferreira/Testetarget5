using System;

class Program
{
    static void Main()
    {
        // String original
        string original = "TesteTarget";

        // Variável para armazenar a string invertida
        string invertida = "";

        // Percorre a string de trás para frente
        for (int i = original.Length - 1; i >= 0; i--)
        {
            invertida += original[i];
        }

        // Mostra o resultado
        Console.WriteLine($"String original: {original}");
        Console.WriteLine($"String invertida: {invertida}");
    }
}
