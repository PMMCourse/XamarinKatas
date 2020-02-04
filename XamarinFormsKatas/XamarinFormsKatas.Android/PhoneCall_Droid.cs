using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinFormsKatas.Droid;
using XamarinFormsKatas.Katas_Logic.Kata_LI;
using Xamarin.Forms;
[assembly: Dependency(typeof(PhoneCall_Droid))]
namespace XamarinFormsKatas.Droid
{
    public class PhoneCall_Droid : IPhoneCall
    {
        [Obsolete]
        public void MakeCall(string number)
        {

            var uri = Android.Net.Uri.Parse("tel:" + number);
            Intent intent = new Intent(Intent.ActionCall, uri);

            Forms.Context.StartActivity(intent);

        }
    }

}