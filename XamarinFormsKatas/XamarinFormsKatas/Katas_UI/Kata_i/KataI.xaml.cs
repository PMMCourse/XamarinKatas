using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_i
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataI : ContentPage
	{
		public KataI ()
		{
			InitializeComponent ();

            entryPrincipal.TextChanged += CambiarPlaceHolder;
		}

        private void CambiarPlaceHolder(Object sender, EventArgs e)
        {
            entrySecundario.Placeholder = entryPrincipal.Text;
        }
	}
}