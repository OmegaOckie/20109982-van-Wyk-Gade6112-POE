using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_van_Wyk_POE
{
    //Q.3.3 | Create GameEngine Class
    class GameEngine
    {
        //Q.3.3 | Declare variables
        private Map myMap {get; set;}

        public GameEngine(int inputMapMinWidth, int inputMapMaxWidth, int inputMapMinHeight, int inputMapMaxHeight, int amountOfGold)
        {
            //Creates a Map object with hardcoded amount of enemies
            myMap = new Map(inputMapMinWidth, inputMapMaxWidth, inputMapMinHeight, inputMapMaxHeight, 5, amountOfGold);
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
    }
}
