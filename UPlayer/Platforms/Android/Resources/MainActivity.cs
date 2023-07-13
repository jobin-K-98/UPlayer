[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Set the color of the status bar
        Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#262626"));

        // Set the color of icons in the status bar to white
        if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
        {
            Window.DecorView.SystemUiVisibility = (StatusBarVisibility)(SystemUiFlags.LightStatusBar);
        }
    }
}
