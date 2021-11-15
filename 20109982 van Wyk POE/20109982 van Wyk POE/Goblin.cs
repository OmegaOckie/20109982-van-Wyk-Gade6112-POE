using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_van_Wyk_POE
{
    //Q.2.5
    class Goblin : Enemy
    {
        /// <summary>
        /// Q.2.5 | A constructor that receives only an X and Y position, but delegates its
        /// variable setting mostly to the Enemy class along the following parameters:
        /// o Goblins have 10 HP
        /// o Goblins do 1 damage
        /// </summary>
        /// <param name="goblinX"></param>
        /// <param name="goblinY"></param>
        public Goblin(int goblinX, int goblinY) : base (goblinX, goblinY, 1, 10, 'G')
        {
            x = goblinX;
            y = goblinY;
            HP = 10;
        }

        /// <summary>
        /// Q.2.5 | This method does not use the optional
        /// movement parameter.Instead, it randoms a direction for the goblin to move
        /// in, and checks that movement against the goblin’s vision array.If something
        /// is in the way (a Hero or a Wall for now), the random position should be
        /// rerolled.When a valid position is chosen, it is returned from the method.
        /// </summary>
        /// <param name="move"></param>
        /// <returns></returns>
        public override Movement ReturnMove(Movement move)
        {
            int direction = rng.Next(4);
            switch (direction)
            {
                case 1:
                    if (characterVision[0] == null)
                    {
                        move = Movement.UP;
                    }
                    else
                    {
                        ReturnMove(move);
                    }
                    break;
                case 2:
                    if (characterVision[1] == null)
                    {
                        move = Movement.DOWN;
                    }
                    else
                    {
                        ReturnMove(move);
                    }
                    break;
                case 3:
                    if (characterVision[2] == null)
                    {
                        move = Movement.LEFT;
                    }
                    else
                    {
                        ReturnMove(move);
                    }
                    break;
                case 4:
                    if (characterVision[3] == null)
                    {
                        move = Movement.RIGHT;
                    }
                    else
                    {
                        ReturnMove(move);
                    }
                    break;
                default:
                    return  Movement.NONE;
            }
            return move;
        }
    }
}
