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

        public Transform() : base()
        {
            Position = new Vector2();
            Scale = new Vector2();
        }
        public Transform(Vector2 position) : base()
        {
            this.Position = position;
            Scale = new Vector2();
        }
        public Transform(Vector2 position, Vector2 scale) : base()
        {
            this.Position = position;
            this.Scale = scale;
        }
    }
}
