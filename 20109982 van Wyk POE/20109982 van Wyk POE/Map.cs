using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20109982_van_Wyk_POE
{
    //Q.3.1
    class Map
    {

        //Q.3.1 | Declare variables
        protected Tile[,] mapArray { get; set; }
        protected Hero myHero { get; set; }
        protected Enemy[] enemyArray { get; set; }
        public Enemy[] EnemyArray { get => enemyArray; set => enemyArray = value; }
        protected int mapWidth { get; set; }
        protected int mapHeight { get; set; }
        protected Random rng { get; set; }
        protected Item[,] itemArray { get; set; }

            /// <summary>
            /// Q.3.2 | A constructor that receives a minimum and maximum width, minimum and
            /// maximum height and number of enemies.
            /// </summary>
            /// <param name="minWidth"></param>
            /// <param name="maxWidth"></param>
            /// <param name="minHeight"></param>
            /// <param name="maxHeight"></param>
            /// <param name="numOfEnemies"></param>
            public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numOfEnemies, int amountOfGold)
        {
            //Q.3.2 | The method randoms a height
            //and width for the map based on the minimum and maximum values
            //provided,
            mapWidth = rng.Next(minWidth, maxWidth);
            mapHeight = rng.Next(minHeight, maxHeight);

            //Q.3.2 | creates a new 2D Tile array of that size
            mapArray = new Tile[mapWidth, mapHeight];

            //Q.3.2 | It also creates a new Enemy array based on the
            //provided size
            enemyArray = new Enemy[numOfEnemies];

            //Q.3.2 | The constructor calls Create() to create the Hero
            Create(Tile.TileType.HERO);

            //Q.3.2 | loops through the enemy’s array calling Create() to create each enemy and puts
            //them in the Tile map
            foreach (var enemy in enemyArray)
            {
                Create(Tile.TileType.ENEMY);
            }

            foreach (var item in itemArray)
            {
                Create(Tile.TileType.GOLD);
            }

            //Q.3.2 | It then calls UpdateVision() which updates the vision
            //arrays of each Character with the Tiles around the character.
            UpdateVision();
        }

        /// <summary>
        /// Q.3.2 | Updates the vision array for each Character (the
        /// hero and each enemy) by saving the character values of the map at the
        /// north, south, east and west position from the X and Y positions of the unit.
        /// </summary>
        public void UpdateVision(RichTextBox rtb)
        {


            rtb.Text = "";
            for (int i = 0; i < mapWidth; i++)
            {
                for (int o = 0; o < mapHeight; o++)
                {
                    if (i == myHero.xCoordinate + 1 && o == myHero.yCoordinate && mapArray[i, o] != null)
                    {
                        rtb.Text += mapArray[i, o].ToString() + "\n";
                    }
                    if (i == myHero.xCoordinate - 1 && o == myHero.yCoordinate && mapArray[i, o] != null)
                    {
                        rtb.Text += mapArray[i, o].ToString() + "\n";
                    }
                    if (i == myHero.xCoordinate && o == myHero.yCoordinate + 1 && mapArray[i, o] != null)
                    {
                        rtb.Text += mapArray[i, o].ToString() + "\n";
                    }
                    if (i == myHero.xCoordinate && o == myHero.yCoordinate - 1 && mapArray[i, o] != null)
                    {
                        rtb.Text += mapArray[i, o].ToString() + "\n";
                    }
                    if (i == myHero.xCoordinate + 1 && o == myHero.yCoordinate + 1 && mapArray[i, o] != null)
                    {
                        rtb.Text += mapArray[i, o].ToString() + "\n";
                    }
                    if (i == myHero.xCoordinate + 1 && o == myHero.yCoordinate - 1 && mapArray[i, o] != null)
                    {
                        rtb.Text += mapArray[i, o].ToString() + "\n";
                    }
                    if (i == myHero.xCoordinate - 1 && o == myHero.yCoordinate + 1 && mapArray[i, o] != null)
                    {
                        rtb.Text += mapArray[i, o].ToString() + "\n";
                    }
                    if (i == myHero.xCoordinate - 1 && o == myHero.yCoordinate - 1 && mapArray[i, o] != null)
                    {
                        rtb.Text += mapArray[i, o].ToString() + "\n";

                    }
                }
            }

        }

        /// <summary>
        /// Q.3.2 | This method is used to create objects
        /// and also place them on the map.The method receives what to create
        /// (Hero, Enemy and later Gold, MeleeWeapon etc.). It then generates a
        /// unique X and Y position(or rerolls a position until one exists). Then, based
        /// on the type to be created it creates a Hero or Enemy(both of which are
        /// Tiles by inheritance) with the X and Y position.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private Tile Create(Tile.TileType type)
        {
            //It then generates a unique X and Y position
            int xPos = rng.Next(mapWidth);
            int yPos = rng.Next(mapHeight);

            //generates a random enemy
            Random randomEnemy = new Random();
            int chosenEnemy = randomEnemy.Next(1, 3);

            int numOfEnemies = 0;

            switch (type)
            {
                case Tile.TileType.HERO:
                    mapArray[xPos, yPos] = myHero;
                    break;
                case Tile.TileType.ENEMY:
                    mapArray[xPos, yPos] = enemyArray[numOfEnemies];
                    numOfEnemies++;
                    if (chosenEnemy == 1)
                    {
                        return enemyArray[numOfEnemies] = new Goblin(xPos, yPos);
                    }
                    break;
                case Tile.TileType.GOLD:
                    return itemArray[xPos, yPos] = new Gold(xPos, yPos);
                    break;
                case Tile.TileType.WEAPON:
                    break;
                default:
                    break;
            }
            return null;
        }

        public Item GetItemAtPosition(int x, int y)
        {
            if (itemArray[x, y] != null)
            {
                for (int i = 0; i < mapWidth; i++)
                {
                    for (int o = 0; o < mapHeight; o++)
                    {
                        if (itemArray[i, o] != null)
                        {
                            return itemArray[i, o];
                        }
                    }
                }
            }
            return null;
        }
    }
}
