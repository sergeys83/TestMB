using System;
using MindBox.Interface;

namespace MindBox.Model
{
    public class ShapeFabric
    {
        private Type shapeType = Type.none;
        public IShape Create(Type sType, double[] args)
        {
            shapeType = sType;

            switch ((int)shapeType)
            {
                case 1:
                    return GenerateCircle(args);
                case 2:
                    return GenerateTriangel(args);
                default: throw new ArgumentException("По данным параметрам фигура не найдена");
            }
        }

        public IShape Create(double[] args)
        {
            int argsLength = args.Length;

            switch (argsLength)
            {
                case 1:
                    shapeType = Type.Circle;
                    return GenerateCircle(args);
               
                case 3:
                    shapeType = Type.Triangel;
                    return GenerateTriangel(args);
                 
                default: throw new ArgumentException("По данным параметрам фигура не найдена");
            }

        }
        private Circle GenerateCircle(double[] args)
        {
            return new Circle(shapeType, args);
        }
        private Triangel GenerateTriangel(double[] args)
        {
            return new Triangel(shapeType,args);
        }
    }

}
