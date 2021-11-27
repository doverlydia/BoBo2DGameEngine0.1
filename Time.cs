using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace BoBo2DGameEngine
{
    public sealed class Time
    {
        public static double DeltaTime {get; private set;}
        public static int FrameRate { get; private set; }
        
        private static double _secondFrame;
        private static readonly Stopwatch StopWatch = new();

        public Time()
        { }

        public static void TimeCalc(int frameRate)
        {
            FrameRate = frameRate;
            StopWatch.Start();
            while (true)
            {
                var ts = StopWatch.Elapsed;
                var firstFrame = ts.TotalMilliseconds;

                DeltaTime = firstFrame - _secondFrame;
                _secondFrame = ts.TotalMilliseconds;
                Events.InternalPhysicsUpdate.Invoke();
                Events.OnTick.Invoke();
                Thread.Sleep(1000/frameRate);
            }
        }
    }
}
