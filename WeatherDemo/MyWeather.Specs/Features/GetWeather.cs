using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace MyWeather.Specs
{
    [TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public partial class GettingTheWeatherForecastFeature
	{
		IApp app;
		Platform platform;

		public GettingTheWeatherForecastFeature(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);

			if (!FeatureContext.Current.ContainsKey("App"))
			{
				FeatureContext.Current.Add("App", app);
			}
		}
	}
}
