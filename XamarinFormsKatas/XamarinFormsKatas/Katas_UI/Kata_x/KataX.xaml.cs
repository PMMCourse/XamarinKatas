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
        List<string> nombre = new List<string>();
        public KataX ()
		{
			InitializeComponent ();
            
            nombre.Add("Dani");
            nombre.Add("Juan");
            nombre.Add("Paco");
            nombre.Add("Evaristo");
        }
        private void createPicker(object sender, EventArgs e) {
            var picker = new Picker();
            picker.ItemsSource = nombre;
            contenedor.Children.Add(picker);
        }
	}
}