using System;
using BuilderPattern.Interfaces;

namespace BuilderPattern.Classes
{
    public class Director
    {
        public IBuilder builder;

        public void Construct()
        {
            builder.BuildInk();
            builder.BuildBall();
            builder.BuildInkCatridge();
            builder.BuilderOuterhousing();
        }
    }
}
