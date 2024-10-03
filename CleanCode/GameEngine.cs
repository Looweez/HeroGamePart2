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
        private bool attackSuccess;

        private GameState state = GameState.InProgress;

        const int MIN_SIZE = 10;
        const int MAX_SIZE = 20;    

        public GameEngine(int numLevels) 
        {
            this.numLevels = numLevels;
            random = new Random();
            level = new Level(random.Next(MIN_SIZE,MAX_SIZE),random.Next(MIN_SIZE, MAX_SIZE),3,1);
        }

        private bool MoveHero(Direction direction)
        {
            Tile target = level.Hero.Vision[(int)direction];

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
            if (state == GameState.GameOver)              //idk if this is right (pg 35)
            {
                return;
            }

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
            else if (state == GameState.GameOver)
            {
                return "Game over!";
            }
        }

        //q.3.1
        public bool HeroAttack(Direction direction)
        {
            // retrieve attack target tile from vision array

            Tile target = level.Hero.Vision[(int)direction];
            if (target is CharacterTile)
            {
                Attack(target);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void TriggerAttack(Direction direction)
        {
            if (state == GameState.GameOver)              //idk if this is right (pg 35)
            {
                return;
            }
            HeroAttack(direction);
        }


        //q.3.2
        private void EnemiesAttack()
        {
            // pg 34

            if (IsDead == true)
            {
                return state = GameState.GameOver;
            }
        }

        public string HeroStats
        {
            get { return HeroStats; }
            // return heroes hitpoints to the label? (pg 36)
        }
    }
}
