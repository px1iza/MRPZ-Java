using System;
public class Payment
{
    public string PaymentId { get; set; }

    public decimal Amount { get; set; }

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
