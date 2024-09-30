using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode
{
    public class Position
    {
        //Q.2.1
        private int xPosition;
        private int yPosition;

        public Position(int xPosition, int yPosition)
        {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }   

        public int X 
        { 
            get { return xPosition;}
            set { xPosition = value; }
        }

        public int Y 
        {
            get { return yPosition; }
            set { yPosition = value; }
        }


    }
}
