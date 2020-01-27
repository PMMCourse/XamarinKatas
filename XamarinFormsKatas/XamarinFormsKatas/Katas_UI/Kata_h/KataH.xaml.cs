using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_h
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KataH : ContentPage
    {
        public KataH()
        {
            InitializeComponent();

            Btnanimate.Clicked += async (sender, e) =>
            {

                await Btnanimate.TranslateTo(0, -80, 100);
                await Btnanimate.RotateTo(360, 2000);
                await Btnanimate.TranslateTo(0, 0, 100);

                Btnanimate.Rotation = 0;

                Btnanimate.TranslationX = 0;
            };
        }
    }
}