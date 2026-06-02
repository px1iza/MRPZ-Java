using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Введіть розмір списку: ");
        int size = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();

        Console.WriteLine("Введіть елементи списку:");

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Елемент {i + 1}: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        Console.Write("Введіть N (кількість позицій для зсуву вправо): ");
        int n = int.Parse(Console.ReadLine());

        n %= numbers.Count;

        for (int i = 0; i < n; i++)
        {
            int last = numbers[numbers.Count - 1];
            numbers.RemoveAt(numbers.Count - 1);
            numbers.Insert(0, last);
        }

        Console.WriteLine("\nСписок після циклічного зсуву вправо:");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}