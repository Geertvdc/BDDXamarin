using System;

using TechTalk.SpecFlow;

namespace MyWeather.Specifications
{
	[Binding]
	public class ForecastSteps
	{
		readonly IApp app;

		public ForecastSteps()
		{
			app = FeatureContext.Current.Get<IApp>("App");
		}

		[Given(@"I opened the app")]
		public void IOpenedTheApp()
		{
		}

		[When(@"I have entered ""(.*)"" as the location")]
		public void GiveInIHaveEnteredAStringAsALocation(string location)
		{
			app.Tap(x => x.Id("LocationEntry"));
			app.ClearText(x => x.Id("LocationEntry"));
			app.EnterText(x => x.Id("LocationEntry"), location);

		}

		[When(@"I set the Imperial switch to Off")]
		public void ISetTheImperialSwitchToOff()
		{
		}

		[When(@"I Set the Use GPS switch to On")]
		public void ISetTheGpsSwitchToOn()
		{
		}

		[When("I press the Get Weather button")]
		public void IPressTheGetWeatherButton()
		{
		}

		[Then(@"the weather for ""(.*)"" should be shown in ""(.*)""")]
		public void TheWeatherForLocationShouldBeShownInFormat(string location, string format)
		{

		}
	}
}
