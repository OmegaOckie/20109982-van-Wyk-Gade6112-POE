using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_van_Wyk_POE
{
    abstract class Weapon : Item
    {
        protected int damage { get; set; }
        virtual protected int range { get; set; }
        protected int durability { get; set; }
        protected int cost { get; set; }
        protected string weaponType { get; set; }

        public Weapon(char symbol, int optionalWeaponXPos = 0, int optionalWeaponYPos = 0) : base(optionalWeaponXPos, optionalWeaponYPos)
        {

        }


    }
}
