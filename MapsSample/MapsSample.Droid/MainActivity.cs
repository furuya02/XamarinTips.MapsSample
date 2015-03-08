using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace MapsSample.Droid {
    [Activity(Label = "MapsSample", Icon = "@drawable/icon", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            Forms.Init(this, bundle);
            Xamarin.FormsMaps.Init(this, bundle); //Maps初期化
            LoadApplication(new App());
        }
    }
}

