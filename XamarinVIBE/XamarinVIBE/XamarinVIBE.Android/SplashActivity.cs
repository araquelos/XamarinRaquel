using Android.App;
using Android.Content.PM;
using Android.OS;

namespace XamarinVIBE.Droid
{
    [Activity(Theme = "@style/MainTheme.Splash", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            Finish();

            // Disable activity slide-in animation
            OverridePendingTransition(0, 0);
        }
    }
}