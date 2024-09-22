namespace iPhoneStoreWebAppMVC.Models;

public class iPhone(int id, string name, string description, decimal price, string imageUrl)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public decimal Price { get; set; } = price;
    public string ImageUrl { get; set; } = imageUrl;
}
