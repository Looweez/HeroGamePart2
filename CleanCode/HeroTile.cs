using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public class HeroTile : CharacterTile
    {
        public Position position;

        private int hitPoints;
        private int maxHitPoints;
        private int attackPower;

        private Tile[] vision;

        public HeroTile(Position position, int hitPoints, int attackPower) : base (position, 40, 5)
        {
            this.position = position;
            this.hitPoints = hitPoints;
            this.attackPower = attackPower;
            this.maxHitPoints = hitPoints;
        }

        public override char Display
        {
            get
            {
                if (IsDead == false)
                {
                    return '▼';
                }
                else
                {
                    return 'x';
                }
            }
        }
    }
}
