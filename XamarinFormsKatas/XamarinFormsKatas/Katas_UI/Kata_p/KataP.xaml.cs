using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_p
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataP : ContentPage
	{
		public KataP ()
		{
			InitializeComponent ();
            BtnActivity.Clicked += async (sender, e) =>
            {
                ActivityIndicator activityIndicator = new ActivityIndicator();
                Sl.Children.Add(activityIndicator);
                activityIndicator.IsRunning = true;
                await WaitAndExecute(5000, () => activityIndicator.IsRunning = false);             
               
            };

		}
        private async Task WaitAndExecute(int milisec, Action actionToExecute)
        {
            await Task.Delay(milisec);
            actionToExecute();
        }
    }
}