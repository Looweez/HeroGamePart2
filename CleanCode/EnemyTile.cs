using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public abstract class EnemyTile : CharacterTile
    {
        private int hitPoints;
        private int attackPower;

        public EnemyTile(Position position, int hitPoints, int attackPower): base(position, hitPoints, attackPower) 
        { 
            this.Position = position;
            this.hitPoints = hitPoints;
            this.attackPower = attackPower;
        }

        public abstract bool GetMove(Tile Out) //body abstract error
        {
            return false;
        }

        public abstract CharacterTile[] GetTargets() //body abstract error
        {
            return targets = new CharacterTile[];
        }
    }
}
