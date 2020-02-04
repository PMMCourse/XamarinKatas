using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_Logic.Kata_LG
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataLG : ContentPage
	{
		public KataLG ()
		{
			InitializeComponent ();
            BindingContext = new MainViewModel();
        }
	}
}