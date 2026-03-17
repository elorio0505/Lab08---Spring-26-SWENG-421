using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08
{
    internal class GenericTV : TV_impl
    {
        public string getBrand() => "Generic Brand";
        public int getSmartTVPrice() => 300;
        public int getTVPrice() => 200;
        public int getUltraTVPrice() => 400;
        public string getResolution() => "5.5 watts / hour";
        public string getPowerUsage() => "2K HD";
    }
}
