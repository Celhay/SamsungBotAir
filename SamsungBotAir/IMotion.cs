using System;
using System.Collections.Generic;
using System.Text;

namespace SamsungBotAir
{
    interface IMotion
    {
        bool Move(float distance);

        void Rotate(int angle);
    }
}
