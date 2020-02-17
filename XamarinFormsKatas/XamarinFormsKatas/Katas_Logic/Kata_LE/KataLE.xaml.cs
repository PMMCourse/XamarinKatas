using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_Logic.Kata_LA;

namespace XamarinFormsKatas.Katas_Logic.Kata_LE
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataLE : ContentPage
	{
		public KataLE ()
		{
			InitializeComponent ();
			BindingContext = new KataLeViewModel();
		}

		private void ColorTextChanged(object sender, TextChangedEventArgs e)
		{
			(BindingContext as KataLeViewModel).BlendColorsCommand.Execute(null);
		}
	}
}