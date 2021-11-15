using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_van_Wyk_POE
{
    //Q.2.4 | Create the abstract Enemy class which inherits from Character.
    abstract class Enemy : Character
    {
        //Initialized variables
        protected Random rng = new Random();

        /// <summary>
        /// Q.2.4 | A constructor that receives X and Y positions, an enemy’s damage and it is
        /// starting HP(and thus also max HP) and its symbol.It delegates its X and Y
        /// position to the Character subclass via a constructor initialiser.It then sets
        /// all the relevant member variables.
        /// </summary>
        /// <param name="enemyX"></param>
        /// <param name="enemyY"></param>
        /// <param name="enemyDamage"></param>
        /// <param name="enemyStartingHP"></param>
        /// <param name="enemyMaxHP"></param>
        /// <param name="enemySymbol"></param>
        public Enemy (int enemyX, int enemyY, int enemyDamage,int enemyStartingHP, char enemySymbol) : base (enemyX, enemyY, 'E')
        {
            x = enemyX;
            y = enemyY;
            Damage = enemyDamage;
            MaxHP = enemyStartingHP;
        }

        /// <summary>
        /// Q.2.4 | An overridden ToString method that, using the enemy’s class, outputs a
        /// string that looks as follows:
        /// EnemyClassName at[X, Y] (Amount DMG)
        /// This will be used by the Enemy subclasses.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "$EnemyClassName at [{x}, {y}] ({Damage})\n";
        }
    }
}
