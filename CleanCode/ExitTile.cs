using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public class ExitTile : Tile
    {
        public ExitTile(Position position) : base(position)
        { 
            this.Position = position;
        }

        public override char Display
        {
            get { return '▒'; } //exit tile and wall tile copy paste
        }
    }
}
