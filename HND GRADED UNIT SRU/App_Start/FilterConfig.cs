using System.Web;
using System.Web.Mvc;

namespace HND_GRADED_UNIT_SRU
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
