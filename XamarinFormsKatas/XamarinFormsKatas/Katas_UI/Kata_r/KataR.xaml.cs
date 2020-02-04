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
        List<string> ListaCP = new List<string>();
		public KataR ()
		{
			InitializeComponent ();
            ListaCP.Add(new Clientes() { Nombre = "pepe", Dni = "333444f" }.ToString());
            ListaCP.Add(new Clientes() { Nombre = "pepa", Dni = "333444f" }.ToString());
            ListaCP.Add(new Proveedores() { Nombre = "juan", Producto = "Pc" }.ToString());
            ListaCP.Add(new Proveedores() { Nombre = "juana", Producto = "Ps4" }.ToString());

            Listview.ItemsSource = ListaCP;
        }
	}
}