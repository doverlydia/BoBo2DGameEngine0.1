using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class Hirerarchy : IEnumerable<Tree<GameObject>> // I know sorting them by name is wrong, need to make this more robust
    {
        private readonly Dictionary<string, Tree<GameObject>> _gameObjects;

        public Hirerarchy()
        {
            _gameObjects = new Dictionary<string, Tree<GameObject>>();
        }
        public GameObject AddNewGameObject()
        {
            Tree<GameObject> obj = new(this);
            _gameObjects.Add(obj._root.Data.name, obj);
            return obj._root.Data;
        }
        public void Remove(string name)
        {
            if (name is null) return;
            foreach (var gameObjectTree in _gameObjects)
            {
                foreach (var item in gameObjectTree.Value._root.)
                {

                }
            }
            _gameObjects.Remove(name);
        }
        public void Remove(Tree<GameObject> gameObject)
        {
            if (gameObject is null) return;
            _gameObjects.Remove(gameObject._root.Data.name);
        }

        public GameObject GetGameObjectByName(string name) => _gameObjects[name]._root.Data;

        public IEnumerator<Tree<GameObject>> GetEnumerator() => _gameObjects.Values.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_gameObjects).GetEnumerator();
    }
}
