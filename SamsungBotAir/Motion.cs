using System;
using System.Collections.Generic;
using System.Text;

namespace SamsungBotAir
{
    public class Motion : IMotion
    {
        public bool Move(float distance)
        {
            return true;
            //si il peut se déplacer de d mètres
            //return true : on considère qu'il s'est déplacé
            //return false : on considère qu'il ne s'est pas déplacé
        }

        public void Rotate(int angle)
        {
            //tourne dans le sens de a degres
        }
    }
}
