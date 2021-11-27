using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class Hirerarchy // I know sorting them by name is wrong, need to make this more robust
    {
        private readonly Tree _hirerachy;

        public Hirerarchy()
        {
            _hirerachy = new();
        }
        public GameObject AddNewGameObject()
        {
            return (GameObject)_hirerachy._root.AddChild(new GameObject());
        }
        public GameObject AddNewGameObject(string name)
        {
            return (GameObject)_hirerachy._root.AddChild(new GameObject(name));
        }
        public void Remove(GameObject gameObject)
        {
            if (gameObject == null) return;
            _hirerachy._root.RemoveChild(gameObject);
        }
    }
}