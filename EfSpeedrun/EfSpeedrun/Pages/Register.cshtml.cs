using EfSpeedrun.Data.Contexts;
using EfSpeedrun.Data.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static BCrypt.Net.BCrypt;

namespace EfSpeedrun.Pages;

public class Register : PageModel
{
    private readonly UsersContext _context;

    public Register(UsersContext context)
    {
        _context = context;
    }

    public void OnGet()
    {
        
    }

    public void OnPost(string email, string password, string confirm)
    {
        if (password != confirm)
        {
            throw new Exception("Passwords do not match!");
        }
        
        User user = new()
        {
            Email = email,
            Password = HashPassword(password)
        };
        
        _context.Users.Add(user);
        _context.SaveChanges();
    }
}