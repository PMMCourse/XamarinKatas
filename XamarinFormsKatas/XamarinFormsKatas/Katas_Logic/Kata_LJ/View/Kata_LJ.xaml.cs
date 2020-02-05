using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_Logic.Kata_LJ.ViewModel;

namespace XamarinFormsKatas.Katas_Logic.Kata_LJ
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Kata_LJ : ContentPage
	{
		public Kata_LJ ()
		{
			InitializeComponent ();
            BindingContext = new MainViewModel();
        }
        private string user;
        private string pass;

        

        private void Accept_Clicked(object sender, EventArgs e)
        {
            Error.IsVisible = false;
            user = User.Text;
            pass = Pass.Text;
            if (string.IsNullOrEmpty(user))
            {
                Error.Text = "Rellena del campo usuario";
                Error.IsVisible = true;
            }

            if (string.IsNullOrEmpty(pass))
            {
                Error.Text = "Rellena del campo contraseña";
                Error.IsVisible = true;
            }
        }
    }
}