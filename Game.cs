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
    }
}
