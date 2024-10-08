using Microsoft.AspNetCore.Mvc;
using iPhoneStoreWebAppMVC.Data;
using Microsoft.EntityFrameworkCore;

namespace iPhoneStoreWebAppMVC.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var products = await _context.Products.FromSqlRaw("SELECT * FROM Products").ToListAsync();
        return View(products);
    }
}
