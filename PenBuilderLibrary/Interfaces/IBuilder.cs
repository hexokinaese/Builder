using BuilderPattern.Classes;

namespace BuilderPattern.Interfaces
{
    public interface IBuilder
    {
        void BuildInk();
        void BuildBall();
        void BuildInkCatridge();
        void BuilderOuterhousing();
        Pen GetPen();
    }
}
