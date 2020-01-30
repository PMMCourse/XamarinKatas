using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas.Kata1 {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kata1View : ContentPage {
        public Kata1View() {
            InitializeComponent();
            Binding();
        }

        void Binding() {
            button_b.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_b.KataB());
            };
            button_c.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_c.KataC());
            };
            button_d.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_d.KataD());
            };
            button_e.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_e.KataE());
            };
            button_f.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_f.KataF());
            };
        }
    }
}