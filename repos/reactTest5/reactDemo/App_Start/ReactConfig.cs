using React;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(reactDemo.ReactConfig), "Configure")]

namespace reactDemo
{
	public static class ReactConfig
	{
		public static void Configure()
		{
			ReactSiteConfiguration.Configuration
				.AddScript("~/Scripts/react/app.js");
		}
	}
}