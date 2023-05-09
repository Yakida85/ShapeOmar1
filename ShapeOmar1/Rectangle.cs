using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShapeOmar1
{
    public class Rectangle : Shape2D
        

    {
        private Vector3 center1;
        private Vector2 size1;
        private float wdith1;
        private string ShapeName;
        public override Vector3 Center => center1;
        public  Rectangle (Vector2 center , Vector2 size)
        {
            center1 = new Vector3(center.X, center.Y, 0.0F);
            size1 = size;
        }
        public Rectangle( Vector2 center, float wdith)
            : this (center , new Vector2(wdith,wdith))
        {
        }
        
       
        public override float Circumference => 2*(center1.X)+2*(center1.X);

        public override float Area => center1.X*center1.Y;

       

        public override string ShapeType => ShapeName = IsSquare ? "Square" : "Rectangle";
        public bool IsSquare => size1.X == size1.Y;

        public override string ToString()
        {
            ShapeName =  IsSquare ? "Square" : "Rectangle";
            return $"{ShapeName} @({center1.X}, {center1.Y}) w: {size1.X} h: {size1.Y}";
        }
    }
}
