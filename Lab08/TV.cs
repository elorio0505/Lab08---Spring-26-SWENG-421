using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08
{
    internal class TV : TV_IF
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

        // Methods
        public TV replenish(string type, int budget)
        {
            TV bestMatch = null;
            int highPrice = -1;

            var options = new List<TV>
            {
                new TV(this.impl), new SmartTV(this.impl), new UltraTV(this.impl)
            };

            foreach (var option in options)
            {
                if (type != null && option.getType() != type) 
                    continue;
                if (option.getMSRP() <= budget && option.getMSRP() > highPrice)
                {
                    highPrice = option.getMSRP();
                    bestMatch = option;
                }
            }
            return bestMatch;
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

        public virtual string getInfo()
        {
            return "Brand: " + getBrand() + ", Type: " + getType() + ", Price: $" + getMSRP();
        }

        TV_IF TV_IF.replenish(string type, int budget)
        {
            return replenish(type, budget);
        }

        protected class SmartTV : TV
        {
            private string powerUsage;

            // Constructor
            public SmartTV(TV_impl impl) : base(impl)
            {
                this.type = "Smart_TV";
                this.msrp = impl.getSmartTVPrice();
                this.powerUsage = impl.getPowerUsage();
            }

            public string getPowerUsage()
            {
                return powerUsage;
            }
			
            public override string getInfo()
            {
                return base.getInfo() + ", Power Usage: " + this.powerUsage;
            }
		}

        protected class UltraTV : TV
        {
            string resolution;

            public UltraTV(TV_impl impl) : base(impl)
            {
                this.type = "UltraHD_TV";
                this.msrp = impl.getUltraTVPrice();
                this.resolution = impl.getResolution();
            }

            public string getResolution()
            {
                return resolution;
            }
			public override string getInfo()
            {
                return base.getInfo() + ", Resolution: " + this.resolution;
            }
		}
    }
}
