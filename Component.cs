using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class Component : IComponent
    {
        private bool _enabled;

        public bool Enabled
        {
            get => _enabled;
            set
            {
                if (value == true)
                {
                    _enabled = true;
                    OnEnable();
                }
                else
                {
                    _enabled = false;
                    OnDisable();
                }
            }
        }

        public Component()
        {

        }
        public void Awake() { }

        public void Start() { }

        public void Update() { }
        public void OnEnable() { }
        public void OnDisable() { }
    }
}
