﻿using System.Web;
using System.Web.Mvc;

namespace Automated_Task_Standard_Operations
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}