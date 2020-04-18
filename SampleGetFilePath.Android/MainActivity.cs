using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SampleGetFilePath.Droid
{
    [Activity(Label = "SampleGetFilePath", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            System.Console.WriteLine("Android.OS.Environment.DataDirectory=" + Android.OS.Environment.DataDirectory.AbsolutePath);
            System.Console.WriteLine("Android.OS.Environment.DirectoryAlarms=" + Android.OS.Environment.DirectoryAlarms);
            System.Console.WriteLine("Android.OS.Environment.DirectoryDcim=" + Android.OS.Environment.DirectoryDcim);
            System.Console.WriteLine("Android.OS.Environment.DirectoryDocuments=" + Android.OS.Environment.DirectoryDocuments);
            System.Console.WriteLine("Android.OS.Environment.DirectoryDownloads=" + Android.OS.Environment.DirectoryDownloads);
            System.Console.WriteLine("Android.OS.Environment.DirectoryMovies=" + Android.OS.Environment.DirectoryMovies);
            System.Console.WriteLine("Android.OS.Environment.DirectoryMusic=" + Android.OS.Environment.DirectoryMusic);
            System.Console.WriteLine("Android.OS.Environment.DirectoryNotifications=" + Android.OS.Environment.DirectoryNotifications);
            System.Console.WriteLine("Android.OS.Environment.DirectoryPictures=" + Android.OS.Environment.DirectoryPictures);
            System.Console.WriteLine("Android.OS.Environment.DirectoryPodcasts=" + Android.OS.Environment.DirectoryPodcasts);
            System.Console.WriteLine("Android.OS.Environment.DirectoryRingtones=" + Android.OS.Environment.DirectoryRingtones);
            System.Console.WriteLine("Android.OS.Environment.DownloadCacheDirectory=" + Android.OS.Environment.DownloadCacheDirectory.AbsolutePath);
            System.Console.WriteLine("Android.OS.Environment.ExternalStorageDirectory=" + Android.OS.Environment.ExternalStorageDirectory.AbsolutePath);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}