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
        List<string> listaCliPro = new List<string>();

		public KataR ()
		{
			InitializeComponent ();
            Cliente c1 = new Cliente("Manuel", "295185425F");
            Cliente c2 = new Cliente("Manuela", "19751999G");
            proveedores p1 = new proveedores("luis", "ordenador");
            proveedores p2 = new proveedores("marina", "pinturas");
            listaCliPro.Add(c1.ToString());
            listaCliPro.Add(c2.ToString());
            listaCliPro.Add(p1.ToString());
            listaCliPro.Add(p2.ToString());

            lista.ItemsSource = listaCliPro;
		}
	}
}