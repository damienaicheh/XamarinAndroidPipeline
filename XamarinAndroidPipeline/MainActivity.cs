using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;

namespace XamarinAndroidPipeline
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
        }
    }
}

