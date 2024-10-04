namespace iPhoneStoreWebAppMVC.Models;

public class Category
{
    public int IDCategory { get; set; }
    public string CategoryName { get; set; }

    public ICollection<Product> Products { get; set; }
}
