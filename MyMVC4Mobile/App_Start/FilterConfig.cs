﻿using System.Web;
using System.Web.Mvc;

namespace MyMVC4Mobile
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}