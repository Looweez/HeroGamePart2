using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    internal class HealthPickupTile : PickupTile
    {
        public HealthPickupTile(Position position) : base(position)
        {
            this.Position = position;
        }

        //weird ass implementation method between these two
        public override Tile ApplyEffect(CharacterTile character) //error no body bc it is abstract
        {
            get;  //not sure if thats what they wanted
        }

        public override char Display
        {
            get { return '+'; }
        }
    }
}
