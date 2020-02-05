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
            rellenar();
		}
        private void ObjetoCreado(object sender, FocusEventArgs e)
        {
            var objeto = new Picker();
            objeto.ItemsSource = lista;
            Sl.Children.Add(objeto);
        }

        private void rellenar()
        {
            lista.Add(2);
            lista.Add(7);
            lista.Add(10);
            lista.Add(16);
        }
    }
}