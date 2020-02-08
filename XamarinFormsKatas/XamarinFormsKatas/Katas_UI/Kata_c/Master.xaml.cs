using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_c
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }


        private async void Elme1_Clicked(object sender, EventArgs e)
        {
            App.MasterKataC.IsPresented = false;
            await App.MasterKataC.Detail.Navigation.PushAsync(new Elemento1());
        }

        private async void Elme2_Clicked(object sender, EventArgs e)
        {
            App.MasterKataC.IsPresented = false;
            await App.MasterKataC.Detail.Navigation.PushAsync(new Elemento2());
        }

        private async void Elem3_Clicked(object sender, EventArgs e)
        {
            App.MasterKataC.IsPresented = false;
            await App.MasterKataC.Detail.Navigation.PushAsync(new Elemento3());
        }
    }
}