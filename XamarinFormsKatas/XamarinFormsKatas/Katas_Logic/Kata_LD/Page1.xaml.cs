using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage {
        public Page1(string str) {
            InitializeComponent();
            string Text = str;
            BindingContext = new ViewModelPage1(Text);
        }
    }
}