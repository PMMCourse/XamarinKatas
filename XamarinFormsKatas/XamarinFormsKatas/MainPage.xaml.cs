using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas.Kata1;
using XamarinFormsKatas.Katas_UI.Kata_d;

namespace XamarinFormsKatas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ButtonInicio.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Kata1View());
            };
        }
        /*protected override void OnAppearing()
        {
            List<Persona> LPersona = new List<Persona>();
            LPersona.Add(new Persona() { Nombre = "Paco", Edad = "25" });
            LPersona.Add(new Persona() { Nombre = "Ale", Edad = "24" });
            LPersona.Add(new Persona() { Nombre = "Dani", Edad = "23" });
            LPersona.Add(new Persona() { Nombre = "Manolo", Edad = "22" });

            ListOfPerson.ItemSource = LPersona;

            base.OnAppearing();
        }*/

        
    }
}