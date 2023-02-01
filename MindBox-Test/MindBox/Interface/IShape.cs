using MindBox.Model;
using Type = MindBox.Model.Type;

namespace MindBox.Interface
{
    public interface IShape
    {
        public double GetArea();
        public Type GetShape();
    }
}
