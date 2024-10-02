using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CleanCode.Level;

namespace CleanCode
{
    public class GruntTile : EnemyTile
    {
        private CharacterTile[] targets;

        public GruntTile(Position position) : base(position,10,1) 
        {
            this.Position = position;
        }

        public override bool GetMove(Tile Out) //body abstract error
        {
            for (int i = 0; i < vision.GetLength(1); i++) //vision error idk
            {
                if (vision[i] == TileType.Empty)
                {
                    return true;
                    Out = Vision[i];  //vision problems
                }
            }

            Out = null;
            return false;
        }

        public override CharacterTile[] GetTargets() //body abstract error
        {
            for (int i = 0; i < vision.GetLength(1); i++) //vision error idk
            {
                if (vision[i] == TileType.Hero)
                {
                    return targets = new CharacterTile[];
                    
                }
            }

            return targets = new CharacterTile[];
        }

        public override char Display
        {
            get
            {
                if (IsDead == false)
                {
                    return '▼'; //placeholder remember tochange 
                }
                else
                {
                    return 'x';
                }
            }
        }
    }
}
