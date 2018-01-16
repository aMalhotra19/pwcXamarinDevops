using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void ShouldAddInputsToValidResults()
        {
            app.EnterText("txtEntryA", "10");
            app.EnterText("txtEntryB", "10");

            app.Tap("btnCalculate");

            var outputResult = app.Query("txtOutput").First(result => result.Text == "100");

            Assert.NotNull(outputResult, "Invalid output result");
        }
    }
}
