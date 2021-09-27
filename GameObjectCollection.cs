using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class GameObjectCollection : IEnumerable<GameObject>
    {
        private readonly Dictionary<string, GameObject> _gameObjects;
        public GameObjectCollection()
        {
            _gameObjects = new Dictionary<string, GameObject>();
        }
        public void Add(GameObject gameObject)
        {
            if (gameObject is null) return;
            _gameObjects.Add(gameObject.Name,gameObject);
        }
        public void Remove(GameObject gameObject)
        {
            if (gameObject is null) return;
            _gameObjects.Remove(gameObject.Name);
        }
        public void Add() => _gameObjects.Add("NewGameObject", new GameObject());
        public GameObject GetGameObjectByName(string name) => _gameObjects[name];
        public IEnumerator<GameObject> GetEnumerator() => _gameObjects.Values.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_gameObjects).GetEnumerator();
    }
}
