using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08
{
    internal class LGTV : TV_impl
    {
        public string getBrand() => "LG";
        public string getPowerUsage() => "6.35 watts/hour";
		public string getResolution() => "4K HD";
        public int getSmartTVPrice() => 350;
        public int getTVPrice() => 250;
        public int getUltraTVPrice() => 450;
    }
}
