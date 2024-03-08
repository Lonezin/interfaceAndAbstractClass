using HerdarEContrato.entities;
using HerdarEContrato.enums;

namespace Atividade
{
    class Program
    {
        static void Main (string[] args)
        {
            IShape s1 = new Circle() { Radius = 2, Color = Cor.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Cor.Black };
            System.Console.WriteLine(s1);
            System.Console.WriteLine(s2);
        }
    }
}