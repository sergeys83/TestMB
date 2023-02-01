using System;
using System.Collections.Generic;
using MindBox.Interface;

namespace MindBox.Model
{
    public class Triangel : IShape
    {
        private  Type _fType;
        private double square;
        private double _a;
        private double _b;
        private double _c;
        
        public Triangel(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        
        public Triangel(double[] args):this(args[0],args[1],args[2])
        {
            if (args.Length!=3)
            {
                throw new ArgumentException($"Ожидается 3 аргумента, колическтво аргументов {args.Length}, ");
            }
        }
        
        public Triangel(Type type, double[] args):this(args)
        {
            _fType = type;
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
        private void SetArea()
        {
            if (isValid())
            {
                var p = (_a + _b + _c) / 2;
                square = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
            }
        }

        public bool isValid()
        {
            bool isValidSides = _a > 0 && _b > 0 && _c > 0;
            bool isTriangel = (_a + _b > _c || _c + _b > _a || _c + _a > _b);

            return isValidSides & isTriangel;
        }

        public bool isRightTriangel()
        {
            List<double> sides = new List<double>()
            {
                _a,
                _b,
                _c,
            };
            sides.Sort();
          
            if (Math.Abs(sides[0] * sides[1] / 2 - square) < 0.0001)
                return true;
            return false;
        }
        
    }  
}


