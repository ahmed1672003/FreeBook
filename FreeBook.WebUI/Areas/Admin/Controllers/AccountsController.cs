namespace FreeBook.WebUI.Areas.Admin.Controllers;

[Area(nameof(Admin))]
[Route("[area]/[controller]/[action]")]
public class AccountsController : Controller
{
    public IActionResult Login()
    {
        return View();
    }
}
