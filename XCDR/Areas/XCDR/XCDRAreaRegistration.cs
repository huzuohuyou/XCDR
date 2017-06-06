using System.Web.Mvc;

namespace XCDR.Areas.XCDR
{
    public class XCDRAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "XCDR";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "XCDR_default",
                "XCDR/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}