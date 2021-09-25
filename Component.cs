using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class Component : IComponent
    {
        private bool _enabled = true;

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
            Events.OnSceneLoaded.AddListener(Start);
            Events.OnTick.AddListener(Update);
            Events.OnDisabled.AddListener(OnDisable);
        }

        public virtual void Start() { }

        public virtual void Update() { }

        public virtual void OnEnable() { }

        public virtual void OnDisable() { }
    }
}
