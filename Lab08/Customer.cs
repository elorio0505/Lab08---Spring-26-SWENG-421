using System;

namespace Lab08
{
    internal class Customer
    {
        internal TV_IF tv_if;
        public void Replenish(string type, int budget)
        {
            if (tv_if != null)
            {
                tv_if = (TV_IF)tv_if.replenish(type, budget);
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