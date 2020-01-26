using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_UI.Kata_b;
using XamarinFormsKatas.Katas_UI.Kata_c;

namespace XamarinFormsKatas.Katas.Kata1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Kata1View : ContentPage
	{
		public Kata1View ()
		{
			InitializeComponent ();
            ButB.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataB());
            };
            ButC.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new MasterDetailPage1());
            };
        }
    }
}