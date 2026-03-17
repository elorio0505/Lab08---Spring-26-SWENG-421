using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08
{
    internal class GenericTV : TV_impl
    {
        public string getBrand()
        {
            return "Generic Brand";
        }

        public int getSmartTVPrice()
        {
            return 300;
        }

        public int getTVPrice()
        {
            return 200;
        }

        public int getUltraTVPrice()
        {
            return 400;
        }

        public string getResolution()
        {
            return "5.5 watts / hour";
        }

        public string getPowerUsage()
        {
            return "2K HD";
        }
    }
}
