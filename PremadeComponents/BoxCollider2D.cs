using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class BoxCollider2D : Component
    {
        public Vector2 Size { get; private set; } = new(1, 1);
        public float Left => GameObject.Transform.Position.X;
        public float Right => GameObject.Transform.Position.X + Size.X * GameObject.Transform.Scale.X;
        public float Bottom => GameObject.Transform.Position.Y;
        public float Up => GameObject.Transform.Position.Y + Size.Y * GameObject.Transform.Scale.Y;

        #region Bounds
        public Vector2 Center => GameObject.Transform.Position;
        #endregion

        public BoxCollider2D(GameObject gameObject) : base(gameObject)
        {
            Physics2D.Colliders2D.Add(this);
        }


        public override void OnEnable()
        {
            Console.WriteLine(GameObject + ": Box Collider OnEnable!");
        }

        public override void Start()
        {
            Console.WriteLine(GameObject + ": Box Collider Start!");
        }

        public override void Update()
        {
            Console.WriteLine(GameObject + ": Box Collider Update!");
        }

        public virtual void OnCollision()
        {
            Console.WriteLine(GameObject + ": OnCollision!");
        }
    }
}
