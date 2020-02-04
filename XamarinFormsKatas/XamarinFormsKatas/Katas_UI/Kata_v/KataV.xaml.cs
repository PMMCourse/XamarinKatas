using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_v
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataV : ContentPage
	{
		public KataV()
		{
			InitializeComponent();
			contenidoLabel.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
		}
	}
}