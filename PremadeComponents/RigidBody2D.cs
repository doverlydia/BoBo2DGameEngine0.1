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
        private float _gravityScale = 1;
        private BodyType _bodyType;
        public BodyType BodyType
        {
            get => _bodyType;
            set
            {
                _bodyType = value;
                switch (value)
                {
                    case BodyType.Dynamic:
                        _useGravity = true;
                        //do stuff.
                        break;
                    case BodyType.Static:
                        _useGravity = false;
                        //do stuff.
                        break;
                }
            }
        }

        public Vector2 Velocity = Vector2.Zero;
        public Vector2 Acceleration = Vector2.Zero;
        private float _mass = 1f;
        public float InvertedMass { get; private set; }
        public float Restitution = 0f;
        public float Drag = 1f;
        public float Angle = 0f;
        public float AngularVelocity = 0f;
        public float AngularAcceleration = 0f;
        public float AngularDrag = 0f;
        public Vector2 Position;
        public BoxCollider2D BoxCollider2D;

        public float Mass
        {
            get => _mass;
            set
            {
                if (value < 0) throw new Exception("Mass cannot be less than zero!");
                _mass = value;

                if (value == 0)
                    InvertedMass = 0;
                else
                    InvertedMass = 1 / _mass;
            }
        }

        public RigidBody2D() : base()
        {
            
        }

        public override void OnEnable()
        {
            Console.WriteLine("RigidBody OnEnable!");
        }

        public override void Start()
        {
            Console.WriteLine("RigidBody Start!");
            Acceleration = new Vector2(5, 5);
            Drag = 8;

        }

        public override void Update()
        {
            Console.WriteLine("RigidBody2D Update!");
            if (_useGravity)
            {
                Simulate();
            }
        }


        public void Simulate()
        {
            Velocity.Add(Acceleration);
            Velocity.X *= Drag;
            Velocity.Y *= Drag;
            Position.Add(Velocity);
            AngularVelocity += AngularAcceleration;
            AngularVelocity *= AngularDrag;
            Angle += AngularVelocity;
            Console.WriteLine(Position.X);
            Console.WriteLine(Position.Y);
        }

        public void ApplyConstantForce() { }

    }
}