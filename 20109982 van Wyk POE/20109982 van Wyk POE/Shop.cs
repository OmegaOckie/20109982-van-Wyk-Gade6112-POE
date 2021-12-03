using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_van_Wyk_POE
{
    class Shop
    {
        //Variables
        Weapon[] shopWeapons = new Weapon[3];

        Random rng = new Random();

        protected Character buyer;

        //Methods
        public Shop(Character buyer)
        {
            for (int i = 0; i < shopWeapons.Length; i++)
            {
                shopWeapons[i] = RandomWeapon();
            }
            this.buyer = buyer;
        }

        private Weapon RandomWeapon()
        {
            int randomWeapon = rng.Next(4);
            switch (randomWeapon)
            {
                case 0:
                    return new MeleeWeapon(MeleeWeapon.Types.DAGGER,999,999);
                    break;
                case 1:
                    return new MeleeWeapon(MeleeWeapon.Types.LONGSWORD, 999, 999);
                    break;
                case 2:
                    return new RangedWeapon(RangedWeapon.Types.LONGBOW, 999, 999);
                    break;
                case 3:
                    return new RangedWeapon(RangedWeapon.Types.RIFLE, 999, 999);
                    break;
                default:
                    return null;
                    break;
            }
        }

        public bool Canbuy(int num)
        {
            return buyer.characterGoldPurse > num;
        }

        public void Buy(int num)
        {
            buyer.characterGoldPurse -= shopWeapons[num].cost;
            buyer.Pickup(shopWeapons[num]);
            shopWeapons[num] = RandomWeapon();
        }

        public string DisplayWeapon(int num)
        {
            return "Buy " + shopWeapons[num] + "(" + shopWeapons[num].cost + ")";
        }
    }
}
