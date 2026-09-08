class ProductOrder
{
    public string ProductName;
    public double UnitPrice;
    public int Quantity;
    public double DiscountPercent;
    public double ShippingFee;

    public ProductOrder(string productName, double unitPrice, int quantity,
                         double discountPercent, double shippingFee)
    {
        this.ProductName = productName;
        this.UnitPrice = unitPrice;
        this.Quantity = quantity;
        this.DiscountPercent = discountPercent;
        this.ShippingFee = shippingFee;
    }
     // Method to calculate the final amount after applying discount and adding shipping fee
        public double CalculateFinalAmount()
    {
        double subtotal = UnitPrice * Quantity;
        double discountAmount = subtotal * (DiscountPercent / 100);
        double finalAmount = subtotal - discountAmount + ShippingFee;
        return finalAmount;
    }
}