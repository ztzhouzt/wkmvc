using System.Web.Mvc;

namespace wkmvc.Areas.ComManage
{
    /// <summary>
    /// 一些公用的控制器和视图，比如文件上传等
    /// </summary>
    public class ComManageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ComManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ComManage_default",
                "Com/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[] { "WebPage.Areas.ComManage.Controllers" }
            );
        }
    }
}