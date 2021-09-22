using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public struct Vector2
    {
        public float x { get; set; }
        public float y { get; set; }
        public float Magnitude => (float)Math.Sqrt(x * x + y * y);

        public Vector2(float X, float Y)
        {
            x = X;
            y = Y;
        }

        public void Add(Vector2 other)
        {
            x += other.x;
            y += other.y;
        }
        public void Subtract(Vector2 other)
        {
            x -= other.x;
            y -= other.y;
        }
        public void DotProduct(Vector2 other)
        {
            x *= other.x;
            y *= other.y;
        }
        public float Distance(Vector2 other)
        {
            return new Vector2((x - other.x), (y - other.y)).Magnitude;
        }
        public void Normalize()
        {
            x = x / Magnitude;
            y = y / Magnitude;
        }
    }
}
