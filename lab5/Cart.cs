using System;
public class Cart : ISearchable
{
    private List<string> items = new List<string>();
    public void AddItem(string item)
    {
        items.Add(item);
    }

    public void ShowItems()
    {
        Console.WriteLine("\nТовари в кошику:");

        foreach (var item in items)
        {
            Console.WriteLine("- " + item);
        }
    }

    public void Search(string keyword)
    {
        bool found = false;

        Console.WriteLine($"\nРезультати пошуку для '{keyword}':");

        foreach (var item in items)
        {
            if (item.ToLower().Contains(keyword))
            {
                Console.WriteLine("- " + item);
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("Нічого не знайдено");
        }
    }
}