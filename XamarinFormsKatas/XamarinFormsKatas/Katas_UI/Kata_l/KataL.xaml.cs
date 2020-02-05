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
		public KataL()
		{
			InitializeComponent();

		}

		private void SwipeGestureRecognizer_Swiped_Left(object sender, SwipedEventArgs e)
		{
			info.Text = "Swipe Izquierda";
		}

		private void SwipeGestureRecognizer_Swiped_Right(object sender, SwipedEventArgs e)
		{
			info.Text = "Swipe Derecha";
		}

		private void PinchGestureRecognizer_PinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
		{
			info.Text = "Pinch";
		}

		private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
		{
			info.Text = "Dejar pulsado";
		}
	}
}