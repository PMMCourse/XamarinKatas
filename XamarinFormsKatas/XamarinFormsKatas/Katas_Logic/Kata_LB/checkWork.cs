using Plugin.Connectivity;

namespace XamarinFormsKatas.Katas_Logic.Kata_LB
{
    public class checkWork
    {
        public static bool HayInternet()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
