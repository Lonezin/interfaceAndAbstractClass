using System.Globalization;

namespace HerdarEContrato.entities
{
    public class Circle : AbstractShape
    {
        public double Radius { get; set;}
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override string ToString()
        {
            return $"Circle color = {Color}\nRadius = {Radius.ToString("F2", CultureInfo.InvariantCulture)}\n" +
            $"Area = {Area().ToString("F2", CultureInfo.InvariantCulture)}";;
        }
    }
}