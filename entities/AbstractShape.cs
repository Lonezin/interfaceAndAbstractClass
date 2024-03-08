using HerdarEContrato.enums;

namespace HerdarEContrato.entities
{
    public abstract class AbstractShape : IShape
    {
        public Cor Color  { get; set; }

        public abstract double Area();
    }
}