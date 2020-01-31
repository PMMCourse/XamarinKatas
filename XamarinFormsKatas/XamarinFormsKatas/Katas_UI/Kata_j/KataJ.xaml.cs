using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_j
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataJ : ContentPage
	{
		public KataJ()
		{
			InitializeComponent();
			//Mira MiRender
		}

		private void Button_Clicked(object sender, EventArgs e)
		{

			if (!(String.IsNullOrEmpty(inputUsuario.Text)))
			{
				DisplayAlert("Login", "se logueo", "ok");
				labelError.IsVisible = false;
			}
			else
			{
				labelError.IsVisible = true;
			}
		}
	}
}