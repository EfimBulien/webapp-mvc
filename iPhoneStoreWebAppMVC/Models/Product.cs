namespace iPhoneStoreWebAppMVC.Models;

public class Product
{
    public int IDProduct { get; set; }
    public int CategoryID { get; set; }
    public string Brand { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public decimal ProductPrice { get; set; }
    public string ProductImage { get; set; }
    public int ProductCount { get; set; }

    public Category Category { get; set; } 
}
