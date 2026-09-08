using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Product Name: ");
        string productName = Console.ReadLine();

        Console.Write("Enter Unit Price: ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Discount Percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Shipping Fee: ");
        double shippingFee = Convert.ToDouble(Console.ReadLine());

        ProductOrder order = new ProductOrder(
            productName,
            unitPrice,
            quantity,
            discountPercent,
            shippingFee
        );
    }
}