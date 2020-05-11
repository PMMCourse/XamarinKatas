using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataR : ContentPage
	{
		List<string> clienteProveLista = new List<string>();
		public KataR ()
		{
			InitializeComponent ();

			Cliente c1 = new Cliente("juanki", "12345678F");
			Cliente c2 = new Cliente("Carlos", "87654321K");

			proveedor p1 = new proveedor("Jara", "Teclados");
			proveedor p2 = new proveedor("Sara", "Ratones");

			clienteProveLista.Add(c1.ToString());
			clienteProveLista.Add(c2.ToString());
			clienteProveLista.Add(p1.ToString());
			clienteProveLista.Add(p2.ToString());

			lista.ItemsSource = clienteProveLista;
		}
	}
}