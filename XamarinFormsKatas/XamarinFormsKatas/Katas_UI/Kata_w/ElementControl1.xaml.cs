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
    public partial class ElementControl1 : ContentView
    {
        public ElementControl1(Entry EControl, Label LControl, Button BControl, ActivityIndicator AControl)
        {

            InitializeComponent();
            conten.Children.Add(EControl);
            conten.Children.Add(LControl);
            conten.Children.Add(BControl);
            conten.Children.Add(AControl);
        }

    }
}