using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Numerics;
using ShapeOmar1;

public class Sphere : SHape3D
{

    private Vector3 center;
    private float radius;

    public Sphere(Vector3 center, float radius)
    {
        this.center = center;
        this.radius = radius;
    }

    public override float Volume => 4f / 3f * MathF.PI * MathF.Pow(radius, 3);
    public override Vector3 Center => center;
    public override float Area => 4f * MathF.PI * MathF.Pow(radius, 2);
    public override String ShapeType => "Sphere";

    public override string ToString()
    {
        return $"sphere @({center.X:F1}, {center.Y:F1}, {center.Z:F1}): r = {radius:F1}";
    }

   
}
