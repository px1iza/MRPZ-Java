namespace Lab3
{
    class Performance
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Theater { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public double AveragePrice { get; set; }
        public int ActorsCount { get; set; }

        public Performance(string name, string genre, string theater, string date, string time, double averagePrice, int actorsCount)
        {
            Name = name;
            Genre = genre;
            Theater = theater;
            Date = date;
            Time = time;
            AveragePrice = averagePrice;
            ActorsCount = actorsCount;
        }
        public Performance() { }
        public static void Print(Performance[] performances)
        {
            foreach (var p in performances)
            {
                Console.WriteLine($"{p.Name} | {p.Genre} | {p.Theater} | акторів: {p.ActorsCount}");

            }
        }
        public static void FindByActors(Performance[] arr, int actors)
        {
            bool found = false;
            foreach (var p in arr)
            {
                if (p != null && p.ActorsCount == actors)
                {
                    Console.WriteLine($"{p.Name} | {p.Genre} | {p.Theater} | акторів: {p.ActorsCount}");
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine("Нічого не знайдено");
        }

        public static void FindTheatersByNameAndDate(Performance[] arr, string name, string date)
        {
            bool found = false;

            foreach (var p in arr)
            {
                if (p != null && p.Name == name && p.Date == date)
                {
                    Console.WriteLine($"Театр: {p.Theater}");
                    found = true;
                }
            }
            if (!found)
                Console.WriteLine("Нічого не знайдено");
        }
    }
}