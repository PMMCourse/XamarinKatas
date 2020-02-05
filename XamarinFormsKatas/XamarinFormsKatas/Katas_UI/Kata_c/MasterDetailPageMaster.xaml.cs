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
    public partial class MasterDetailPageMaster : ContentPage
    {
        public MasterDetailPageMaster()
        {
            InitializeComponent();
        }

        //Esto lo he visto en un tutorial de un indio Chema no me agredas
        private async void buttonView1(object sender, EventArgs e)
        {
            App.MasterDetail.IsPresented = false;
            await App.MasterDetail.MasterDetailPageDetail.Navigation.PushAsync(new View1());
        }
        private async void buttonView2()
        {
            App.MasterDetail.IsPresented = false;
            await App.MasterDetail.MasterDetailPageDetail.Navigation.PushAsync(new View2());
        }
        private async void buttonView3()
        {
            App.MasterDetail.IsPresented = false;
            await App.MasterDetail.MasterDetailPageDetail.Navigation.PushAsync(new View3());
        }
        
    }
}
    