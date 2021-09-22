using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class Transform : Component
    {
        public Vector2 position { get; private set; }
        public Vector2 scale { get; private set; }

        public Transform() : base()
        {
            position = new Vector2();
            scale = new Vector2();
        }
        public Transform(Vector2 position) : base()
        {
            this.position = position;
            scale = new Vector2();
        }
        public Transform(Vector2 position, Vector2 scale) : base()
        {
            this.position = position;
            this.scale = scale;
        }
    }
}
