namespace Lab3
{
    class Program
    {
        static void Main()
        {
            Performance[] performances = new Performance[5];

            Console.WriteLine("Введення даних про спектаклі");

            for (int i = 0; i < performances.Length; i++)
            {
                Performance p = new Performance();

                Console.WriteLine($"\nВведення #{i + 1}");

                p.Name = Validator.ReadText("Назва: ");
                p.Genre = Validator.ReadText("Жанр: ");
                p.Theater = Validator.ReadText("Театр: ");

                p.Date = Validator.ReadDate("Дата (YYYY-MM-DD): ");
                p.Time = Validator.ReadTime("Час (HH:mm): ");

                p.AveragePrice = Validator.ReadDouble("Середня ціна: ");
                p.ActorsCount = Validator.ReadInt("Кількість акторів: ");

                performances[i] = p;
            }

            Console.WriteLine("\nВсі спектаклі:");
            Performance.Print(performances);

            Console.WriteLine("\nПошук спектаклів за кількістю акторів:");
            int actors = Validator.ReadInt("Введіть кількість акторів: ");
            Performance.FindByActors(performances, actors);

            Console.WriteLine("\nПошук театрів за назвою і датою:");
            string name = Validator.ReadText("Назва спектаклю: ");
            string date = Validator.ReadDate("Дата (YYYY-MM-DD): ");

            Performance.FindTheatersByNameAndDate(performances, name, date);

            Console.WriteLine("\nПрограму завершено");
        }
    }
}