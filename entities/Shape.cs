using System.Drawing;

namespace HerdarEContrato.entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}