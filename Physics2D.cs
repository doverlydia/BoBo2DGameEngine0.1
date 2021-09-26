using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public static class Physics2D
    {
        public static float Gravity { get; set; }
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
            Vector2 ret = new (b.X - a.X, b.Y - a.Y);
            ret.Normalize();
            return ret;
        }

        //this class should handle and resolve collisions
        //each frame chack all colliders against eachother and determine if any collisions have been registred. if so resolve it by moving the objects in a way that they will not collide.


        //public static void ResolveCollision(Manifold m)
        //{
        //    Vector2 relVelocity = m.B.Velocity - m.A.Velocity;
        //    //Finds out if the objects are moving towards each other.
        //    //We only need to resolve collisions that are moving towards, not away.
        //    float velAlongNormal = PhysicsMath.DotProduct(relVelocity, m.Normal);
        //    if (velAlongNormal > 0)
        //        return;
        //    float e = Math.Min(m.A.Restitution, m.B.Restitution);

        //    float j = -(1 + e) * velAlongNormal;
        //    j /= m.A.InvertedMass + m.B.InvertedMass;

        //    Vector2 impulse = j * m.Normal;
        //    m.A.Velocity -= m.A.InvertedMass * impulse;
        //    m.B.Velocity += m.B.InvertedMass * impulse;
        //}
    }
}
