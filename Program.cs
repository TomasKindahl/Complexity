using System;
using System.IO;

namespace Complexity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new(@"C:\users\nisse\test.html"))
            {
                GenHTML.Head(writer, "Generated diagrams");

                GenHTML.Write(writer, "<h1>Generated diagram 1</h1>");

                GenHTML.SVGhead(writer);
                for (int i = 0; i < 10; i++)
                {
                    GenHTML.RotTextAt($"{i*10000}", 30*i+27, 363, writer);
                }
                GenHTML.RotTextAt("100000", 327, 361, writer);

                // Here draw your statistics:
                GenHTML.Scale scale = new GenHTML.Scale { X = 1.0, Y = 1.0, xoff = 30, yoff = 40 };
                GenHTML.PointAt(writer, scale, "red", 0.0, 0.0);
                GenHTML.PointAt(writer, scale, "red", 10.0, 10.0);

                GenHTML.SVGfoot(writer);

                GenHTML.Write(writer, "<h1>Generated diagram 2</h1>");

                GenHTML.SVGhead(writer);
                for (int i = 0; i < 10; i++)
                {
                    GenHTML.RotTextAt($"{i * 10000}", 30 * i + 27, 363, writer);
                }
                GenHTML.RotTextAt("100000", 327, 361, writer);

                // Here draw your statistics:
                GenHTML.Scale scale2 = new GenHTML.Scale { X = 1.0, Y = 1.0, xoff = 30, yoff = 40 };
                GenHTML.PointAt(writer, scale2, "blue", 0.0, 0.0);
                GenHTML.PointAt(writer, scale2, "blue", 10.0, 10.0);

                GenHTML.SVGfoot(writer);

                GenHTML.Foot(writer);
            }
        }
    }
}
