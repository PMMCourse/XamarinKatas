using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_q
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataQ : ContentPage
	{
		public KataQ ()
		{
			InitializeComponent ();
            //SE ELIMINA EL BORDE PERO TIENE QUE CLICKAR PORQUE SINO NO SE VE EL ENTRY AL
            // NO TENER BORDE
        }
    }
}