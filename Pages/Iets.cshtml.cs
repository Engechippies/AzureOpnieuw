using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace dotnetcoresample.Pages;

public class IetsModel : PageModel
{
    Random random = new Random();
    string path = "Data\\";

    public string GiveQuote(){
        string[] Quotes = System.IO.File.ReadAllLines(path + "superemotioneel.txt");
        return Quotes[random.Next(0,99)];
    }
    
    private readonly ILogger<IetsModel> _logger;

    public IetsModel(ILogger<IetsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {        
    }
}
