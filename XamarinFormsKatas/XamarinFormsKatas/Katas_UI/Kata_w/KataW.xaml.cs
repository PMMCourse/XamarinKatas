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
        private void sendButton(object sender, EventArgs e) {
            entryControl.IsVisible = false;
            labelControl.IsVisible = false;
            buttonControl.IsVisible = false;
            activityControl.IsVisible = false;

            if (switchEntry.IsToggled) {
                entryControl.IsVisible= true;
            }
            if (switchLabel.IsToggled)
            {
                labelControl.IsVisible = true;
            }
            if (switchButton.IsToggled)
            {
                buttonControl.IsVisible = true;
            }
            if (switchActivity.IsToggled)
            {
                activityControl.IsVisible = true;
            }
            Navigation.PushAsync(new Katas_UI.Kata_w.elementoControles(entryControl, labelControl, buttonControl,activityControl));
        }
	}
}