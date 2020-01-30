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
    public partial class ShowPage : ContentPage
    {
        public ShowPage(Switch sentry, Switch slabel, Switch sbutton, Switch sactivityIndicator)
        {
            InitializeComponent();
            
            if (slabel.IsToggled == true)
            {
                Sl.Children.Add(new Label() { Text = "Label" });
            }
            if (sbutton.IsToggled == true)
            {
                Sl.Children.Add(new Button() { Text = "Button" });
            }
            if (sentry.IsToggled == true)
            {
                Sl.Children.Add(new Entry() { Placeholder = "Entry" });
            }
            if (sactivityIndicator.IsToggled == true)
            {
                Sl.Children.Add(new ActivityIndicator() { IsRunning = true });
            }
        }
    }
}