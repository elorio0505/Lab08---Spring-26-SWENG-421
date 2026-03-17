using System;

namespace Lab08
{
    internal interface TV_IF
    {
        TV_IF replenish(string type, int budget);
        string getInfo();
    }
}