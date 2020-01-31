using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LA;

namespace XamarinFormsKatas.Katas_Logic.Kata_LC
{
    public class LCViewModel : BaseViewModel
    {
        private string _texto;
        public string Texto
        {
            get => _texto;
            set => SetChanged(ref _texto, value);
        }

        private Command _generarTexto;
        public ICommand GenerarTexto => _generarTexto;

        public LCViewModel()
        {
            _generarTexto = new Command(Generar);
        }

        private void Generar(object obj)
        {
            Texto = "Se ha generado el texto";          
        }
    }
}
