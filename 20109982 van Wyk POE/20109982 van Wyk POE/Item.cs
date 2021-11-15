using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_van_Wyk_POE
{
    abstract class Item : Tile
    {
        public Item(int xPos, int yPos) : base(xPos, yPos)
        {

        }

        public abstract override string ToString();
    }
}
