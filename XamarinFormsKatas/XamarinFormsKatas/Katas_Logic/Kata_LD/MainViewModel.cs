using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LA;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD
{
    public class MainViewModel : BaseViewModel
    {
        private Command _CommandNavigation;
        public ICommand CommandNavigation => _CommandNavigation;

        public INavigation navegar { get; set; }

        private string _Entrada;
        public string Entrada
        {
            get => _Entrada;
            set
            {
                _Entrada = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel(INavigation navegate)
        {
            navegar = navegate;
            _CommandNavigation = new Command(async () => await Navigation());
        }

        public async Task Navigation()
        {
            PaginaNueva p1 = new PaginaNueva(Entrada);
            await navegar.PushAsync(p1);
        }
    }
}
