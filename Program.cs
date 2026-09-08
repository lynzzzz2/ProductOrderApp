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
        //output section
         double finalAmount = order.CalculateFinalAmount();

        Console.WriteLine();
        Console.WriteLine("----- PRODUCT ORDER -----");
        Console.WriteLine($"Product Name : {order.ProductName}");
        Console.WriteLine($"Unit Price   : {order.UnitPrice}");
        Console.WriteLine($"Quantity     : {order.Quantity}");
        Console.WriteLine($"Discount     : {order.DiscountPercent}%");
        Console.WriteLine($"Shipping Fee : {order.ShippingFee}");
        Console.WriteLine($"Final Amount : {finalAmount:F2}");
        Console.WriteLine("--------------------------");
    }
}