using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace BoBo2DGameEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Collider2D col1 = new(new Vector2(3, 5), new Vector2(1, 2));
            Collider2D col2 = new(new Vector2(3, 5), new Vector2(1, 2));
            Console.WriteLine(col2.AABB(col1, col2));
        }
    }
}
