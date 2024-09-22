using Microsoft.AspNetCore.Mvc;
using iPhoneStoreWebAppMVC.Models;

namespace iPhoneStoreWebAppMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var iPhones = new List<iPhone>
        {
            new (1, "iPhone 16",  "Latest iPhone model", 999.99m, "/images/iphone16.jpg"),
            new(2, "iPhone 15", "Previous generation iPhone", 799.99m, "/images/iphone15.jpg")
        };
        return View(iPhones);
    }
}
