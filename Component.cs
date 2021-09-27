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
        //public GameObject GameObject
        //{
        //    //get => _gameObject;
        //    //set
        //    //{
        //    //    if (_gameObject == null)
        //    //        _gameObject = value;
        //    //    else
        //    //    {
        //    //        throw new AccessViolationException("Cant modify gameObjects of components");
        //    //    }
        //    //}
        //}

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

        public Component(GameObject gameObject)
        {
            GameObject = gameObject;
            Events.OnSceneLoaded.UpsertListener(Start);
            Events.OnTick.UpsertListener(Update);
            Events.OnDisabled.UpsertListener(OnDisable);
        }

        public virtual void Start() { }

        public virtual void Update() { }

        public virtual void OnEnable() { }

        public virtual void OnDisable() { }

    }
}
