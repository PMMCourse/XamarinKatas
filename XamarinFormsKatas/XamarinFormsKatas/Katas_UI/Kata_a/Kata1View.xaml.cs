using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas.Kata1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Kata1View : ContentPage
	{
		public Kata1View ()
		{
			InitializeComponent ();
            Binding();
        }
        void Binding()
        {
            btn1.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_b.KataB());
            };
            btn2.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_c.MasterDetailPage1());
            };
            btn3.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_d.KataD());
            };
            btn4.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_g.KataG());
            };
            btn5.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_h.KataH());
            };
            btn6.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_i.KataI());
            };

        }
    }
}