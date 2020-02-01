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
        public List<string> nombres = new List<string>();


        public KataZ()
        {
            InitializeComponent();

            nombres.Add("pepe");
            nombres.Add("Jose");
            nombres.Add("Juan");
            nombres.Add("Maria");
            nombres.Add("Paco");
            nombres.Add("Ana");
            nombres.Add("Pepa");
            nombres.Add("Josefa");
            nombres.Add("Chema");
            nombres.Add("pepe");
            nombres.Add("Jose");
            nombres.Add("Juan");
            nombres.Add("Maria");
            nombres.Add("Paco");
            nombres.Add("Ana");
            nombres.Add("Pepa");
            nombres.Add("Josefa");
            nombres.Add("Chema");
            nombres.Add("Josefa");
            nombres.Add("Chema");

            Grid grid = new Grid()
            {
            };
            grid.RowDefinitions = new RowDefinitionCollection();
            grid.ColumnDefinitions = new ColumnDefinitionCollection();

            for (int i = 0; i < 3; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 8; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            Sl.Children.Add(grid);
            int cont = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (cont < 20)
                    {
                        grid.Children.Add(new Label
                        {
                            Text = nombres[cont],
                            HorizontalOptions = LayoutOptions.Center
                        }, j, i);
                        cont++;
                    }
                }
            }

        }
    }
}
