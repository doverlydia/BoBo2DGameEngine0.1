using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BoBo2DGameEngine
{
    public sealed class Time : Component
    {
        public static double DeltaTime {get; private set;}
        private static double _secondFrame;
        private static readonly Stopwatch StopWatch = new();

        public Time() : base()
        { }
        public override void Start()
        {
            StopWatch.Start();
            Console.WriteLine("time Start!");
            StartTheTime();
        }
        public override void Update()
        {
            Thread.Sleep(1000);
            Events.OnTick.Invoke();
        }

        private static void StartTheTime()
        {
            var ts = StopWatch.Elapsed;
            var firstFrame = ts.TotalMilliseconds;

            DeltaTime = firstFrame - _secondFrame;

            _secondFrame = ts.TotalMilliseconds;
            Events.OnTick.Invoke();
        }
    }
}
