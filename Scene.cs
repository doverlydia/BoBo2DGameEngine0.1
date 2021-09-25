using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class Scene : Component
    {
        private readonly string _title = "New Scene";
        public readonly GameObjectCollection Hierarchy;
        public Scene() : base()
        {
            Hierarchy = new GameObjectCollection();
        }
        public Scene(string title) : base()
        {
            _title = title;
            Hierarchy = new GameObjectCollection();
        }
        public override void OnEnable()
        {
            Events.OnSceneLoaded.Invoke();
        }
    }
}
