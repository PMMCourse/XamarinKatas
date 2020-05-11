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
            actIndicator.Clicked += async (sender, e) =>
            {
                ActivityIndicator AI = new ActivityIndicator();
                SlP.Children.Add(AI);
                AI.IsRunning = true;
                await pararPrograma(4500, () => AI.IsRunning = false);
            };
        }
        private async Task pararPrograma(int mls, Action actionStop)
        {
            await Task.Delay(mls);
            actionStop();
        }
    }
}
	
