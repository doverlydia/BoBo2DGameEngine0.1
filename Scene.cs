using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class Scene
    {
        private readonly string _title = "New Scene";
        public readonly GameObjectCollection Hierarchy;
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
        public Scene()
        {
            Hierarchy = new GameObjectCollection();
        }
        public Scene(string title)
        {
            _title = title;
            Hierarchy = new GameObjectCollection();
        }
        public void OnEnable()
        {
            Events.OnSceneLoaded.Invoke();
        }
        public void OnDisable(){}
    }
}
