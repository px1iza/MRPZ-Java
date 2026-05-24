using System;
using System.Collections.Generic;

public class Payment
{
    public string PaymentId { get; set; }
    public decimal Amount { get; set; }


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
                if (item.ToLower().Contains(keyword.ToLower()))
                {
                    Console.WriteLine("- " + item);
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("Нічого не знайдено");
        }
    }
    public Cart ShoppingCart { get; set; }
    public Payment(string paymentId)
    {
        PaymentId = paymentId;
        ShoppingCart = new Cart();
    }

    public void ShowPaymentInfo()
    {
        Console.WriteLine($"ID платежу: {PaymentId}");
        Console.WriteLine($"Загальна сума: {Amount}");
        ShoppingCart.ShowItems();
    }
}