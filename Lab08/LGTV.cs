using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08
{
    internal class LGTV : TV_impl
    {
        public string getBrand()
        {
            return "LG";
        }

        public string getPowerUsage()
        {
            return "5.15 watts/hour";
        }

        public string getResolution()
        {
            return "4K HD";
        }

        public int getSmartTVPrice()
        {
            return 350;
        }

        public int getTVPrice()
        {
            return 250;
        }

        public int getUltraTVPrice()
        {
            return 480;
        }
    }
}
