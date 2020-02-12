using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_l {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KataL : ContentPage {
        public KataL() {
            InitializeComponent();
        }
        private void SwipeL(object sender, EventArgs e) {
            eventDescription.Text = "LeftSwipe";
        }
        private void SwipeR(object sender, EventArgs e) {
            eventDescription.Text = "RightSwipe";
        }
        private void Tap(object sender, EventArgs e) {
            eventDescription.Text = "Tap";
        }
        private void Pinch(object sender, EventArgs e) {
            eventDescription.Text = "Pinch";
        }
    }
}