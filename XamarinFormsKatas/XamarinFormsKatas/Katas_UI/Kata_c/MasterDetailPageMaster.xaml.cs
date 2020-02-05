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
        private void buttonView1(object sender, EventArgs e)
        {
            App.MasterDetail.IsPresented = false;
            await App.MasterDetail.MasterDetailPageDetail.Navigation.PushAsync(new View1());
        }
        private void buttonView2(object sender, EventArgs e)
        {
            App.MasterDetail.IsPresented = false;
            await App.MasterDetail.MasterDetailPageDetail.Navigation.PushAsync(new View2());
        }
        private void buttonView3(object sender, EventArgs e)
        {
            App.MasterDetail.IsPresented = false;
            await App.MasterDetail.MasterDetailPageDetail.Navigation.PushAsync(new View3());
        }        
    }
}
    