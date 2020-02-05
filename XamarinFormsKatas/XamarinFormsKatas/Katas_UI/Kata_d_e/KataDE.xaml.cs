using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_d_e
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KataDE : ContentPage
    {
        public KataDE()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaPersona persona = new ListaPersona();
            Lista.ItemsSource = persona._personas;
        }

        /*
        private async void Lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var imagen = e.SelectedItem as persona;
                await DisplayAlert("Listas", imagen. ,"Aceptar");
            }
        }
        */
    }
}