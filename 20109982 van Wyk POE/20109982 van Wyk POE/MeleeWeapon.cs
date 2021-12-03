using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_van_Wyk_POE
{
    class MeleeWeapon : Weapon
    {
        public enum Types
        {
            DAGGER,
            LONGSWORD
        }

        //C# only allowed for me to make it protected.
        protected override int range { get => base.range; set => base.range = 1; }
    
        public MeleeWeapon(Types typeOfWeapon, int optionalWeaponXPos, int optionalWeaponYPos) : base ('M', optionalWeaponXPos, optionalWeaponYPos)
        {
            switch (typeOfWeapon)
            {
                case Types.DAGGER:
                    weaponType = "Dagger";
                    durability = 10;
                    damage = 3;
                    cost = 3;
                    break;
                case Types.LONGSWORD:
                    weaponType = "Longsword";
                    durability = 6;
                    damage = 4;
                    cost = 5;
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
