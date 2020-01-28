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
        private void SwipeGestureRecognizer_Swiped_Left(object sender, SwipedEventArgs e)
        {
            label.Text = "Izquierda";
        }

        private void SwipeGestureRecognizer_Swiped_Right(object sender, SwipedEventArgs e)
        {
            label.Text = "Derecha";

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            label.Text = "Tap";
        }

        private void PinchGestureRecognizer_PinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        {
            label.Text = "Pinch";
        }
    }
}