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
        public readonly Hirerarchy hierarchy;
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
            hierarchy = new();
            Console.WriteLine("New scene: " + _title);
        }
        public Scene(string title)
        {
            _title = title;
            hierarchy = new();
            Console.WriteLine("created scene: "+_title);
        }
        public void OnEnable()
        {
            Events.OnSceneLoaded.Invoke();
        }
        public void OnDisable() { }
    }
}
