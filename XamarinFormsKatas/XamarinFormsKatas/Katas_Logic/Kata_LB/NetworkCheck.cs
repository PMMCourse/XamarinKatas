using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_Logic.Kata_LB
{
    public class NetworkCheck
    {
        public static bool IsInternet()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                return true;
            }
            else
            {
                // write your code if there is no Internet available      
                return false;
            }
        }
    }
}