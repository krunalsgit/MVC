﻿using System.Web;
using System.Web.Mvc;

namespace Krunal_Dhote_Task1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
