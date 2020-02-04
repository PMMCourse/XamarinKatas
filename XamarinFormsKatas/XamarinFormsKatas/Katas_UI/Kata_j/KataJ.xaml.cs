using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_j
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataJ : ContentPage
	{
		public KataJ ()
		{
			InitializeComponent ();
            bool deleted = false;
            btnLogin.Clicked += (sender, e) =>
            {
                if ((Entry2.Text == null || Entry2.Text == "") && deleted == false)
                {
                    Entry entry = new RoundedEntry();
                    sl.Children.Remove(Entry2);
                    sl.Children.Add(entry);
                    deleted = true;
                    var label = new Label()
                    {
                        Text = "ERROR"
                    };
                    sl.Children.Add(label);
                }
            };
        }
	}
}