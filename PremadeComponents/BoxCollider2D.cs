using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class BoxCollider2D : Component
    {
        public Transform Transform { get; private set; }
        public float Left => Transform.Position.X;
        public float Right => Transform.Position.X + Transform.Scale.X;
        public float Top => Transform.Position.Y ;
        public float Bottom => Transform.Position.Y + Transform.Scale.Y;

        public BoxCollider2D() : base()
        {
            Transform = new Transform();
        }
        public BoxCollider2D(Transform transform) : base()
        {
            this.Transform = transform;
        }
        public BoxCollider2D(Vector2 scale) : base()
        {
            Transform = new Transform(new Vector2(), scale);
        }
        public BoxCollider2D(Vector2 scale, Vector2 position) : base()
        {
            Transform = new Transform(position, scale);
        }

        public bool AABB(BoxCollider2D boxA, BoxCollider2D boxB)
        {
            return
                boxA.Left < boxB.Right &&
                boxA.Right > boxB.Left &&
                boxA.Top < boxB.Bottom &&
                boxA.Bottom > boxB.Top;
        }

        public override void Update()
        {
            Console.WriteLine("Box Collider Update");
        }
    }
}
