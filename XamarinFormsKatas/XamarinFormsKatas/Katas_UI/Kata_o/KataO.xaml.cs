using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_o
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataO : ContentPage
	{
		public KataO ()
		{
			InitializeComponent ();
		}
		protected override bool OnBackButtonPressed() {
			Device.BeginInvokeOnMainThread(ShowDialog);
			return true;
		}

		private async void ShowDialog() {
			var dialog = await this.DisplayAlert("Exit", "Do you really want to exit?", "Yes", "No");

			if (dialog) {
				await this.Navigation.PopAsync();
			}
		}
	}
}