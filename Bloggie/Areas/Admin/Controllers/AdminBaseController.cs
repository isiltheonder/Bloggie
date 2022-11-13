using Microsoft.AspNetCore.Mvc;

namespace Bloggie.Areas.Admin.Controllers
{
    [Authorize(Roles = "Administrator")]
    [Area("Admin")]
    public abstract class AdminBaseController : Controller
    {
        
    }
}
