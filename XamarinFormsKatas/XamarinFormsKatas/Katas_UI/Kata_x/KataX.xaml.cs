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
        List<int> lista = new List<int>();
		public KataX ()
		{
			InitializeComponent ();
            relleno();
            EntryX.Focused += ObjetoCreado;
		}

        private void ObjetoCreado(object sender, FocusEventArgs e)
        {
           var objeto = new Picker();
            objeto.ItemsSource = lista;
            Ejerx.Children.Add(objeto);
        }

        private void relleno()
        {
            lista.Add(2);
            lista.Add(5);
            lista.Add(10);
            lista.Add(15);
        }
    }
}