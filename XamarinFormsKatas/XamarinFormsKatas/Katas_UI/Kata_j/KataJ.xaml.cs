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
		public KataJ ()
		{
			InitializeComponent ();
		}

		private void btLogin_Clicked(object sender, EventArgs e)
		{
			var usuario = boxUser.Text;
			var contra = boxPass.Text;

			if (string.IsNullOrEmpty(usuario))
			{
				this.boxUser.BackgroundColor = Color.Red;
				this.texto.Text = "Rellene todos los campos";

			}
			if (string.IsNullOrEmpty(contra))
			{
				this.boxPass.BackgroundColor = Color.Red;
				this.texto.Text = "Rellene todos los campos";
			}
			else
			{
				this.boxUser.BackgroundColor = Color.Green;
				this.boxPass.BackgroundColor = Color.Green;

			}
		}
	}
}