﻿using System;
using Android.App;
using Android.Runtime;

namespace ShinyTest.Droid
{
	[Application]
	public class MainApplication : Application
	{
		public MainApplication(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer) { }

		public override void OnCreate()
		{
			this.ShinyOnCreate(new Startup());
			global::Xamarin.Essentials.Platform.Init(this);
			base.OnCreate();
		}
	}
}
