using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20109982_van_Wyk_POE
{
    //Q.3.3 | Create GameEngine Class
    class GameEngine
    {
        //Q.3.3 | Declare variables
        private Map myMap {get; set;}
        public RichTextBox mapTextBox { get; set; }

        //Shop myShop = new Shop(player);
        
        
        
        public GameEngine(int inputMapMinWidth, int inputMapMaxWidth, int inputMapMinHeight, int inputMapMaxHeight, int amountOfGold, int weaponDrops)
        {
            //Creates a Map object with hardcoded amount of enemies
            myMap = new Map(inputMapMinWidth, inputMapMaxWidth, inputMapMinHeight, inputMapMaxHeight, 0, amountOfGold, weaponDrops);
            myMap.mapTextBox = mapTextBox;
        }



        public bool MovePlayer(Character.Movement direction)
        {

            switch (direction)
            {
                case Character.Movement.UP:
                    //if (myMap.GetItemAtPosition(x-1, y)
                    //{
                    //    myMap.GetItemAtPosition(x, y);
                    //}
                    return true;
                    break;
                case Character.Movement.DOWN:

                    return true;
                    break;
                case Character.Movement.LEFT:

                    return true;
                    break;
                case Character.Movement.RIGHT:

                    return true;
                    break;
                default:
                    return false;
                    break;
            }
        }

        private void EnemyAttacks()
        {
            foreach (var enemy in myMap.EnemyArray)
            {

            }
        }

        private void MoveEnemeies()
        {

        }

        public void Redrawmap()
        {
            mapTextBox.Text = myMap.DisplayMap();
        }
    }
}
