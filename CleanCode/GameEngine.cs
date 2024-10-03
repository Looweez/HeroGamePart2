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
        public int successfulHeroMoves = 0;

        private Level level;
        private int numLevels;
        private Random random;
        private GameState state = GameState.InProgress;
        private int currentLevelNumber = 1;
        

        const int MIN_SIZE = 10;
        const int MAX_SIZE = 20;    

        public GameEngine(int numLevels) 
        {
            this.numLevels = numLevels;
            random = new Random();
            level = new Level(random.Next(MIN_SIZE,MAX_SIZE),random.Next(MIN_SIZE, MAX_SIZE),currentLevelNumber,1); 
        }

        private bool MoveHero(Direction direction)
        {
            Tile  target = level.Hero.Vision[(int)direction];

            if (target is PickupTile)
            {
                PickupTile.ApplyEffect(HeroTile);
                level.SwopTiles(level.Hero, target);
                level.UpdateVision();
                return true;
            }
            else if (target is ExitTile)
            {
                if (currentLevelNumber == numLevels) //if current level is last level
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
            successfulHeroMoves++;
            if (successfulHeroMoves % 2 == 0)
            {
                MoveEnemies();
            }
        }

        public void NextLevel()
        {
            numLevels++;
            currentLevelNumber++;
            HeroTile currentHero = level.Hero;
            level = new Level(random.Next(MIN_SIZE, MAX_SIZE), random.Next(MIN_SIZE, MAX_SIZE), 3, 1, currentHero);
        }

        private void MoveEnemies()
        {
            
            for (int  i = 0; i < level.enemies.Length; i++)
            {
                Tile target = level.Enemies[i].Vision[(int)direction];
                if (level.enemies[i] == IsDead) //its not letting me do disss
                {

                }
                else if () //enemytile.getmove == false
                {

                }
                else if () //enemytile.getmove == true
                {
                    level.SwopTiles(level.Enemies[i], target);
                    level.UpdateVision();
                }
            }
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
            return level.ToString();
        }
    }
}
