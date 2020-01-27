using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_UI.Kata_d;

namespace XamarinFormsKatas.Katas_UI.Kata_e
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataE : ContentPage
	{
		public KataE (Persona persona)
		{
			InitializeComponent ();
            BackgroundColor = Color.FromRgb(48, 63, 159);
            BindingContext = persona;
        }
	}
}