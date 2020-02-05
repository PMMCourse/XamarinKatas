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

    
        private void PinchGestureRecognizer_PinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        {
            labelControl.Text = "Has hecho pinch!";
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            labelControl.Text = "Has hecho doble-tap!";
        }

        private void Swiped_L(object sender, SwipedEventArgs e)
        {
            labelControl.Text = "Has hecho swipe a la izquierda!";
        }

        private void Swiped_R(object sender, SwipedEventArgs e)
        {
            labelControl.Text = "Has hecho swipe a la derecha!";
        }

    }
}
