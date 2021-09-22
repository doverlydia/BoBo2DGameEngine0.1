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
        private List<Component> components;
        GameObject parent;
        GameObjectCollection children;
        string name;
        public GameObject(string _name)
        {
            name = _name;
            components = new List<Component>();
            components.Add(new Transform());
        }
        public GameObject(string _name, GameObject _parent)
        {
            name = _name;
            parent = _parent;
            components = new List<Component>();
            components.Add(new Transform());
        }
        public GameObject()
        {
            name = "GameObject";
            components = new List<Component>();
            components.Add(new Transform());
        }

        public IEnumerable<Component> GetComponenets<T>() => (from component in components where component is T select component);
        public Component GetComponenet<T>() => GetComponenets<T>().FirstOrDefault();
        public void AddComponenet<T>() where T : Component => components.Add(Activator.CreateInstance<T>());
        public void RemoveComponent<T>() where T : Component => components.Remove(GetComponenet<T>());
        public void RemoveSpecificComponent(Component component) => components.Remove(component);
        public void SetParent(GameObject parent) => this.parent = parent;
        void Destroy() { }
    }
}
