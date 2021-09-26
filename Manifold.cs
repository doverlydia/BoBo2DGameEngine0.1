using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public struct Manifold
    {
        public RigidBody2D A, B;
        public float PenetrationDepth;
        public Vector2 Normal;
        public bool AreColliding;
    }
}
