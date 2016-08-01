using System;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using DE.Robv.Android.Xposed;
using DE.Robv.Android.Xposed.Callbacks;
using Java.Interop;
using Java.Lang;

namespace XposedTest
{
    [Activity(Label = "XposedTest", MainLauncher = true, Icon = "@drawable/ic_launcher")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate
            {
                var str = string.Format("{0} clicks!", count++);
                button.Text = str;
                XposedBridge.Log("MainActivity:  " + str);
            };

            XposedBridge.Log("OnCreate");

        }
    }

    [Register("xposedTest/XposedTest/Tutorial")]
    public class Tutorial : Java.Lang.Object, IXposedHookLoadPackage
    {
        public void HandleLoadPackage(XC_LoadPackage.LoadPackageParam lpparam)
        {
            XposedBridge.Log("Loaded app: " + lpparam.PackageName);
        }
     }
}