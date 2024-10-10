using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices;
using System.IO;

namespace dotnetcoresample.Pages;

public class PageUnknownModel : PageModel
{
    Random random = new Random();
    string path = "../../AzureOpnieuw/Data/";

    public string GiveQuote(){
        string[] Quotes = System.IO.File.ReadAllLines(path + "superemotioneel.txt");
        return Quotes[random.Next(0, 99)];
    }
    
    private readonly ILogger<PageUnknownModel> _logger;

    public PageUnknownModel(ILogger<PageUnknownModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {        
    }
}
