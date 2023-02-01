using System;
using System.Collections.Generic;
using MindBox.Interface;
using MindBox.Model;
using NUnit.Framework;
using Type = MindBox.Model.Type;


    [TestFixture]
    public class ShapeFabricTests
    {
        private ShapeFabric _shapeFabric;

        [SetUp]
        public void SetUp()
        {
            _shapeFabric = new ShapeFabric();
        }
        
        [Test]
        [TestCase(1,15,20)]
        [TestCase(15,12)]
        public void CreateThrowException(int a, int b=0, int c=0)
        {
            double[] lenth = {a,b,c};
            List<double> param = new List<double>();
            for (int i = 0; i < lenth.Length; i++)
            {
                if (lenth[i]>0)
                {
                    param.Add(lenth[i]);
                }
            }
            lenth = param.ToArray();
            Assert.Throws<ArgumentException>(() => _shapeFabric.Create(Type.Circle, lenth));
        }
        
        [Test]
        [TestCase(Type.Circle, 2,12,24)]
        [TestCase(Type.Triangel,15,4,12)]
        [TestCase(Type.Circle,25)]
        public void CreateShapeIsEquilResult(Type t, int a=0, int b=0, int c=0)
        {
            Type result = Type.none;
            double[] data =
            {
                a,b,c
            };
            List<double> param = new List<double>();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i]>0)
                    param.Add(data[i]);
            }
            data = param.ToArray();

            IShape obj = _shapeFabric.Create(data);
            
            if (data.Length==1)
                result = Type.Circle;
            else if (data.Length==3)  
                result = Type.Triangel;
            
            Assert.True(result==obj.GetShape() , $"{obj.GetShape()}");
        }
        
        [Test]
        [TestCase(17,2,4)]
        [TestCase(1,12,6)]
        [TestCase(3)]
        [TestCase(1)]
        public void CreateShapeIsEquilResult(int a=0, int b=0, int c=0)
        {
            Type result = Type.none;
            double[] data =
            {
                a,b,c
            };
            List<double> param = new List<double>();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i]>0)
                    param.Add(data[i]);
            }
            data = param.ToArray();
            
            IShape obj = _shapeFabric.Create(data);
            if (data.Length==1)
                result = Type.Circle;
            else if (data.Length==3)  
                result = Type.Triangel;
            
            Assert.True(result==obj.GetShape() , $"{obj.GetShape()}");
        }
    }


