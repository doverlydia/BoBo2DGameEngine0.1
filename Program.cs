using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.MediaFoundation;

namespace BoBo2DGameEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new();

            #region adding_game_objects_with_componenets
            myGame.ActiveScene.Hierarchy.Add(new GameObject("obj1"));
            myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj1").AddComponent<BoxCollider2D>();
            myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj1").AddComponent<RigidBody2D>();
            #endregion

            myGame.IsGameRunning = true;
        }
    }
}
