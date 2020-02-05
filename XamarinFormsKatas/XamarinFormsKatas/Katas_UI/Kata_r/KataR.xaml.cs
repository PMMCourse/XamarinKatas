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
		public List<string> ListaClientes;
		public List<string> ListaProveedores;
		public KataR()
		{
			InitializeComponent();
			ListaClientes = new List<string>() { "Cliente 1", "Cliente 2", "Cliente 3", "Cliente 4" };
			ListaProveedores = new List<string>() { "proveedor 1 vende coches", "proveedor 2 vende casas", "proveedor 3 vende pescado", "proveedor 4 vende verduras" };
		}
		private void cambiarAlistaClientes(object sender, EventArgs e)
		{
			listViewR.ItemsSource = ListaClientes;
		}
		private void cambiarAlistaProveedores(object sender, EventArgs e)
		{
			listViewR.ItemsSource = ListaProveedores;
		}
	}
}