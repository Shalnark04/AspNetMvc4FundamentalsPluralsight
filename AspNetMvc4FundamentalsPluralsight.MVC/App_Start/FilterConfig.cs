using System.Web;
using System.Web.Mvc;

namespace AspNetMvc4FundamentalsPluralsight.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
