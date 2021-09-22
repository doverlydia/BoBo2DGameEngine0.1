using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace BoBo2DGameEngine
{
    public class Collider2D : Component
    {
        public Transform transform { get; private set; }
        public Rectangle boxCollider2D { get; private set; }

        public Collider2D() : base()
        {
            transform = new Transform();
            boxCollider2D = new Rectangle();
        }
        public Collider2D(Transform transform) : base()
        {
            this.transform = transform;
            boxCollider2D = new Rectangle(transform.position.x, transform.position.y, transform.scale.x, transform.scale.y);
        }
        public Collider2D(Vector2 scale) : base()
        {
            transform = new Transform(new Vector2(), scale);
            boxCollider2D = new Rectangle(transform.position.x, transform.position.y, scale.x, scale.y);
        }
        public Collider2D(Vector2 scale, Vector2 position) : base()
        {
            transform = new Transform(position, scale);
            boxCollider2D = new Rectangle(transform.position.x, transform.position.y, scale.x, scale.y);
        }

        public bool AABB(Collider2D boxA, Collider2D boxB)
        {
            return
                boxA.boxCollider2D.Left < boxB.boxCollider2D.Right &&
                boxA.boxCollider2D.Right > boxB.boxCollider2D.Left &&
                boxA.boxCollider2D.Top < boxB.boxCollider2D.Bottom &&
                boxA.boxCollider2D.Bottom > boxB.boxCollider2D.Top;
        }
    }
}
