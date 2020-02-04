using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_w
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class elementoControles : ContentPage
    {
        public elementoControles(Entry entryControl, Label labelControl, Button buttonControl, ActivityIndicator activityControl)
        {
            InitializeComponent();
            contenedor.Children.Add(entryControl);
            contenedor.Children.Add(labelControl);
            contenedor.Children.Add(buttonControl);
            contenedor.Children.Add(activityControl);
        }
    }
}