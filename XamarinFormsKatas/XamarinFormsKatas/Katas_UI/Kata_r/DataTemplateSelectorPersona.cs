using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_UI.Kata_r.Model;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
    public class DataTemplateSelectorPersona : DataTemplateSelector
    {
        public DataTemplate ClienteTemplate { get; set; }
        public DataTemplate ProveedorTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item.GetType() == typeof(Cliente))
            {
                return ClienteTemplate;
            }
            else
            {
                return ProveedorTemplate;
            }

        }
    }
}
