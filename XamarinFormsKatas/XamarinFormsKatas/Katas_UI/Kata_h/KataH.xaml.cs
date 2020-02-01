using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_h
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataH : ContentPage
	{
		public KataH()
		{
			InitializeComponent();

			BtnAnimated.Clicked += async (sender, e) =>
			{

				await BtnAnimated.TranslateTo(0, -100, 100);
				await BtnAnimated.RotateTo(720, 1000);
				await BtnAnimated.TranslateTo(0, 0, 100);

				BtnAnimated.Rotation = 0;
				BtnAnimated.TranslationX = 0;
			};
		}
	}
}