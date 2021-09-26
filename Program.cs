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
            Game myGame = new("MyGame", 1);

            #region adding_game_objects_with_componenets
            myGame.ActiveScene.Hierarchy.Add(new GameObject("obj1"));
            myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj1").AddComponent<BoxCollider2D>().Enabled = true;
            myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj1").AddComponent<RigidBody2D>().Enabled = true;

            myGame.ActiveScene.Hierarchy.Add(new GameObject("obj2"));
            myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj2").AddComponent<BoxCollider2D>().Enabled = true;
            myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj2").AddComponent<RigidBody2D>().Enabled = true;

            myGame.ActiveScene.Hierarchy.Add(new GameObject("obj3"));
            myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj3").AddComponent<BoxCollider2D>().Enabled = true;
            myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj3").AddComponent<RigidBody2D>().Enabled = true;
            #endregion

            Console.WriteLine("starting...");
            Console.WriteLine(myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj1").GetComponents<RigidBody2D>().ToString());
            myGame.IsGameRunning = true;
            Console.WriteLine("succeeded");
            Console.ReadLine();
        }
    }
}
