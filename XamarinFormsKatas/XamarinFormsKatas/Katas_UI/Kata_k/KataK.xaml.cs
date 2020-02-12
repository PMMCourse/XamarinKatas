using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_k {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KataK : ContentPage {
        Random aleatorio = new Random();
        List<int> listaAleatoria = new List<int>();
        public KataK() {
            InitializeComponent();
            LoadData();
            Lista.RefreshCommand = new Command(() => {
                Lista.IsRefreshing = true;
                LoadData();
            });
        }
        void LoadData() {
            Lista.ItemsSource = null;
            listaAleatoria.Add(aleatorio.Next());
            Lista.ItemsSource = listaAleatoria;
            Lista.IsRefreshing = false;
        }
    }
}