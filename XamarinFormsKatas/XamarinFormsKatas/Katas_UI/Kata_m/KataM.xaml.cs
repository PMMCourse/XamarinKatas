using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_m
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataM : ContentPage
	{
		public KataM ()
		{
			InitializeComponent ();
            int cont = 1;
            BtnAdd.Clicked += (sender, e) =>
            {
                var label = new Label()
                {
                    Text = $"label {cont}",                                       
                };
                Sl.Children.Add(label);
                cont++;
            };
		}
	}
}