using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MTK.JanitorHelper.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : JanitorHelperControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}