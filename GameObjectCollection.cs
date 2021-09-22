using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    class GameObjectCollection : IEnumerable<GameObject>
    {
        private List<GameObject> gameObjects;
        public GameObjectCollection()
        {
            gameObjects = new List<GameObject>();
        }
        public void Add(GameObject gameObject)
        {
            if (gameObject is null) return;
            gameObjects.Add(gameObject);
        }
        public void Add() => gameObjects.Add(new GameObject());
        public IEnumerator<GameObject> GetEnumerator() => gameObjects.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)gameObjects).GetEnumerator();
    }
}
