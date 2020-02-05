using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_m
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataM : ContentPage
	{
		public KataM ()
		{
			InitializeComponent ();
		}

		private void btPulsar_Clicked(object sender, EventArgs e)
		{
			Label lb = new Label();
			lb.Text = "Nuevo label";
			Stack1.Children.Add(lb);
		}
	}
}