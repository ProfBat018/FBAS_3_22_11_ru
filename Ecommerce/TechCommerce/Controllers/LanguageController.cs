using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace TechCommerce.Controllers;

public class LanguageController : Controller
{
    public IActionResult SetLanguage(string culture, string returnUrl)
    {
        // Устанавливаем куки с новой культурой
        Response.Cookies.Append(
            CookieRequestCultureProvider.DefaultCookieName,
            CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
            new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
        );

        return returnUrl == null ? LocalRedirect("/") : LocalRedirect(returnUrl);
    }
}