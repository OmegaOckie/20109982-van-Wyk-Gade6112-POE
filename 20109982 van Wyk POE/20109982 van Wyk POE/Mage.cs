using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_van_Wyk_POE
{
    class Mage : Enemy
    {
        public Mage( int xPos, int yPos) : base (xPos, yPos, 5, 5, 'M')
        {

        }

        public override Movement ReturnMove(Movement move = Movement.NONE)
        {
            throw new NotImplementedException();
        }

        public override bool CheckRange(Character target)
        {
            return base.CheckRange(target);
        }
    }
}
