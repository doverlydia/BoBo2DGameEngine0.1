using System;

namespace BoBo2DGameEngine
{
    public struct Vector2 : IEquatable<Vector2>
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Magnitude => (float)Math.Sqrt(X * X + Y * Y);

        private static readonly Vector2 _zero = new Vector2();
        private static readonly Vector2 _one = new Vector2(1f, 1f);
        public static Vector2 Zero => Vector2._zero;
        public static Vector2 One => Vector2._one;

        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
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

        public bool Equals(Vector2 other) => X == other.X && Y == other.Y;
        public float Length() => (float)Math.Sqrt((double)this.X * (double)this.X + (double)this.Y * (double)this.Y);
        public Vector2 Lerp(ref Vector2 value1, ref Vector2 value2, float amount)
        {
            Vector2 result = new()
            {
                X = value1.X + (value2.X - value1.X) * amount,
                Y = value1.Y + (value2.Y - value1.Y) * amount
            };
            return result;
        }
    }
}
