using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08
{
    internal class SonyTV : TV_impl
    {
        public string getBrand()
        {
            return "Sony";
        }

        public string getPowerUsage()
        {
            return "6.35 watts/hour";
        }

        public string getResolution()
        {
            return "4K HD";
        }

        public int getSmartTVPrice()
        {
            return 380;
        }

        public int getTVPrice()
        {
            return 280;
        }

        public int getUltraTVPrice()
        {
            return 480;
        }
    }
}
