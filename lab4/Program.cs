using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputPath = "/Users/elizavetarabirokh/IdeaProjects/MRPZ-Java/lab4/Test.txt";

        string outputPath = "/Users/elizavetarabirokh/IdeaProjects/MRPZ-Java/lab4/Result.txt";

        try
        {
            Console.WriteLine("\n ВІДКРИТТЯ ФАЙЛУ ");

            string code = File.ReadAllText(inputPath);
            Console.WriteLine("Файл успішно прочитано.");

            Console.WriteLine("\nПОЧАТОК ОБРОБКИ");

            string[] patterns =
            {
                @"for\s*\([^)]*\)\s*\{[^{}]*\}",
                @"while\s*\([^)]*\)\s*\{[^{}]*\}",
                @"do\s*\{[^{}]*\}\s*while\s*\([^)]*\)\s*;"
            };

            foreach (var pattern in patterns)
            {
                code = RemoveLoops(code, pattern);
            }

            Console.WriteLine("\nЗАПИС РЕЗУЛЬТАТУ");

            File.WriteAllText(outputPath, code);

            Console.WriteLine("Результат успішно записано у файл!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }
    }

    static string RemoveLoops(string text, string pattern)
    {
        var matches = Regex.Matches(text, pattern, RegexOptions.Singleline);
        foreach (Match m in matches)
        {
            Console.WriteLine("\nЗнайдено цикл:");
            Console.WriteLine(m.Value);
            Console.WriteLine("Видалено");
        }
        return Regex.Replace(text, pattern, "");
    }
}