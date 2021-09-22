using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public struct Vector2
    {
        public int x { get; set; }
        public int y { get; set; }
        public Vector2(int X, int Y)
        {
            x = X;
            y = Y;
        }

        void Add(Vector2 other)
        {
            x += other.x;
            y += other.y;
        }
        void Substruct(Vector2 other)
        {
            x -= other.x;
            y -= other.y;
        }
        void Multiply(Vector2 other)
        {
            x *= other.x;
            y *= other.y;
        }
    }
}
