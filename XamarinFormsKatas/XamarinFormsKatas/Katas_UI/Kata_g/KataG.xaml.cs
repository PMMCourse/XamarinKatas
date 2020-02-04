using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_g
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataG : ContentPage
	{
		public KataG ()
		{
			InitializeComponent ();

			buttonRotation.Clicked += async (sender, e) =>
			{
				await buttonRotation.RotateTo(700, 400);
				buttonRotation.Rotation = 0;
			};
		}		
		//private void AnimarRotacion(object sender, EventArgs e)
		//{
		//	await buttonRotation.RotateTo(700, 400);
		//	buttonRotation.Rotation = 0;
		//}		
	}
}