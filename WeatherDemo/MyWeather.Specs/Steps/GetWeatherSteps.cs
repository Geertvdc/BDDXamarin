using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace MyWeather.BDD
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
			app.Tap(x => x.Marked("LocationEntry"));

			app.ClearText(x => x.Marked("LocationEntry"));
			app.EnterText(x => x.Marked("LocationEntry"), location);
		}

		[When(@"I set the Imperial switch to Off")]
		public void ISetTheImperialSwitchToOff()
		{
			app.Tap(x => x.Marked("ImperialSwitch"));
		}

		[When(@"I Set the Use GPS switch to On")]
		public void ISetTheGpsSwitchToOn()
		{
			app.Tap(x => x.Marked("GpsSwitch"));
		}

		[When("I press the Get Weather button")]
		public void IPressTheGetWeatherButton()
		{
			app.Tap(x => x.Marked("GetWeatherButton"));
		}

		[Then(@"the weather for ""(.*)"" should be shown in ""(.*)""")]
		public void TheWeatherForLocationShouldBeShownInFormat(string location, string format)
		{
			app.WaitForNoElement(x => x.Marked("ActivityIndicator"));
			var temperatureLabel = app.WaitForElement(x => x.Marked("TemperatureLabel"));

			var labelText = temperatureLabel[0].Text;
			Assert.IsNotNull(labelText);

			if (format.Equals("Celsius"))
			{
				Assert.AreEqual(labelText.Substring(labelText.Length - 1), "C");
			}
			else
			{
				Assert.AreEqual(labelText.Substring(labelText.Length - 1), "F");
			}
		}
	}
}
