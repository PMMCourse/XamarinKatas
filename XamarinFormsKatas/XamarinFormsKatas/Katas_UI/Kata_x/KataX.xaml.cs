using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_x
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataX : ContentPage
	{

        List<int> listaNumeros = new List<int>();

		public KataX ()
		{
			InitializeComponent ();

            RellenarNumeros();

            Entry1.Focused += CrearObjeto;

		}

        private void RellenarNumeros()
        {
            listaNumeros.Add(1);
            listaNumeros.Add(2);
            listaNumeros.Add(3);
        }

        private void CrearObjeto(Object sender, EventArgs e)
        {
            var objeto = new Picker();
            objeto.ItemsSource = listaNumeros;

            StackX.Children.Add(objeto);
        }
	}
}