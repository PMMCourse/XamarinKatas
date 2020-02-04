using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_Logic.Kata_LB
{
    public class Usuarios
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Tostring
        {
            get
            {
                return $"{UserId} {Id} {Title} {Body}";
            }
        }
    }
}
