using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_i
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataI : ContentPage
	{
		public KataI()
		{
			InitializeComponent();

		}

		private void inputOrigen_TextChanged(object sender, TextChangedEventArgs e)
		{
			//le asigno en tiempo real el contenido de origen al placeholder de destino
			inputDestino.Placeholder = inputOrigen.Text;
		}
	}
}