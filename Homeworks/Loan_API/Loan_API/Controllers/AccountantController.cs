using Microsoft.AspNetCore.Mvc;

namespace Loan_API.Controllers
{

    public class AccountantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
