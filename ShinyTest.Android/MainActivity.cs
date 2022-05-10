﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

using Xamarin.Forms;

using Shiny;
using Android.Content;

namespace ShinyTest.Droid
{
    [Activity(Label = "ShinyTest", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
		protected override void OnCreate(Bundle savedInstanceState)
		{
			this.ShinyOnCreate();
			base.OnCreate(savedInstanceState);
			Forms.Init(this, savedInstanceState);
			this.LoadApplication(new App());
		}


		protected override void OnResume()
		{
			base.OnResume();
			Xamarin.Essentials.Platform.OnResume(this);
		}


		protected override void OnNewIntent(Intent intent)
		{
			base.OnNewIntent(intent);
			this.ShinyOnNewIntent(intent);
			Xamarin.Essentials.Platform.OnNewIntent(intent);
		}


		protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
		{
			base.OnActivityResult(requestCode, resultCode, data);
			this.ShinyOnActivityResult(requestCode, resultCode, data);
		}


		public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
		{
			base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
			this.ShinyOnRequestPermissionsResult(requestCode, permissions, grantResults);
			Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
		}
	}
}
