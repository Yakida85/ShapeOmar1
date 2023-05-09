using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShapeOmar1
{
     public abstract class  Shape
    {
        public abstract float Area { get; }
        public abstract Vector3 Center { get;  }
       
        public abstract String ShapeType { get; }
        public static Shape GenerateShape()
        {
            Random rand = new Random();
            int shapeType = rand.Next(6); //välja en siffra mellan 0-5
                                          // skapa figure beronde av slumpmassig siffra
            switch (shapeType)
            {
                case 0:
                    return new Circle(new Vector2(Shape.RandNum(), Shape.RandNum()), Shape.RandNum()); ;

                case 1:
                    // Rektangel
                    return new Rectangle(new Vector2(Shape.RandNum(), Shape.RandNum()), new Vector2(Shape.RandNum(), Shape.RandNum()));

                case 2:
                    // Kvadrat
                    int sQ = Shape.RandNum(); // eftersom den är en kvadrat då båda bredd och hjöd  ska har samma slumpmissig siffra 
                    return new Rectangle(new Vector2(sQ, sQ), new Vector2(sQ, sQ));


                case 3:
                    // Kuboid
                    return new Cuboid(new Vector3(Shape.RandNum(), Shape.RandNum(), Shape.RandNum()), new Vector3(Shape.RandNum(), Shape.RandNum(), Shape.RandNum()));

                case 4:
                    // Kub
                    int Qu = Shape.RandNum(); // eftersom den är en kub då båda bredd , höjd och djup ska har samma slumpmissig siffra
                    return new Cuboid(new Vector3(Qu, Qu, Qu), new Vector3(Qu, Qu, Qu));


                case 5:
                    // Sfär
                    return new Sphere(new Vector3(Shape.RandNum(), Shape.RandNum(), Shape.RandNum()), Shape.RandNum());

                default:
                    throw new Exception("Oväntat fel i GenerateShape!");
            }
        }
        private static int RandNum()
        { //extra function som hjälpa till skapa slumpmissig siffra
            Random rand = new Random();

            int Num = rand.Next(1, 10);
            return Num;
        }
    }
}
