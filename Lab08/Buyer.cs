using System;

namespace Lab08
{
    internal class Buyer
    {
        internal TV tv;
        public void SetTV(TV newTv) => tv = newTv;
        public void Replenish(string type, int budget)
        {
            if (tv != null)
            {
                tv = (TV)tv.replenish(type, budget);
            }
        }
        public void Show()
        {
            if (this.tv != null)
                Console.WriteLine(this.tv.getInfo());
            else
                Console.WriteLine("No TV found");
        }
    }
}