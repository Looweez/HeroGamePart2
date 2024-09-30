using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public class GameEngine
    {
        //Q.2.5
        //Fields
        private Level level;
        private int numLevels;
        private Random random;

        const int MIN_SIZE = 10;
        const int MAX_SIZE = 20;    

        public GameEngine(int numLevels) 
        {
            this.numLevels = numLevels;
            random = new Random();
            level = new Level(random.Next(MIN_SIZE,MAX_SIZE),random.Next(MIN_SIZE, MAX_SIZE));
        }

        private bool MoveHero(Direction direction)
        {
            Tile  target = level.Hero.Vision[(int)direction];

            if (target is EmptyTile)
            {
                level.SwopTiles(level.Hero, target);
                level.Hero.UpdateVision(level);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TriggerMovement(Direction direction)
        {
            MoveHero(direction);
        }

        public override string ToString()
        {
            return level.ToString();
        }
    }
}
