using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_p
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataP : ContentPage
	{
		public KataP ()
		{
			InitializeComponent ();
		}
		private async void pulseAndActivate(object sender, EventArgs e)
		{
			buttonActivate.IsEnabled = false;
			activity1.IsEnabled = true;
			activity1.IsRunning = true;
			activity1.IsVisible = true;
			await Task.Delay(5);
			activity1.IsEnabled = false;
			activity1.IsEnabled = false;
			activity1.IsEnabled = false;
			buttonActivate.IsEnabled = true;

		}
	}
}