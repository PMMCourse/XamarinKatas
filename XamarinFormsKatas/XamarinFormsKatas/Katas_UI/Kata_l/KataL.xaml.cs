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
        void accionRealizada(object sender, SwipedEventArgs e)
        {
            switch (e.Direction)//lo vi mejor que usar un if anidado
            {
                case SwipeDirection.Left:
                    labelAdivino.Text = "Izquierda";
                    break;//sorry :(
                case SwipeDirection.Right:
                    labelAdivino.Text = "Derecha";
                    break;//sorry :(
                case SwipeDirection.Up:
                    labelAdivino.Text = "Arriba";
                    break;//sorry :(
                case SwipeDirection.Down:
                    labelAdivino.Text = "Abajo";
                    break;//sorry :(
            }
        }
    }
}