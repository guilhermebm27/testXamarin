using Xamarin.UITest;

namespace Xamarin.Test
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {

            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .InstalledApp("com.android.calculator2.Calculator")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                ///.AppBundle("../../../Todo.iOS/bin/iPhoneSimulator/Debug/TodoiOS.app")
                .StartApp();
        }
    }
}