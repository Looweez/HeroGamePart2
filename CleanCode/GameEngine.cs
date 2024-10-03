using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public enum GameState
    {
        InProgress,
        Complete,
        GameOver
    }

    public class GameEngine
    {
        //Q.2.5
        //Fields
        private Level level;
        private int numLevels;
        private Random random;
        private GameState state = GameState.InProgress;
        

        const int MIN_SIZE = 10;
        const int MAX_SIZE = 20;    

        public GameEngine(int numLevels) 
        {
            this.numLevels = numLevels;
            random = new Random();
            level = new Level(random.Next(MIN_SIZE,MAX_SIZE),random.Next(MIN_SIZE, MAX_SIZE),3,1); //dunno if theres supposed to be 3 grunts/enemies
        }

        private bool MoveHero(Direction direction)
        {
            Tile  target = level.Hero.Vision[(int)direction];

            if (target is PickupTile)
            {
                PickupTile.ApplyEffect(HeroTile);
                level.SwopTiles(level.Hero, target);
                level.Hero.UpdateVision(level);
                return true;
            }
            else if (target is ExitTile)
            {
                if (numLevels == numLevels) //if current level is last level
                {
                    state = GameState.Complete;
                    return false;
                }
                else
                {
                    NextLevel();
                    return true;
                }
            }
            else if (target is EmptyTile)
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

        public void NextLevel()
        {
            numLevels++;
            HeroTile currentHero = level.Hero;
            level = new Level(random.Next(MIN_SIZE, MAX_SIZE), random.Next(MIN_SIZE, MAX_SIZE), 3, 1, currentHero);
        }

        public override string ToString()
        {
            if (state == GameState.Complete)
            {
                return "You have completed the game!";
            }
            else if (state == GameState.InProgress)
            {
                return level.ToString();
            }
            //else if (state == GameState.GameOver)
            //{

            //}
        }
    }
}
