using System;

namespace BoBo2DGameEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new("MyGame", 1);

            #region adding_game_objects_with_componenets
            myGame.ActiveScene.Hierarchy.Add(new GameObject("obj1"));
            myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj1").Parent = new GameObject("obj2");
            myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj1").AddComponent<BoxCollider2D>().Enabled = true;
            myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj1").AddComponent<RigidBody2D>().Enabled = true;
            myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj1").GetComponent<RigidBody2D>().BodyType = BodyType.Dynamic;
            Console.WriteLine("my name is: " + myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj1").GetComponent<RigidBody2D>().GameObject.Name);
            Console.WriteLine("My parent name is:" + myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj1").Parent.Name);
            #endregion

            Console.WriteLine("starting...");
            Console.WriteLine(myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj1").GetComponents<RigidBody2D>().ToString());
            myGame.IsGameRunning = true;
            //Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            //Console.WriteLine(version);
            Console.WriteLine("succeeded");
            Console.ReadLine();
        }
    }
}
