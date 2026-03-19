using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08
{
    internal class SonyTV : TV_impl
    {
        public string getBrand() => "Sony";
        public string getPowerUsage() => "5.15 watts/hour";
        public string getResolution() => "4K HD";
        public int getSmartTVPrice() => 380;
        public int getTVPrice() => 280;
        public int getUltraTVPrice() => 480;
    }
}
