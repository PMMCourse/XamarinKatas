using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_Logic.Kata_LC
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataLC : ContentPage
	{
		public KataLC ()
		{
			InitializeComponent ();
            BindingContext = new LCViewModel();
		}
	}
}