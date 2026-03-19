using System;

namespace Lab08
{
    internal class Customer
    {
        internal TV_IF tv_if;

        public Customer(TV tv)
        {
            SetTV(tv);
        }
		public void SetTV(TV_IF newTv_IF) => tv_if = newTv_IF;
		public void Replenish(string type, int budget)
        {
            if (tv_if != null)
            {
                TV_IF newTV = tv_if.replenish(type, budget);
                if (newTV != null)
                {
                    tv_if = newTV;
                }
            }
        }
        public void Show()
        {
            if (this.tv_if != null)
                Console.WriteLine(this.tv_if.getInfo());
            else
                Console.WriteLine("No TV found");
        }
    }
}