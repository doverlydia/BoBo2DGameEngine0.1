using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.MediaFoundation;

namespace BoBo2DGameEngine
{
    public static class Physics2D
    {
        public static readonly List<BoxCollider2D> Colliders2D = new();
        public static float Gravity { get; set; } = 9.8f;
        public static float DotProduct(Vector2 a, Vector2 b)
        {
            return a.X * b.X + a.Y * b.Y;
        }

        public static float Distance(Vector2 a, Vector2 b)
        {
            return (float)Math.Sqrt(((int)(a.X - b.X) ^ 2 + (int)(a.Y - b.Y) ^ 2));
        }

        public static Vector2 GetNormal(Vector2 a, Vector2 b)
        {
            Vector2 ret = new(b.X - a.X, b.Y - a.Y);
            return ret.Normalized;
        }
        public static bool AABB(BoxCollider2D a, BoxCollider2D b, ref Manifold m)
        {
            m.A = a;
            m.B = b;
            m.Normal = Vector2.Subtract(b.Center, a.Center);

            //Calculate the extent on the X axis
            var aExtentX = (a.Right - a.Left) / 2;
            var bExtentX = (b.Right - b.Left) / 2;

            //Find the X overlap
            var xExtent = aExtentX + bExtentX - Math.Abs(m.Normal.X);

            //SAT Test on X
            if (!(xExtent > 0)) return false;
            //There was overlap on the X axis, now lets try to Y
            var aExtentY = (a.Up - a.Bottom) / 2;
            var bExtentY = (b.Up - b.Bottom) / 2;

            //Calculate Y overlap
            var yExtent = aExtentY + bExtentY - Math.Abs(m.Normal.Y);

            //SAT Test on Y axis
            if (!(yExtent > 0)) return false;

            m.XPenetrationDepth = xExtent;
            m.YPenetrationDepth = yExtent;
            m.AreColliding = true;
            return true;
        }

        public static void ResolveCollision(ref Manifold m)
        {
            Console.WriteLine("Resolving collisions");
            if (m.A.Center.X >= m.B.Center.X)
            {
                m.A.GameObject.Transform.Position = new Vector2(m.A.GameObject.Transform.Position.X + m.XPenetrationDepth, m.A.GameObject.Transform.Position.Y);
                m.B.GameObject.Transform.Position = new Vector2(m.B.GameObject.Transform.Position.X - m.XPenetrationDepth, m.B.GameObject.Transform.Position.Y);
            }
            else
            {
                m.A.GameObject.Transform.Position = new Vector2(m.A.GameObject.Transform.Position.X - m.XPenetrationDepth, m.A.GameObject.Transform.Position.Y);
                m.B.GameObject.Transform.Position = new Vector2(m.B.GameObject.Transform.Position.X + m.XPenetrationDepth, m.B.GameObject.Transform.Position.Y);
            }

            if (m.A.Center.Y >= m.B.Center.Y)
            {
                m.A.GameObject.Transform.Position = new Vector2(m.A.GameObject.Transform.Position.X, m.A.GameObject.Transform.Position.Y + m.YPenetrationDepth);
                m.B.GameObject.Transform.Position = new Vector2(m.B.GameObject.Transform.Position.X, m.B.GameObject.Transform.Position.Y - m.YPenetrationDepth);
            }
            else
            {
                m.A.GameObject.Transform.Position = new Vector2(m.A.GameObject.Transform.Position.X, m.A.GameObject.Transform.Position.Y - m.YPenetrationDepth);
                m.B.GameObject.Transform.Position = new Vector2(m.B.GameObject.Transform.Position.X, m.B.GameObject.Transform.Position.Y + m.YPenetrationDepth);
            }
        }

        public static void CheckForCollisions()
        {
            Console.WriteLine("Checking for collisions");
            Manifold m = new();
            foreach (var t in Colliders2D)
            {
                foreach (var t1 in Colliders2D.Where(t1 => AABB(t, t1, ref m)))
                {
                    if (t == t1) continue;
                    ResolveCollision(ref m);
                    t.OnCollision();
                    t1.OnCollision();
                }
            }
        }

    }
}
