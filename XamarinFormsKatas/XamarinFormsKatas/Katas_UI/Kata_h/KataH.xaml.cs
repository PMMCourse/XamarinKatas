using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_h {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KataH : ContentPage {
        public KataH() {
            InitializeComponent();
            Movimiento();
        }

        void Movimiento() {
            btnRotacion.Clicked += async (sender, e) => {
                await btnRotacion.TranslateTo(0, -100, 100);
                await btnRotacion.RotateTo(360, 1000);
                await btnRotacion.TranslateTo(0, 0, 100);
            };
        }
    }
}