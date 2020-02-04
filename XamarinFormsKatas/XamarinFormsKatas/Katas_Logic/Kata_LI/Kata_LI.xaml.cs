using Android.Content;
using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Android.Provider.Telephony.Mms;
using static XamarinFormsKatas.Katas_Logic.Kata_LI.Kata_LI;

namespace XamarinFormsKatas.Katas_Logic.Kata_LI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kata_LI : ContentPage
    {
        public Kata_LI()
        {
            InitializeComponent();
            llamar.Clicked += MakeCall;

        }
        private void MakeCall(object sender, EventArgs e)
        {
            DependencyService.Get<IPhoneCall>().MakeCall(telefono.Text.ToString());
        }
    }
}
