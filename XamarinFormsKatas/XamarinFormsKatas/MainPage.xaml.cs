using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas.Kata1;


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

        
    }
}