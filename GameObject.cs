using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class GameObject
    {
        private bool _enabled = true;
        public bool IsEnabled
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

        private readonly List<Component> _components;
        public readonly Transform Transform;
        public readonly Tag tag = Tag.Untagged;
        public readonly string name = "GameObject";
        private Hirerarchy myHirerarchy;

        public GameObject(Hirerarchy hire)
        {
            Transform = new Transform(this);
            _components = new List<Component> { Transform };
            myHirerarchy = hire;
        }
        public GameObject(string _name, Hirerarchy hire)
        {
            name = _name;
            Transform = new Transform(this);
            _components = new List<Component> { Transform };
            myHirerarchy = hire;
        }

        public Component GetComponent(int i) => _components[i];
        public IEnumerable<T> GetComponents<T>() where T : Component => (_components.OfType<T>());
        public T GetComponent<T>() where T : Component => GetComponents<T>().FirstOrDefault();
        //I want to implement TryGetComponent later
        public T AddComponent<T>() where T : Component
        {
            var comp = default(T);
            _components.Add(comp);
            return comp;
        }
        public void RemoveComponent<T>() where T : Component => _components.Remove(GetComponent<T>());
        public void RemoveSpecificComponent(Component component) => _components.Remove(component);
        public bool CompareTag(GameObject other)
        {
            return this.tag == other.tag;
        }
        void OnEnable()
        {
            foreach (var comp in _components)
            {
                comp.Enabled = true;
            }
        }
        void OnDisable()
        {
            foreach (var comp in _components)
            {
                comp.Enabled = false;
            }
        }

        public void Destroy()
        {
            OnDisable();
            myHirerarchy.Remove(name);
        }
    }
}
