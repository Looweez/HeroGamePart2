using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public enum Direction
    {
        Up = 0,
        Down = 1,
        Left = 3,
        Right = 2,
        None = 4
    }

    public class Level
    {
        public Tile[,] tiles;
        private EnemyTile[] enemies;
        private PickupTile[] pickups;
        private int width;
        private int height;

        private HeroTile hero;

        public int Width
        { 
            get { return width; } 
            set {  width = value; } 
        } 
        
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public Level(int width, int height, int numEnemies, int numPickups, HeroTile hero = null)
        {
            this.width = width;
            this.height = height;

            tiles = new Tile[width, height]; 
            enemies = new EnemyTile[numEnemies];
            pickups = new PickupTile[numPickups];
            for (int i = 0; i < numEnemies; i++)
            {
                CreateTile(TileType.Enemy, GetRandomEmptyPosition());
            }
            for (int i = 0; i < numPickups; i++)
            {
                CreateTile(TileType.PickUp, GetRandomEmptyPosition());
            }
            InitialiseTiles();

            if (hero == null)
            {
                CreateTile(TileType.Hero, GetRandomEmptyPosition());
            }
            else
            {
                hero.position = GetRandomEmptyPosition();
                tiles[hero.position.X, hero.position.Y] = hero;
            }
        }

        public enum TileType
        {
            Empty,
            Wall,
            Hero,
            Exit,
            Enemy,
            PickUp
        }

        //Private CreateTile method
        // Task

        private Tile CreateTile(TileType type, Position position)
        {
            switch (type)
            {
                case TileType.Empty:
                    {
                        EmptyTile emptyTile = new EmptyTile(position);
                        tiles[position.X, position.Y] = emptyTile;
                        return emptyTile;
                    }
                case TileType.Wall:
                    {
                        WallTile wallTile = new WallTile(position);
                        tiles[position.X, position.Y] = wallTile;
                        return wallTile;
                    }
                case TileType.Hero:
                    {
                        HeroTile heroTile = new HeroTile(position,40,5);
                        tiles[position.X, position.Y] = heroTile;
                        return heroTile;
                    }
                case TileType.Exit:
                    {
                        ExitTile exitTile = new ExitTile(position);
                        tiles[position.X, position.Y] = exitTile;
                        return exitTile;
                    }
                case TileType.Enemy:
                    {
                        GruntTile enemyTile = new GruntTile(position);
                        tiles[position.X, position.Y] = enemyTile;
                        return enemyTile;
                    }
                case TileType.PickUp:
                    {
                        HealthPickupTile pickupTile = new HealthPickupTile(position);
                        tiles[position.X, position.Y] = pickupTile;
                        return pickupTile;
                    }
                default:
                    {
                        EmptyTile emptyTile = new EmptyTile(position);
                        tiles[position.X, position.Y] = emptyTile;
                        return emptyTile;
                    }
            }
        }

        private Tile CreateTile(TileType type, int  x, int y) 
        {
            Position position = new Position(x, y);

            return CreateTile(type, position);
        }

        public void InitialiseTiles()
        {
            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    if (i > 0 && i < tiles.GetLength(0) - 1 &&
                        j > 0 && j < tiles.GetLength(1) - 1)
                    {
                        CreateTile(TileType.Empty, i, j);
                    }
                    else
                    {
                        CreateTile(TileType.Wall, i, j);
                    }
                }
            }
        }

        private Position GetRandomEmptyPosition()
        {
            // Find an empty tile and return it
            Position aGoodPosition;
            Random random = new Random();
            int randomXposition;
            int randomYposition;

            do
            {
                randomXposition = random.Next(1, tiles.GetLength(0));
                randomYposition = random.Next(1, tiles.GetLength(1));
            }
            while (tiles[randomXposition, randomYposition].Display != '.');

            aGoodPosition = new Position(randomXposition, randomYposition);
            return aGoodPosition;
        }

        public HeroTile Hero
        {
            get { return hero; }
        }

        public PickupTile[] Pickups 
        { 
            get { return pickups; } 
        }

        public EnemyTile[] Enemies
        {
            get { return Enemies; }
        }

        public void SwopTiles(Tile tile1, Tile tile2)
        {
            Tile tempObject = tile1;

            tile1.Position = tile2.Position;
            tile2.Position = tempObject.Position;

            // Update the x and y positions of the tiles

            tiles[tile1.Position.X, tile1.Position.Y] = tile1;
            tiles[tile1.Position.X, tile1.Position.Y] = tile2;
        }

        public void UpdateVision() //da fuk is an instance field
        {
            hero.UpdateVision(level); //idk man
            
        }

        public override string ToString()
        {
            string mapAsString = "";

            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    mapAsString += tiles[i, j].Display.ToString();
                }
                mapAsString += "\n";
            }

            return mapAsString;
        }

    }
}
