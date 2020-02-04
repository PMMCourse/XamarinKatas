using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_m {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KataM : ContentPage {
        public KataM() {
            InitializeComponent();
            buttonAdd.Clicked += (sender, e) => {
                var label = new Label() {
                    Text = "Nuevo label",
                };
                StackLabel.Children.Add(label);
            };
        }
    }
}