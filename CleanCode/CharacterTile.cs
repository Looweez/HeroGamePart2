using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public abstract class CharacterTile : Tile
    {
        private int hitPoints;
        private int maxHitPoints;
        private int attackPower;

        private Tile[] vision;

        public CharacterTile(Position position, int hitPoints, int attackPower) : base(position) 
        {
            this.hitPoints = hitPoints;
            this.Position = position;
            this.maxHitPoints = maxHitPoints;
            this.attackPower = attackPower;

            vision = new Tile[4]; 
        }

        public Tile[] Vision
        {
            get { return vision; }
            set { vision = value; }
        }

        public override char Display
        {
            get { return '.'; }
        }

        public void UpdateVision(Level level)
        {
            vision[0] = level.tiles[Position.X,Position.Y-1]; //NORTH
            vision[1] = level.tiles[Position.X+1, Position.Y]; //EAST
            vision[2] = level.tiles[Position.X, Position.Y+1]; //SOUTH
            vision[3] = level.tiles[Position.X-1, Position.Y]; //WEST
        }

        public void TakeDamage(int damage)
        {
            hitPoints -= damage;

            if (hitPoints <= 0)
            {
                hitPoints = 0; 
            }
        }

        public void Attack(CharacterTile tile)
        {
            tile.TakeDamage(attackPower);
        }

        public bool IsDead
        {
            get
            {
                if (hitPoints < 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
