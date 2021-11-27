using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public enum BodyType
    {
        Dynamic,
        Static
    }

    public class RigidBody2D : Component
    {
        private bool _useGravity;
        private BodyType _bodyType;
        public BodyType BodyType
        {
            get => _bodyType;
            set
            {
                _bodyType = value;
                _useGravity = value switch
                {
                    BodyType.Dynamic => true,
                    BodyType.Static => false,
                    _ => _useGravity
                };
            }
        }

        public float GravityScale { get; set; } = 1;

        //Implement Later
        //public Vector2 Velocity = Vector2.Zero;
        //public Vector2 Acceleration = Vector2.Zero;

        public RigidBody2D(GameObject gameObject) : base(gameObject)
        {

        }

        public override void OnEnable()
        {
            Console.WriteLine("RigidBody OnEnable!");
        }

        public override void Start()
        {
            Console.WriteLine("RigidBody Start!");
        }

        public override void Update()
        {
            Console.WriteLine("RigidBody2D Update!");
            if (_useGravity)
            {
                ApplyConstantForce(Physics2D.Gravity * GravityScale, Vector2.Down);
                Console.WriteLine("Applied "+Physics2D.Gravity*GravityScale+" Force in Direction "+Vector2.Down+" for "+GameObject.Name);
            }
        }
        public void ApplyConstantForce(float force, Vector2 dir)
        {
            Vector2 temp = new(dir.X * force, dir.Y * force);
            GameObject.Transform.Position = Vector2.Add(GameObject.Transform.Position, temp);
            Console.WriteLine("Gravity: "+Physics2D.Gravity);
            Console.WriteLine("The Vector I want To Add: "+temp);
            Console.WriteLine("My Position: "+GameObject.Transform.Position);
        }
    }
}