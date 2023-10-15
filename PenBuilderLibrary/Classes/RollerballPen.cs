using System;
using BuilderPattern.Interfaces;

namespace BuilderPattern.Classes
{
    public class RollerballPen : IBuilder
    {
        Pen pen = new Pen();

        public void BuildBall()
        {
            this.pen.Add("ball");
        }

        public void BuilderOuterhousing()
        {
            this.pen.Add("outerhousing");
        }

        public void BuildInk()
        {
            this.pen.Add("water-based ink");
        }

        public void BuildInkCatridge()
        {
            this.pen.Add("ink cartridge");
        }

        public Pen GetPen()
        {
            return pen; 
        }
    }
}
