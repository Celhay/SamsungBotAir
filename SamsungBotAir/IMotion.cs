using System;
using System.Collections.Generic;
using System.Text;

namespace SamsungBotAir
{
    interface IMotion
    {
        bool Move(int distance);

        void Rotate(int angle);
    }
}
