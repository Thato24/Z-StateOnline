using System.Web;
using System.Web.Mvc;

namespace Z_StateOnline.UIi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
