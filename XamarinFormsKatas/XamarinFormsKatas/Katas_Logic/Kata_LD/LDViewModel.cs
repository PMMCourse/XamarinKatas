using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LA;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD
{
    public class LDViewModel : BaseViewModel
    {
        public INavigation Navegacion { get; set; }

        private string _textoParametro;
        public string TextoParametro
        {
            get => _textoParametro;
            set => SetChanged(ref _textoParametro, value);
        }

        private Command _navegar;
        public ICommand Navegar => _navegar;

        public LDViewModel(INavigation nav)
        {
            Navegacion = nav;
            _navegar = new Command(async () => await navegando());
        }

        public async Task navegando()
        {
            await Navegacion.PushAsync(new VentanaDos(TextoParametro));
        }
    }
}
