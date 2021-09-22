using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class BoxCollider2D : Component
    {
        public Transform transform { get; private set; }
        public float left => transform.position.x;
        public float right => transform.position.x + transform.scale.x;
        public float top => transform.position.y ;
        public float bottom => transform.position.y + transform.scale.y;

        public BoxCollider2D() : base()
        {
            transform = new Transform();
        }
        public BoxCollider2D(Transform transform) : base()
        {
            this.transform = transform;
        }
        public BoxCollider2D(Vector2 scale) : base()
        {
            transform = new Transform(new Vector2(), scale);
        }
        public BoxCollider2D(Vector2 scale, Vector2 position) : base()
        {
            transform = new Transform(position, scale);
        }

        public bool AABB(BoxCollider2D boxA, BoxCollider2D boxB)
        {
            return
                boxA.left < boxB.right &&
                boxA.right > boxB.left &&
                boxA.top < boxB.bottom &&
                boxA.bottom > boxB.top;
        }
    }
}
