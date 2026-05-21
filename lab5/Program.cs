using System;
class Program
{
    static void Main()
    {
        Payment payment = new Payment("PAY-1");

        payment.ShoppingCart.AddItem("Ноутбук");
        payment.ShoppingCart.AddItem("Мишка");
        payment.ShoppingCart.AddItem("Клавіатура");
        payment.ShoppingCart.AddItem("Чохол для телефону");

        payment.Amount = 2500;

        payment.ShowPaymentInfo();

        Console.WriteLine("\nПошук товару");

        Console.Write("\nВведіть слово для пошуку: ");

        string keyword = Console.ReadLine();

        payment.ShoppingCart.Search(keyword);
    }
}