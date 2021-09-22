using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class Scene
    {
        GameObjectCollection Hierarchy;
        public Scene()
        {
            Hierarchy = new GameObjectCollection();
        }
    }
}
