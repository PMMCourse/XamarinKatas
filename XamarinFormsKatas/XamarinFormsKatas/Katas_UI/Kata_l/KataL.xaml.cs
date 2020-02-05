using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_l
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataL : ContentPage
	{
		public KataL ()
		{
			InitializeComponent ();
		}

		private void swiped_left(object sender, EventArgs e)
		{
			nameLabel.Text = "Izquierda";
		}
		private void swiped_right(object sender, EventArgs e)
		{
			nameLabel.Text = "Derecha";
		}
		private void tapPrincipal(object sender, EventArgs e)
		{
			nameLabel.Text = "Tap";
		}
		private void pinchPrincipal(object sender, EventArgs e)
		{
			nameLabel.Text = "Pinch";
		}
	}
}