using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public class Time
    {
        DateTime _lastTime; // marks the beginning the measurement began
        int _framesRendered; // an increasing count
        int _fps; // the FPS calculated from the last measurement
        public float time = 0;
        public void CalculateTime()
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
