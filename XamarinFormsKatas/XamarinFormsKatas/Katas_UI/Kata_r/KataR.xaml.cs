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
		public List<string> listClientesProov = new List<string>();
		public KataR ()
		{
			InitializeComponent ();

			listClientesProov.Add(new Proveedor() { nombre = "joaquin", producto = "Tomates" }.ToString());
			listClientesProov.Add(new Proveedor() { nombre = "fran", producto = "Cebollas" }.ToString());
			listClientesProov.Add(new Proveedor() { nombre = "camacho", producto = "Pimientos" }.ToString());
			listClientesProov.Add(new Proveedor() { nombre = "Kike", producto = "Fresas" }.ToString());
			listClientesProov.Add(new Cliente() { nombre = "kike", dni = "1234567H" }.ToString());
			listClientesProov.Add(new Cliente() { nombre = "cristian", dni = "6568545Q" }.ToString());
			listClientesProov.Add(new Cliente() { nombre = "miguel", dni = "9876543P" }.ToString());
			listClientesProov.Add(new Cliente() { nombre = "joaquin", dni = "6473847D" }.ToString());

			listaClientesProv.ItemsSource = listClientesProov;
		}
	}
}