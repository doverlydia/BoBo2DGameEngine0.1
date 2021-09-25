using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public struct Vector2
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Magnitude => (float)Math.Sqrt(X * X + Y * Y);

        public Vector2(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public void Add(Vector2 other)
        {
            X += other.X;
            Y += other.Y;
        }
        public void Subtract(Vector2 other)
        {
            X -= other.X;
            Y -= other.Y;
        }
        public void DotProduct(Vector2 other)
        {
            X *= other.X;
            Y *= other.Y;
        }
        public float Distance(Vector2 other)
        {
            return new Vector2((X - other.X), (Y - other.Y)).Magnitude;
        }
        public void Normalize()
        {
            X /= Magnitude;
            Y /= Magnitude;
        }
    }
}
