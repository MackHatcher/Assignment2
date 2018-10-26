using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_2.ActionFilters
{
    public class CrawlerActionFilter : ActionFilterAttribute
    {
        
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            if (HttpContext.Current.Request.Browser.Crawler)
            {
                return;
            }
        }
    }
}