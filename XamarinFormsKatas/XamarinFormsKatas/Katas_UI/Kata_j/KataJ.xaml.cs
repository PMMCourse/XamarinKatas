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
            user1 = User.Text;
            pass1= Pass.Text;
            InitializeComponent ();
		}
        string user1;
        string pass1;
        private void Accept_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(user1))
            {
                Entry errorcito = new Entry();
                errorcito.Text = "No dejes vacio el user";
                contenedor.Children.Add(errorcito);
            }
            if (String.IsNullOrEmpty(pass1))
            {
                Entry errorcito = new Entry();
                errorcito.Text = "No dejes vacia la contraseña";
                contenedor.Children.Add(errorcito);
            }

        }

    }
}