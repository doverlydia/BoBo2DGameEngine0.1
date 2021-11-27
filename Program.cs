using System;

namespace BoBo2DGameEngine
{
    //Date: 28.9.2021 || For: Dor Ben Dor || Course: Advanced c# Programming || 1/3 Brief Building Blocks - Mid Semester Project || By: Lydia Dover
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new("MyGame", 1);

            #region adding_game_objects_with_componenets
            Physics2D.Gravity = 1; // assigning the gravity force value;
            GameObject obj3 = myGame.ActiveScene.hierarchy.AddNewGameObject();
            obj3.GetComponent<Transform>().Position = new Vector2(0, 5);
            GameObject obj2 = myGame.ActiveScene.hierarchy.AddNewGameObject();
            obj2.GetComponent<Transform>().Position = new Vector2(0, -5);

            obj2.AddComponent<BoxCollider2D>().Enabled = true;
            obj2.AddComponent<RigidBody2D>();
            obj2.GetComponent<RigidBody2D>().BodyType = BodyType.Static;
            obj2.GetComponent<RigidBody2D>().Enabled = true;

            obj3.AddComponent<BoxCollider2D>().Enabled = true;
            obj3.AddComponent<RigidBody2D>();
            obj3.GetComponent<RigidBody2D>().BodyType = BodyType.Dynamic; // here i apply constant force to just one of the objects
            obj3.GetComponent<RigidBody2D>().Enabled = true;
            #endregion



            #region checking assmebly version
            //Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            //Console.WriteLine(version);
            #endregion

            #region Checking Transform & Parent
            //Vector2 tempPos = myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj2").Transform.Position;
            //myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj2").Transform.Position =
            //    Vector2.Add(tempPos, Vector2.Up);
            //Vector2 tempPos2 = myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj3").Transform.Position;
            //myGame.ActiveScene.Hierarchy.GetGameObjectByName("obj3").Transform.Position =
            //    Vector2.Add(tempPos2, Vector2.Down);
            #endregion

            myGame.IsGameRunning = true;

            Console.WriteLine("succeeded");
            Console.ReadLine();
        }
    }
}
