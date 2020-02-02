using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_n
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class kataNtabbedPage : TabbedPage
    {
        public kataNtabbedPage()
        {
            InitializeComponent();

            pest1.Content = new pestañas.Pestaña1().Content;
            pest2.Content = new pestañas.Pestaña2().Content;
            pest3.Content = new pestañas.Pestaña3().Content;
        }
    }
}