﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public static class Events
    {
        public static readonly Evt OnSceneLoaded = new ();
        public static readonly Evt InternalPhysicsUpdate = new();
        public static readonly Evt OnTick = new ();
    }

    public class Evt
    {
        public event Action Action = delegate { };

        public void Invoke()
        {
            Action.Invoke();
        }

        public void UpsertListener(Action listener)
        {
            Action -= listener;
            Action += listener;
        }

        public void RemoveListener(Action listener)
        {
            Action -= listener;
        }
    }
}
