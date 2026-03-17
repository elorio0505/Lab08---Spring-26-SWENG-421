using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08
{
    internal class TV
    {
        // Fields
        protected string type = "TV";
        protected int msrp;
        protected TV_impl impl;

        // Constructor
        public TV(TV_impl impl) {
            this.impl = impl;
            this.msrp = impl.getTVPrice();
        }

        // Getters
        public string getType()
        {
            return type;
        }

        public int getMSRP()
        {
            return msrp;
        }

        public string getBrand()
        {
            return impl.getBrand();
        }

        public virtual string getInfo() => throw NotImplementedException;

        protected class SmartTV : TV
        {
            string powerUsage;

            // Constructor
            public SmartTV(TV_impl impl) : base(impl)
            {
                this.powerUsage = impl.getPowerUsage(); 
            }

            public string getPowerUsage()
            {
                return powerUsage;
            }
			public override string getInfo() => throw NotImplementedException;
		}

        protected class UltraTV : TV
        {
            string resolution;

            public UltraTV(TV_impl impl) : base(impl)
            {
                this.resolution = impl.getResolution();
            }

            public string getResolution()
            {
                return resolution;
            }
			public override string getInfo() => throw NotImplementedException;
		}
    }
}
