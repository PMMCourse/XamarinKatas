using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_Logic.Kata_LF.ViewModel;

namespace XamarinFormsKatas.Katas_Logic.Kata_LF
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataLF : ContentPage
	{
		public KataLF ()
		{
			InitializeComponent ();
            BindingContext = new MainViewModel();
		}
	}
}