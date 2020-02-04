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
        private void swipeControlLeft(object sender, EventArgs e) {
            labelEvento.Text ="HICISTE SWIPE A LA IZQUIERDA";
        }
        private void swipeControlRight(object sender, EventArgs e)
        {
            labelEvento.Text = "HICISTE SWIPE A LA DERECHA";
        }
        private void tapControl(object sender, EventArgs e)
        {
            labelEvento.Text = "HICISTE TAP";
        }
        private void pinchControl(object sender, EventArgs e)
        {
            labelEvento.Text = "HICISTE PINCH";
        }
    }
}