using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_van_Wyk_POE
{
    class Leader : Enemy
    {
        private Tile enemyTarget { get; set; }

        public Leader(int enemyXPos, int enemyYPos) : base (enemyXPos, enemyYPos, 2, 20, 'L')
        {
            
        }

        public override Movement ReturnMove(Movement move = Movement.NONE)
        {
            throw new NotImplementedException();
        }
    }
}
