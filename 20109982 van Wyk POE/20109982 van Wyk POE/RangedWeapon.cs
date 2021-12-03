using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_van_Wyk_POE
{
    class RangedWeapon : Weapon
    {
        public enum Types
        {
            RIFLE,
            LONGBOW
        }

        protected override int range { get => base.range; set => base.range = value; }

        public RangedWeapon(Types rangedWeaponTypes, int optionalXPos = 0, int optionalYPos = 0) : base('R', optionalXPos, optionalYPos)
        {
            switch (rangedWeaponTypes)
            {
                case Types.RIFLE:
                    weaponType = "Rifle";
                    durability = 3;
                    range = 3;
                    damage = 5;
                    cost = 7;
                    break;
                case Types.LONGBOW:
                    weaponType = "Longbow";
                    durability = 4;
                    range = 2;
                    damage = 4;
                    cost = 6;
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
