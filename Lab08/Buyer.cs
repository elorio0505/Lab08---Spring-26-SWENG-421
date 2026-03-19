using System;

namespace Lab08
{
    internal class Buyer
    {
        internal TV tv;

        public Buyer(TV tv)
        {
            SetTV(tv);
        }
        public void SetTV(TV newTv) => tv = newTv;
        public void Replenish(string type, int budget)
        {
            if (tv != null)
            {
                TV newTV = tv.replenish(type, budget);
                if (newTV != null)
                {
                    tv = newTV;
                }
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