using React;
using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.V8;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(reactTest3.ReactConfig), "Configure")]

namespace reactTest3
{
	public static class ReactConfig
	{
		public static void Configure()
		{
			JsEngineSwitcher.Current.DefaultEngineName = V8JsEngine.EngineName;
			JsEngineSwitcher.Current.EngineFactories.AddV8();
          
            ReactSiteConfiguration.Configuration
                .AddScript("~/Scripts/Tutorial.jsx");

          
        }
	}
}




