using NUnit.Framework;
using System.Threading;
using Xamarin.UITest;

namespace Xamarin.Test
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
            Thread.Sleep(20000);
            app = AppInitializer.StartApp(platform);         
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
            app.Repl();
        }
    }
}
