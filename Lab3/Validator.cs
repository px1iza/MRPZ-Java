namespace Lab3
{
    static class Validator
    {
        public static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                try
                {
                    return int.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Помилка: введіть ціле число!");
                }
            }
        }

        public static double ReadDouble(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                try
                {
                    return double.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Помилка: введіть число!");
                }
            }
        }

        public static string ReadDate(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                try
                {
                    DateTime.Parse(input);
                    return input;
                }
                catch
                {
                    Console.WriteLine("Помилка: введіть коректну дату!");
                }
            }
        }

        public static string ReadTime(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                try
                {
                    TimeSpan.Parse(input);
                    return input;
                }
                catch
                {
                    Console.WriteLine("Помилка: час має бути у форматі HH:mm (наприклад 18:30)");
                }
            }
        }

        public static string ReadText(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                try
                {
                    if (string.IsNullOrWhiteSpace(input))
                        throw new Exception();

                    foreach (char c in input)
                    {
                        if (!char.IsLetter(c) && c != ' ')
                            throw new Exception();
                    }
                    return input;
                }
                catch
                {
                    Console.WriteLine("Помилка: дозволені тільки букви і пробіли!");
                }
            }
        }
    }
}