﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinFormsKatas.Katas_UI.Kata_c
{

    public class MasterDetailPageKataCMasterMenuItem
    {
        public MasterDetailPageKataCMasterMenuItem()
        {
            TargetType = typeof(MasterDetailPageKataCMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}