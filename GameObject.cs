using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class GameObject : Component
    {
        private readonly List<Component> _components;
        private readonly GameObjectCollection _children;
        private GameObject _parent;
        public readonly string Name;
        public GameObject(string name)
        {
            Name = name;
            _components = new List<Component> { new Transform() };
        }
        public GameObject(string name, GameObject parent)
        {
            Name = name;
            this._parent = parent;
            _components = new List<Component> { new Transform() };
        }
        public GameObject()
        {
            Name = "GameObject";
            _components = new List<Component> { new Transform() };
        }

        public IEnumerable<T> GetComponents<T>() where T : Component => (_components.OfType<T>());
        public T GetComponent<T>() where T : Component => GetComponents<T>().FirstOrDefault();

        public T AddComponent<T>() where T : Component
        {
            var comp = Activator.CreateInstance<T>();
            _components.Add(comp);
            return comp;
        } 
        public void RemoveComponent<T>() where T : Component => _components.Remove(GetComponent<T>());
        public void RemoveSpecificComponent(Component component) => _components.Remove(component);
        public void SetParent(GameObject parent) => this._parent = parent;
        void Destroy() { }
    }
}
