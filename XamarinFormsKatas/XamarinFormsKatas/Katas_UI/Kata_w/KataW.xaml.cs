using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_w
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataW : ContentPage
	{
		public KataW ()
		{
			InitializeComponent ();
		}
        private void clickBoton(object sender,EventArgs e)
        {
            EControl.IsVisible = false;
            LControl.IsVisible = false;
            BControl.IsVisible = false;
            AControl.IsVisible = false;
            if (switchE.IsToggled)
            {
                EControl.IsVisible = true;
            }
            if (switchL.IsToggled)
            {
                LControl.IsVisible = true;
            }
            if(switchB.IsToggled){
                BControl.IsVisible = true;
            }
            if (switchA.IsToggled)
            {
                AControl.IsVisible = true;
            }
            Navigation.PushAsync(new Katas_UI.Kata_w.controlElementos(EControl, LControl, BControl, AControl));
        }
    }
} 
          