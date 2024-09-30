using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public class HealthPickupTile : PickupTile
    {
        public HealthPickupTile(Position position) : base(position) 
        { 
            this.Position = position;
        }

        //weird ass implementation method between these two

        public override char Display
        {
            get { return '+'; }
        }
    }
}
