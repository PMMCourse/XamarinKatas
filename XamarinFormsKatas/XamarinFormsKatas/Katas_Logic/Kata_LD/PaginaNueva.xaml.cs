using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaNueva : ContentPage
    {
        public PaginaNueva(string texto)
        {
            InitializeComponent();
            string txt = texto;
            BindingContext = new PaginaNuevaViewModel(txt);
        }
    }
}