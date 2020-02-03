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
        private Command _generarTexto;
        public ICommand GenerarTexto => _generarTexto;

        public LCViewModel()
        {
            _generarTexto = new Command(Generar);
        }

        private async void Generar(object obj)
        {
            await Application.Current.MainPage.DisplayAlert("Titulo", "Se ha generado el texto", "Cancelar");
        }
    }
}
