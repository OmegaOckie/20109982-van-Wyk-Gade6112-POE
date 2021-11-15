using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_van_Wyk_POE
{
    class Gold : Item
    {
        private int amountOfGold;

        public int getAmountOfGold { get => amountOfGold; set => amountOfGold = value; }

        private Random randomGoldAmount;

        public Gold(int xPos, int yPos) : base(xPos, yPos)
        {
            getAmountOfGold = randomGoldAmount.Next(1, 6);
        }

        public override string ToString()
        {
            return " G ";
        }
    }
}
