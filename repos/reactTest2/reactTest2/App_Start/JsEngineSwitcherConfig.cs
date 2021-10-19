using JavaScriptEngineSwitcher.ChakraCore;
using JavaScriptEngineSwitcher.Core;
using JavaScriptEngineSwitcher.Msie;
using JavaScriptEngineSwitcher.V8;

namespace JavaScriptEngineSwitcher.Sample.AspNet45.Mvc5
{
    public class JsEngineSwitcherConfig
	{
		public static void Configure(IJsEngineSwitcher engineSwitcher)
		{
			engineSwitcher.EngineFactories
				.AddChakraCore()
				.AddMsie(new MsieSettings
				{
					EngineMode = JsEngineMode.ChakraIeJsRt
				})
				
			
				.AddV8()
				;

			engineSwitcher.DefaultEngineName = ChakraCoreJsEngine.EngineName;
		}
	}
}