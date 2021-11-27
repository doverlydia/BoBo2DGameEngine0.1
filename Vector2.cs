using System;
using System.Runtime.CompilerServices;

namespace BoBo2DGameEngine
{
    public struct Vector2
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Magnitude => (float)Math.Sqrt(X * X + Y * Y);

        private static readonly Vector2 _zero = new(0, 0);
        private static readonly Vector2 _one = new(1f, 1f);
        private static readonly Vector2 _up = new(0f, 1f);
        private static readonly Vector2 _down = new(0f, -1f);
        private static readonly Vector2 _left = new(-1f, 0f);
        private static readonly Vector2 _right = new(1f, 0f);

        public static Vector2 Zero => Vector2._zero;
        public static Vector2 One => Vector2._one;
        public static Vector2 Up => Vector2._up;
        public static Vector2 Down => Vector2._down;
        public static Vector2 Left => Vector2._left;
        public static Vector2 Right => Vector2._right;

        public Vector2 Normalized => new(X /= Magnitude, Y /= Magnitude);
        public Vector2 Abs => new(Math.Abs(X), Math.Abs(Y));
        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public static Vector2 Add(Vector2 vector1, Vector2 vector2)
        {
            return new Vector2(vector1.X + vector2.X, vector1.Y + vector2.Y);
        }
        public static Vector2 Subtract(Vector2 vector1, Vector2 vector2)
        {
            return new Vector2(vector1.X - vector2.X, vector1.Y - vector2.Y);
        }
        public static Vector2 DotProduct(Vector2 vector1, Vector2 vector2)
        {
            return new Vector2(vector1.X * vector2.X, vector1.Y * vector2.Y);
        }
        public static float Distance(Vector2 vector1, Vector2 vector2)
        {
            return new Vector2((vector1.X - vector2.X), (vector1.Y - vector2.Y)).Magnitude;
        }
        public float Length(Vector2 vector2) => (float)Math.Sqrt((double)vector2.X * (double)vector2.X + (double)vector2.Y * (double)vector2.Y);
        public static Vector2 Lerp(Vector2 value1, Vector2 value2, float amount)
        {
            Vector2 result = new(value1.X + (value2.X - value1.X) * amount,
                value1.Y + (value2.Y - value1.Y) * amount);
            return result;
        }

        public override string ToString()
        {
            return X + "," + Y;
        }
    }
}
