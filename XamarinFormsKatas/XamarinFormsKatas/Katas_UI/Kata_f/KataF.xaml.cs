using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_UI.Kata_e;

namespace XamarinFormsKatas.Katas_UI.Kata_f
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataF : ContentPage
	{
		public IList<Persona> p { get; private set; }

		public KataF()
		{
			InitializeComponent ();
			p = new List<Persona>();
			p.Add(new Persona("paco", "20", "http://www.egrupos.net/albumPhoto/1293313/photo_1.jpg"));
			p.Add(new Persona("pepe", "23", "https://image.shutterstock.com/image-photo/smiling-young-casual-man-holding-260nw-82060567.jpg"));
			p.Add(new Persona("Manuel", "10", "https://www.lawebdelprogramador.com/usr/149000/149029/profileImage_origin.jpg?1412666134"));
			p.Add(new Persona("Emma", "2", "https://centreypsilon.files.wordpress.com/2012/06/foto-carnet2.jpg"));
			p.Add(new Persona("Emmilly", "40", "https://pbs.twimg.com/profile_images/1079157197655941120/eixxOKWj_400x400.jpg"));
			BindingContext = this;

		}
		private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			 Persona per = (Persona)vistaLista.SelectedItem;
			Navigation.PushAsync(new NuevaPagina(per));
		}

		private void botonBuscar(object sender, EventArgs e)
		{
			string inputUsuario = textoAbuscar.Text.ToString();

			var listanoFiltrada=p.ToList();

				if (listanoFiltrada.ToString().Contains(inputUsuario))
				{
				vistaLista.ItemsSource = inputUsuario;
				}
				else
				{
				DisplayAlert("Resultado de la busqueda", "No se encontro el resultado", "cerrar");
			}
		}
	}
}