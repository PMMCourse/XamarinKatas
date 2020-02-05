using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_z
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KataZ : ContentPage
    {
        public List<String> lista = new List<string>();
        public KataZ()
        {
            InitializeComponent();
            lista.Add("pepe");
            lista.Add("paco");
            lista.Add("maria");
            lista.Add("Sara");
            lista.Add("Carolina");
            lista.Add("Nerea");
            lista.Add("Lucia");
            lista.Add("Ana");
            lista.Add("Alba");
            lista.Add("Tania");
            lista.Add("Demetrio");
            lista.Add("Chema");
            lista.Add("Nazar");
            lista.Add("Irene");
            lista.Add("Paula");
            lista.Add("Ana U");
            lista.Add("Alex");
            lista.Add("luis");
            lista.Add("luisita");
            lista.Add("amaya");

            Grid nuevoGrid = new Grid
            {
                BackgroundColor = Color.Blue,
                HeightRequest = 500,
                WidthRequest = 500
            };
            nuevoGrid.RowDefinitions = new RowDefinitionCollection();
            nuevoGrid.ColumnDefinitions = new ColumnDefinitionCollection();
            for (int i = 0; i < 7; i++)
            {
                nuevoGrid.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 3; i++)
            {
                nuevoGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            sl.Children.Add(nuevoGrid);
            int contador = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (contador < 20)
                    {
                        nuevoGrid.Children.Add(new Label
                        {
                            Text = lista[contador],
                            FontSize = 25,
                            HorizontalOptions = LayoutOptions.Center
                        }, j, i);
                        contador++;
                    }
                }
            }
        }
    }
}