using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blogsite.Pages;

public class ExampleModel: PageModel
{
    public string Name {get; set;} = "Alice" ;
    public void OnGet ()
    {
        ViewData["Date"] = DateTime.Today.ToString("ddd, MM yyyy");
    }

    public IActionResult OnPost ()
    {
        return Page();
    }
}