using EfSpeedrun.Data.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static BCrypt.Net.BCrypt;

namespace EfSpeedrun.Pages;

public class Login : PageModel
{
    private readonly UsersContext _context;

    public Login(UsersContext context)
    {
        _context = context;
    }

    public void OnGet()
    {
    }
    
    public IActionResult OnPost(string email, string password)
    {
        var passresult = _context.Users
            .Where(x => x.Email == email)
            .Select(x => x.Password)
            .First();

        var checkResult = Verify(password, passresult);

        if (checkResult)
        {
            Console.WriteLine("Login successful!");
            return RedirectToPage("/Success");
        }
        else
        {
            Console.WriteLine("Login failed!");
            return RedirectToPage("/Failure");
        }
    }
}