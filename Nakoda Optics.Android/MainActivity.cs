﻿using System;
using System.IO;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace Nakoda_Optics.Droid
{
    [Activity(Label = "Nakoda_Optics", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            var dbname = "mydata.sqlite";
            var folderlocation = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            var fullpath = Path.Combine(folderlocation, dbname);

            LoadApplication(new App(fullpath));

           
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}