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
}