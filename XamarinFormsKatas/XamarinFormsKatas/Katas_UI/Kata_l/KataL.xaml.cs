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
        private void swipeLeft(object sender,EventArgs e)
        {
            Evento.Text = "swipe a la izquierda";
        }
        private void SwipeRight(object sender, EventArgs e)
        {
            Evento.Text = "swipe a la derecha";
        }
        private void ControlTap(object sender, EventArgs e)
        {
            Evento.Text = "TAP";
        }
        private void ControlPinch(object sender, EventArgs e)
        {
            Evento.Text = "PINCH";
        }
    }
}