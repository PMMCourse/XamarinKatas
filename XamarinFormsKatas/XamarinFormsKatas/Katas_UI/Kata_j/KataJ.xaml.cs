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

        private void Accept_Clicked(object sender, EventArgs e)
        {
            if (Pass.Text == String.Empty)
            {
                Entry errorcito = new Entry();
                errorcito.Text = "No dejes vacio el user o iras al infierno de lleida";
                contenedor.Children.Add(errorcito);
            }
            if (Pass.Text==String.Empty)
            {
                Entry errorcito = new Entry();
                errorcito.Text = "No dejes vacia la contraseña o iras al infierno de lleida";
                contenedor.Children.Add(errorcito);
            }

        }

    }
}