﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class Game
    {
        private readonly string _title = "New Game";
        private readonly List<Scene> _scenes;
        public Scene ActiveScene;
        private bool _isGameRunning;
        private readonly Thread _time = new Thread(()=>Time.TimeCalc(1));
        public bool IsGameRunning
        {
            get => _isGameRunning;
            set
            {
                if (value)
                {
                    _isGameRunning = RunGame();
                }
                else
                    Console.WriteLine("Run Game Failed");
            }
        }

        public Game()
        {
            _scenes = new List<Scene> { new() };
            ActiveScene = _scenes[0];
        }
        public Game(string title)
        {
            _scenes = new List<Scene> { new() };
            ActiveScene = _scenes[0];
            _title = title;
        }

        public void AddScene() => _scenes.Add(new Scene());
        public void AddScene(string title) => _scenes.Add(new Scene(title));

        private bool LoadScene(Scene scene)
        {
            ActiveScene = scene;
            scene.Enabled = true;
            return true;
        }

        private bool RunGame()
        {
            _time.Start();
            return LoadScene(ActiveScene);
        }
    }
}
