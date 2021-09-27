using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class Transform : Component
    {
        public Vector2 Position { get; private set; }
        public Vector2 Scale { get; private set; }

        public Transform(GameObject gameObject) : base(gameObject)
        {
            Position = new Vector2();
            Scale = new Vector2();
        }
        public Transform(GameObject gameObject, Vector2 scale) : base(gameObject)
        {
            Position = new Vector2();
            Scale = scale;
        }
    }
}
