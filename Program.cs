using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк в массиве: ");
        int n = int.Parse(Console.ReadLine());

        string[] inputArray = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите строку #{i + 1}: ");
            inputArray[i] = Console.ReadLine();
        }

        string[] resultArray = FilterShortStrings(inputArray);

        Console.WriteLine("\nИсходный массив строк:");
        foreach (string str in inputArray)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("\nНовый массив строк (длина <= 3 символов):");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterShortStrings(string[] inputArray)
    {
       
        return Array.FindAll(inputArray, str => str.Length <= 3);
    }
}
