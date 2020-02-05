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
			Btnanimate.Clicked += async (sender, e) =>
			{

				await buttonRotation.TranslateTo(0, -100, 100);
				await buttonRotation.RotateTo(360, 5000);
				await buttonRotation.TranslateTo(0, 0, 100);

				buttonRotation.Rotation = 0;

				buttonRotation.TranslationY = 0;

			};
		}
	}
}