using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class Component : IComponent
    {
        public bool isEnabled { get; private set; }
        public Component()
        {
            
        }
        public void Awake() { }

        public void Start() { }

        public void Update() { }
        void Enable()
        {
            isEnabled = true;
            OnEnable();
        }
        void Disable()
        {
            isEnabled = false;
            OnDisable();
        }
        public virtual void OnEnable() { }
        public virtual void OnDisable() { }
    }
}
