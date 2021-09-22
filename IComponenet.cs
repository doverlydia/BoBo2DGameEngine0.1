using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo2DGameEngine
{
    public interface IComponent
    {
        void Awake();
        void Start();
        void Update();
        void OnEnable();
        void OnDisable();
    }
}
