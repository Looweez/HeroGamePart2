using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public abstract class PickupTile : Tile
    {
        public PickupTile(Position position) : base(position)
        {
            this.Position = position;
        }

        public abstract Tile ApplyEffect(CharacterTile character) //error no body bc it is abstract
        {
            get;  //not sure if thats what they wanted
        }


    }
}
