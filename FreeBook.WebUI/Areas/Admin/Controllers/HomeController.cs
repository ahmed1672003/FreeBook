namespace FreeBook.WebUI.Areas.Admin.Controllers;

[Area(nameof(Admin))]
[Route("[area]/[controller]/[action]")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
