using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_Logic.Kata_LH.ViewModel;

namespace XamarinFormsKatas.Katas_Logic.Kata_LH
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataLH : ContentPage
	{
		public KataLH ()
		{
			InitializeComponent ();
            BindingContext = new MainViewModel(Navigation);
		}
	}
}