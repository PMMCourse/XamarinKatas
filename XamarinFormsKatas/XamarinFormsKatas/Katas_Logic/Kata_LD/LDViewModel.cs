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
        private string _textoParametro;
        public string TextoParametro
        {
            get => _textoParametro;
            set => SetChanged(ref _textoParametro, value);
        }

        private Command _navegar;
        public ICommand Navegar => _navegar;


    }
}
