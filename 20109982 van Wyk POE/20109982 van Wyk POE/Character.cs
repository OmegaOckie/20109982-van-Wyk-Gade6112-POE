using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_van_Wyk_POE
{
    // Q.2.2 Creation of abstract Base Class Character
    abstract class Character : Tile
    {
        // Variable Initialization
        protected int HP { get; set; }
        protected int MaxHP { get; set; }
        protected int Damage { get; set; }

        protected Tile[] characterVision;// = new Tile[4];

        protected int characterGoldPurse { get; set; }

        public enum Movement
        {
            NONE,
            UP,
            DOWN,
            LEFT,
            RIGHT
        }

        public Character(int characterX, int characterY, char Symbol) : base (characterX, characterY)
        {
            x = characterX;
            y = characterY;
        }

        /// <summary>
        /// Q.2.3 | Attacks a target and 
        /// its health by the attacking character’s damage.This is declared as virtual
        /// for later overriding by specific enemy types.
        /// </summary>
        /// <param name="target"></param>
        public virtual void Attack(Character target)
        {
            target.HP = -Damage;
        }

        /// <summary>
        /// Q.2.3 | Checks if the character is dead.
        /// </summary>
        /// <returns></returns>
        public bool IsDead()
        {
            if (HP < 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Q.2.3 | Checks if a target is 
        /// range of a character(barehanded range is always 1, but this will be
        /// extended with weapon types later). It determines distance via the
        /// DistanceTo() method and returns true or false.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public virtual bool CheckRange(Character target)
        {
            int distanceToTarget = DistanceTo(target);
            //Assumes character is barehanded
            if (distanceToTarget == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Q.2.3 | used by CheckRange(): Determines 
        /// absolute distance(number of spaces needed to move – e.g.diagonal is one
        /// up + one across = 2) between a character and its target.
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        private int DistanceTo(Character target)
        {
            //get the player's position
            int characterX = x;
            int characterY = y;

            //get the target's position
            int targetX = target.x;
            int targetY = target.y;

            //set distance value
            int Distance = 0;

            //Calculate the difference in positions
            while (characterX != targetX && characterY != targetY)
            {
                if (characterX < targetX)
                {
                    characterX++;
                    Distance++;
                }
                else if (characterX > targetX)
                {
                    characterX--;
                    Distance++;
                }
                else if (characterY < targetY)
                {
                    characterY++;
                    Distance++;
                }
                else if (characterY > targetY)
                {
                    characterY--;
                    Distance++;
                }
            }

            return Distance;
        }

        /// <summary>
        /// Q.2.3 | Edits a unit’s X and Y values to
        /// move it up/down/left/right based on the identifier from the enum.
        /// </summary>
        /// <param name="move"></param>
        public void Move(Movement move)
        {
            switch (move)
            {
                //Movement note:NONE,UP,DOWN,LEFT,RIGHT
                case Movement.UP:
                    y++;
                    break;
                case Movement.DOWN:
                    y--;
                    break;
                case Movement.LEFT:
                    x--;
                    break;
                case Movement.RIGHT:
                    x++;
                    break;
                default:
                    //No movement
                    break;
            }
        }

        public void Pickup(Item i)
        {
            switch (i)
            {
                //case :
                //    Gold myGold = new Gold(xPos, yPos);
                 //   characterGoldPurse = myGold.getAmountOfGold;
                //    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Q.2.3 | this will be defined by the Character subclasses. The method returns a
        /// direction of movement based on how the character should move, based on
        /// the validity of that move against a Character’s vision array.
        /// </summary>
        /// <param name="move"></param>
        /// <returns></returns>
        public abstract Movement ReturnMove(Movement move = 0);

        /// <summary>
        /// Q.2.3 | This is defined in the Character
        /// subclasses, and overrides the traditional Object ToString() method.
        /// </summary>
        public abstract override String ToString();

    }


}
