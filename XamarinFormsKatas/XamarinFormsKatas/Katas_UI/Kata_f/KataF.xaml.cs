using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_f
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KataF : ContentPage
    {
        public List<string> nombres = new List<string>
        {
            "Juan Carlos", "Cueto", "Juanki"
        };

        public KataF()
        {
            InitializeComponent();
            Lista.ItemsSource = nombres;
        }

        private void SearchBar_Pressed(object sender, EventArgs e)
        {
            var palabra = barraBusqueda.Text;
            Lista.ItemsSource = nombres.Where(nombres => nombres.Contains(palabra));

        }
    }
}