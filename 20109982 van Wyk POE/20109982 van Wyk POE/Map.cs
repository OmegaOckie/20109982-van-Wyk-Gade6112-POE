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
        public RichTextBox mapTextBox { get; set; }

        /// <summary>
        /// Q.3.2 | A constructor that receives a minimum and maximum width, minimum and
        /// maximum height and number of enemies.
        /// </summary>
        /// <param name="minWidth"></param>
        /// <param name="maxWidth"></param>
        /// <param name="minHeight"></param>
        /// <param name="maxHeight"></param>
        /// <param name="numOfEnemies"></param>
        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int numOfEnemies, int amountOfGold, int weaponDrops)
        {
            //Q.3.2 | The method randoms a height
            //and width for the map based on the minimum and maximum values
            //provided,
            rng = new Random();
            while (mapWidth == 0 || mapHeight == 0)
            {
                mapWidth = rng.Next(minWidth, maxWidth);
                mapHeight = rng.Next(minHeight, maxHeight);
            }

            //Q.3.2 | creates a new 2D Tile array of that size
            mapArray = new Tile[mapWidth, mapHeight];

            for (int i = 0; i < mapWidth; i++)
            {
                for (int j = 0; j < mapHeight; j++)
                {
                    mapArray[i, j] = new EmptyTile(i , j);
                }
            }


            // Places the border of the Map
            for (int x = 0; x < mapWidth; x++)
            {
                for (int y = 0; y < mapHeight; y++)
                {
                    if (y == mapHeight -1 || y ==0 || x == mapWidth -1|| x == 0)
                    {
                        mapArray[x, y] = new Obstacle(x, y);
                    }
                }
            }


            //}
            //Q.3.2 | It also creates a new Enemy array based on the
            //provided size
            enemyArray = new Enemy[numOfEnemies];

            //Q.3.2 | The constructor calls Create() to create the Hero
            Create(Tile.TileType.HERO);

            //Q.3.2 | loops through the enemy’s array calling Create() to create each enemy and puts
            //them in the Tile map
            //foreach (var enemy in enemyArray)
            //{
            //    Create(Tile.TileType.ENEMY);
            //}

            //foreach (var item in itemArray)
            //{
            //    Create(Tile.TileType.GOLD);
            //}

            //Q.3.2 | It then calls UpdateVision() which updates the vision
            //arrays of each Character with the Tiles around the character.
            //UpdateVision(mapTextBox);
        }

        /// <summary>
        /// Q.3.2 | Updates the vision array for each Character (the
        /// hero and each enemy) by saving the character values of the map at the
        /// north, south, east and west position from the X and Y positions of the unit.
        /// </summary>
        public void UpdateVision(RichTextBox rtb)
        {


            rtb.Text = " ";
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
                    switch (chosenEnemy)
                    {
                        case 1:
                            return enemyArray[numOfEnemies] = new Goblin(xPos, yPos);
                            break;
                        case 2:
                            return enemyArray[numOfEnemies] = new Leader(xPos, yPos);
                            break;
                        default:
                            break;
                    }
                    break;
                case Tile.TileType.GOLD:
                    return itemArray[xPos, yPos] = new Gold(xPos, yPos);
                    break;
                case Tile.TileType.WEAPON:

                    int randomWeapon = rng.Next(4);
                    switch (randomWeapon)
                    {
                        case 0:
                            return itemArray[xPos, yPos] = new MeleeWeapon(MeleeWeapon.Types.DAGGER, xPos, yPos);
                            break;
                        case 1:
                            return itemArray[xPos, yPos] = new MeleeWeapon(MeleeWeapon.Types.LONGSWORD, xPos, yPos);
                            break;
                        case 2:
                            return itemArray[xPos, yPos] = new RangedWeapon(RangedWeapon.Types.LONGBOW, xPos, yPos);
                            break;
                        case 3:
                            return itemArray[xPos, yPos] = new RangedWeapon(RangedWeapon.Types.RIFLE, xPos, yPos);
                            break;
                        default:
                            break;
                    }
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

        public string DisplayMap()
        {

            string temp = "";
            for (int i = 0; i < mapWidth; i++)
            {
                for (int j = 0; j < mapHeight; j++)
                {
                    if (mapArray[i,j] == null)
                    {
                        temp += "N";
                    }
                    temp += mapArray[i, j].ToString();
                }
                temp += "\n";
            }
            return temp;
        }
    }
}
