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
	public partial class KataLD : ContentPage
	{
		public KataLD ()
		{
			InitializeComponent ();
            BindingContext = new MainViewModel(Navigation);
		}
	}
}