using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LA;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD
{
    public class mainViewModel:BaseViewModel
    {
        private Command _commandNavegacion;
        public ICommand commandNavegacion => _commandNavegacion;
        public INavigation navegacion { get; set; }
        private string _entrada;
        public string entrada
        {
            get => _entrada;
            set
            {
                _entrada = value;
                OnPropertyChanged();
            }
        }
        public mainViewModel(INavigation navego)
        {
            navegacion = navego;
            _commandNavegacion = new Command(async () => await Navigacion());
        }

        public async Task Navigacion()
        {
            pagina1 p1 = new pagina1(entrada);
            await navegacion.PushAsync(p1);
        }
    }
}
