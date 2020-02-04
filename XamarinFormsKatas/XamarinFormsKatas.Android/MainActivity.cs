using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace XamarinFormsKatas.Droid
{
    [Activity(Label = "XamarinFormsKatas", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        /*public override void onBackPressed()
        {
            AlertDialog.Builder mensaje = new AlertDialog.Builder(this);
            mensaje.SetTitle("¿Desea Salir de la Aplicacion?");
            mensaje.SetCancelable(false);
            mensaje.Show();
        }  */
    }
}