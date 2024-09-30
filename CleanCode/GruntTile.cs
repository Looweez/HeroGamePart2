using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    internal class GruntTile : EnemyTile
    {
        public GruntTile(Position position) : base(position, 10, 1)
        {

        }

        public override char Display
        {
            get
            {
                if (IsDead == false)
                {
                    return 'Ϫ';
                }
                else
                {
                    return 'X';
                }
            }
        }
        //do rest of 2.2


    }
}
