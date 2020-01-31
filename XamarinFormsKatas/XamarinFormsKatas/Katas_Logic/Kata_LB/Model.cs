using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_Logic.Kata_LB
{
    public class Model
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        public string MJson
        {
            get
            {
                return $"UserID: {userId}, ID: {id}, Titulo: {title}, Body: {body}";
            }
        }
    }
}
