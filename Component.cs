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

        public readonly GameObject GameObject;
        public bool Enabled
        {
            get => _enabled;
            set
            {
                if (value == true)
                {
                    _enabled = true;
                    OnEnable();
                    Events.OnSceneLoaded.UpsertListener(Start);
                    Events.OnTick.UpsertListener(Update);
                }
                else
                {
                    _enabled = false;
                    Events.OnSceneLoaded.RemoveListener(Start);
                    Events.OnTick.RemoveListener(Update);
                    OnDisable();
                }
            }
        }

        public Component(GameObject gameObject)
        {
            GameObject = gameObject;
            Enabled = true;
        }

        public virtual void Start() { }

        public virtual void Update() { }

        public virtual void OnEnable() { }

        public virtual void OnDisable() { }
    }
}
