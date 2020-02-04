using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_c
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KataCMaster : ContentPage
    {
        public ListView ListView;

        public KataCMaster()
        {
            InitializeComponent();

        }

        private async void btnVent1_Clicked(object sender, EventArgs e)
        {
            App.MasterC.IsPresented = false; //para que se cierre el menú lateral al abrir una ventana
            await App.MasterC.Detail.Navigation.PushAsync(new Ventana1());
        }

        private async void btnVent2_Clicked(object sender, EventArgs e)
        {
            App.MasterC.IsPresented = false; 
            await App.MasterC.Detail.Navigation.PushAsync(new Ventana2());
        }

        private async void btnVent3_Clicked(object sender, EventArgs e)
        {
            App.MasterC.IsPresented = false;
            await App.MasterC.Detail.Navigation.PushAsync(new Ventana3());
        }
    }
}