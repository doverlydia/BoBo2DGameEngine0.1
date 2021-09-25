using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace BoBo2DGameEngine
{
    public class RigidBody2D : Component
    {
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
        }

        public override void Update()
        {
            Console.WriteLine("RigidBody Update!");
        }
    }
}
