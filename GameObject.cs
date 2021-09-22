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
        public List<Component> components = new List<Component>();
        GameObject parent;
        GameObjectCollection children;
        public bool isEnabled
        {
            get
            {
                return isEnabled;
            }
            private set { }
        }
        string name;
        public GameObject(string _name)
        {
            name = _name;
            components.Add(new Transform());
        }
        public GameObject(string _name, GameObject _parent)
        {
            name = _name;
            parent = _parent;
            components.Add(new Transform());
        }
        public GameObject()
        {
            name = "GameObject";
            components.Add(new Transform());
        }
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
        public IEnumerable<Component> GetComponenets<T>() => (from component in components where component is T select component);
        public Component GetComponenet<T>() => GetComponenets<T>().FirstOrDefault();
        public void AddComponenet<T>() where T : Component => components.Add(Activator.CreateInstance<T>());
        public void RemoveComponent<T>() where T : Component => components.Remove(GetComponenet<T>());
        public void RemoveSpecificComponent(Component component) => components.Remove(component);
        public void SetParent(GameObject parent) => this.parent = parent;
        void Destroy() { }
    }
}
