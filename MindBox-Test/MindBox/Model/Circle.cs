using System;
using MindBox.Interface;

namespace MindBox.Model
{
    public class Circle : IShape
    {
        private double square;
        private double radius;
        private readonly Type _fType;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double[] args) : this(args[0])
        {
            if (args.Length!=1)
            {
                throw new ArgumentException($"Ожидается 1 аргумент, колическтво аргументов {args.Length}, ");
            }
        }
        
        public Circle(Type type, double[] args):this(args)
        {
            _fType = type;
        }

        private void SetArea()
        {
            if (isValid())
                square = (Math.PI) * Math.Pow(radius,2) ;
        }

        public Type GetShape()
        {
            return _fType;
        }
        
        public double GetArea()
        {
            SetArea();
            return square;
        }

        public bool isValid()
        {
            bool isCircle = radius>0;
            return isCircle;
        }
    }  
}


