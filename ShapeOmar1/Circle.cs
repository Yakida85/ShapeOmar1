using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ShapeOmar1
{
    public class Circle : Shape2D
    {
        private Vector3 _center;
        private float _radius;
        private float circumference;
        private float area;
        public override Vector3 Center => _center;
        
        public Circle(Vector2 center, float radius)
        { 
        _center = new Vector3(center.X, center.Y, 0.0F );
        _radius = radius; 
    
        }

        public override float Circumference => circumference = (_radius*2) * MathF.PI;

        public override float Area => area = MathF.Pow(_radius, 2) * MathF.PI;

        public override string ShapeType => "Circle";

        public override String ToString()
        {
            return $"Circel @({_center.X},{_center.Y}): r= {_radius}";
        }
    }
}
