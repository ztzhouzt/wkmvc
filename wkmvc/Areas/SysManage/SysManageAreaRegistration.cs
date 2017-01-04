using System.Web.Mvc;

namespace wkmvc.Areas.SysManage
{
    /// <summary>
    /// 我们的后台
    /// </summary>
    public class SysManageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "SysManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "SysManage_default",
                "Sys/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[] { "WebPage.Areas.SysManage.Controllers" }
            );
        }
    }
}