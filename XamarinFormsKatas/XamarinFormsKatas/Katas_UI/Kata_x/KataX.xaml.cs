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
		public KataX()
		{
			InitializeComponent();
		}

		private void Label_Focused(object sender, FocusEventArgs e)
		{
			pickerID.IsVisible = true;
		}

		private void pickerID_SelectedIndexChanged(object sender, EventArgs e)
		{
			labelID.Text = $"Item seleccionado: {pickerID.SelectedItem.ToString()}";
		}
	}
}