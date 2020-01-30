using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_j
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KataJ : ContentPage
    {
        public KataJ()
        {
            InitializeComponent();
            bool denegado = false;
            login.Clicked += (sender, e) =>
            {
                if((entrada2.Text==null|| entrada2.Text == "") && denegado == false)
                {
                    Entry entrada = new RoundedEntrada();
                    stack1.Children.Remove(entrada2);
                    stack1.Children.Add(entrada1);
                    denegado = true;
                    var label = new Label()
                    {
                        Text = "Ha salido un ERROR"
                    };
                stack1.Children.Add(label);
                }
            };
           
        }
    }  
}