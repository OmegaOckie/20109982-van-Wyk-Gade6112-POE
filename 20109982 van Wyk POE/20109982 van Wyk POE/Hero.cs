using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_van_Wyk_POE
{
    class Hero : Character
    {
        /// <summary>
        /// A constructor that receives an X and Y position and HP, but calls the
        /// Character constructor initialiser, passing it the X and Y position.It should
        /// then set the HP and max HP of the hero based on the parameter.
        /// Additionally, a Hero’s damage is always 2.
        /// </summary>
        /// <param name="heroX"></param>
        /// <param name="heroY"></param>
        /// <param name="heroHP"></param>
        public Hero(int heroX, int heroY, int heroHP) : base(heroX, heroY, 'H')
        {
            HP = heroHP;
            MaxHP = heroHP;
            Damage = 2;
        }

        public override Movement ReturnMove(Movement move)
        {
            if (move == Movement.UP && characterVision[0] == null)
            {
                return Movement.UP;
            }
            else if (move == Movement.DOWN && characterVision[1] == null)
            {
                return Movement.DOWN;
            }
            else if (move == Movement.LEFT && characterVision[2] == null)
            {
                return Movement.LEFT;
            }
            else if (move == Movement.RIGHT && characterVision[3] == null)
            {
                return Movement.RIGHT;
            }
            else
            {
                return Movement.NONE;
            }
        }

        public override string ToString()
        {
            return "Player Stats:" +
                "\n HP:" + HP + "/" + MaxHP +
                "\n Gold Amount: " + characterGoldPurse +
                "\n Damage: 2" +
                "\n [" + x + ", " + y + "]";
        }
    }
}
