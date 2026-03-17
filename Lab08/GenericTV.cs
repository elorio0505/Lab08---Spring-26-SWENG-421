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
        public string getResolution() => "2K HD";
        public string getPowerUsage() => "5.5 watts/hour";
    }
}
