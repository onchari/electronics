using System.Web.Mvc;

namespace electronicshop.Areas.CustomerFrontEnd
{
    public class CustomerFrontEndAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CustomerFrontEnd";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "CustomerFrontEnd_default",
                "CustomerFrontEnd/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}