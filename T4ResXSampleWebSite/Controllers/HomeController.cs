using System.Web.Mvc;

namespace T4ResX.Sample.WebSite.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        public ActionResult Index()
        {
            return View(new BLL.Models.User());
        }

        /// <summary>
        /// 
        /// </summary>
        [HttpPost]
        public ActionResult Index(BLL.Models.User user)
        {
            if (ModelState.IsValid)
            {
                ModelState.AddModelError("PseudoOk", T4ResX.Sample.Localization.Models.User.PseudoOk);
            }

            return View(user);
        }

        /// <summary>
        /// 
        /// </summary>
        public ActionResult GetNameSpaceAsJs(string ns)
        {
            return JavaScript(string.Format("var T4ResX = {{ Localization: {0}}};", T4ResX.Sample.Localization.Utilities.GetResourcesByNameSpace(ns).ToJson()));
        }

        /// <summary>
        /// 
        /// </summary>
        public ActionResult GetNameSpaceAsJson(string ns)
        {
            return Json(T4ResX.Sample.Localization.Utilities.GetResourcesByNameSpace(ns), JsonRequestBehavior.AllowGet);
        }
    }
}