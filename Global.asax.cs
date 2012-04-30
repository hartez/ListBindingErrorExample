using System;
using System.Web;
using FubuMVC.Core;
using FubuMVC.StructureMap;
using StructureMap;

namespace ListBindingErrorExample
{
	public class Global : HttpApplication
	{
		public static Container Container { get; private set; }

		protected void Application_Start(object sender, EventArgs e)
		{
			Container = new Container();

			FubuApplication.For<Registry>()
				.StructureMap(() => Container)
				.Bootstrap();
		}

		protected void Session_Start(object sender, EventArgs e)
		{
		}

		protected void Application_BeginRequest(object sender, EventArgs e)
		{
		}

		protected void Application_AuthenticateRequest(object sender, EventArgs e)
		{
		}

		protected void Application_Error(object sender, EventArgs e)
		{
		}

		protected void Session_End(object sender, EventArgs e)
		{
		}

		protected void Application_End(object sender, EventArgs e)
		{
		}
	}
}