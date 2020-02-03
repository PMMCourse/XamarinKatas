using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_y
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataY : ContentPage
	{
        public List<string> lista = new List<string>();

		public KataY ()
		{
			InitializeComponent ();


            lista.Add("luis");
            lista.Add("franco");
            lista.Add("loren");
            lista.Add("enrique");
            lista.Add("pepe");
            lista.Add("marina");
            lista.Add("irene");
            lista.Add("julia");
            lista.Add("lourdes");
            lista.Add("inma");
            lista.Add("guillermo");
            lista.Add("mateo");
            lista.Add("maria");
            lista.Add("armando");
            lista.Add("manolo");
            lista.Add("manuel");
            lista.Add("luis");
            lista.Add("gregorio");
            lista.Add("luisita");
            lista.Add("amelia");

            Grid nuevoGrid = new Grid()
            {

            };
            nuevoGrid.RowDefinitions = new RowDefinitionCollection();
            nuevoGrid.ColumnDefinitions = new ColumnDefinitionCollection();

            for(int i = 0; i < 3; i++)
            {
                nuevoGrid.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 8; i++)
            {
                nuevoGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            sl1.Children.Add(nuevoGrid);
            int contador = 0;
            for (int i = 0;i<3;i++) {
                for(int j = 0; j < 8; j++)
                {
                    if (contador < 20)
                    {
                        nuevoGrid.Children.Add(new Label
                        {
                            Text = lista[contador],
                            HorizontalOptions=LayoutOptions.Center
                        },j,i);
                        contador++;
                    }
                }
            }
        }
	}
}