using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class Game
    {
        string title;
        public readonly Scene activeScene;

        DateTime _lastTime; // marks the beginning the measurement began
        int _framesRendered; // an increasing count
        int _fps; // the FPS calculated from the last measurement
        public float time = 0;

        public Game()
        {
            title = "New Game";
            activeScene = new Scene();
        }
        public Game(string title)
        {
            activeScene = new Scene();
            this.title = title;
        }
        bool LoadScene() { return true; }
        bool Run()
        {
            LoadScene();
            return true;
        }
        public void Update()
        {
            _framesRendered++;

            if ((DateTime.Now - _lastTime).TotalSeconds >= 1)
            {
                time++;
                // one second has elapsed 

                _fps = _framesRendered;
                _framesRendered = 0;
                _lastTime = DateTime.Now;
            }
        }

    }
}
