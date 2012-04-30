using FubuMVC.Core;
using FubuMVC.WebForms;

namespace ListBindingErrorExample
{
	public class Registry : FubuRegistry
	{
		public Registry()
		{
			IncludeDiagnostics(true);
			
			Actions
				.IncludeTypes(x => x.Name.EndsWith("Handler"));

			Routes
				.HomeIs<HomeHandler>(c => c.get_home())
				.IgnoreControllerNamesEntirely()
				.RootAtAssemblyNamespace();

			// Use the standard old ASP.NET webforms engine
			Import<WebFormsEngine>();

			Views.TryToAttachWithDefaultConventions();
		}
	}
}