using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public abstract class Tile
    {
        private Position position;

        private int XPosition
        {
            get {  return position.X; }
            set { position.X = value; }
        }

        private int YPosition
        {
            get { return position.Y; }
            set { position.Y = value; }
        }

        public Tile(Position position)
        {
            this.position = position;
        }

        public abstract char Display
        { 
            get; 
        }

        //Tip from Q.4.3
        public Position Position
        {
            get { return this.position; }
            set { this.position = value; }
        }
    }
}
