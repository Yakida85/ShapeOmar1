using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShapeOmar1
{
    public class Cuboid : SHape3D
    {
        public override Vector3 Center => _center;
        private Vector3 _center;
        private Vector3 Size;
        private Vector3 ShapeName ;
        public Cuboid(Vector3 center , Vector3 size) 
        {
            _center = center;
            Size = size;

        } 
        public Cuboid(Vector3 center , float Withd ) 
        { 
            _center = center;
            Size = new Vector3(Withd, Withd, Withd);
        }
        public bool IsCube => Size.X == Size.Y && Size.Z == Size.X;
        public override float Area => 2 * ((Size.Z * Size.X) + (Size.Z * Size.Y) + Size.Y * Size.X);

        public override float Volume => Size.X * Size.Y * Size.Z;
       

        public override String ShapeType =>   IsCube ? "Cube": "Cuboid";

        public override string ToString()
        {
            
            return $"{ShapeType} @({Center.X:F1}, {Center.Y:F1}, {Center.Z:F1}): w = {Size.X:F1}, h = {Size.Y:F1} , l = {Size.Z:F1}";
        }
    }
}
