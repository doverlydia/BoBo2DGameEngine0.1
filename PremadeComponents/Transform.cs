using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class Transform : Component
    {
        public Vector2 GlobalPosition => GameObject.Parent != null ? Vector2.Add(LocalPosition, GameObject.Parent.Transform.Position) : LocalPosition;
        public Vector2 LocalPosition { get; private set; }
        public Vector2 Position
        {
            get => GlobalPosition;
            set => LocalPosition = value;
        }
        public Vector2 GlobalScale => GameObject.Parent != null ? Vector2.Add(LocalScale, GameObject.Parent.Transform.Scale) : LocalScale;
        public Vector2 LocalScale { get; private set; } = Vector2.One;
        public Vector2 Scale
        {
            get => GlobalScale;
            set => LocalScale = value;
        }
        public Transform(GameObject gameObject) : base(gameObject)
        {
        }
    }
}
