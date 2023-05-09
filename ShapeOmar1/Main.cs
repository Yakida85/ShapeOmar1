using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeOmar1
{
   public class Program 

    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[20];
            float SumArea =  0;

            for (int i = 0; i < 20; i++)
            {
                shapes[i] = Shape.GenerateShape();//skapa random figure 
                ///*Console*/.WriteLine($"Generated shape {i + 1} has Type {shapes[i].ShapeType} The shape area is : {shapes[i].Area}");
                Console.WriteLine(shapes[i].ToString());
                SumArea += shapes[i].Area;
            }

            Console.WriteLine("GenomSnittet på alla shapes = " + SumArea/20f);
        }
    }
}
