using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    abstract class EnemyTile : CharacterTile
    {
        bool moveSuccess;
        public CharacterTile[] targets;

        private int hitPoints;
        private int attackPower;

        public EnemyTile(Position position, int hitPoints, int attackPower) : base(position, hitPoints, attackPower)
        {
            this.Position = position;
            this.hitPoints = hitPoints;
            this.attackPower = attackPower;
        }
        public bool MoveSuccess
        {
            get { return moveSuccess; }
            set { moveSuccess = value; }
        }

        public abstract bool GetMove(Tile tile)      //error
        {
           return MoveSuccess;
        }


        public CharacterTile[] Targets
        {
            get { return targets; }
            set { targets = value; }
        }

        public abstract CharacterTile[] GetTargets()          //error
        {
            get { return Targets; }
        }

        
    }
    
}
