using System;

namespace SamsungBotAir
{
    class Program
    {
        static void Main(string[] args)
        {
            Processing processing = new Processing();
            Motion motion = new Motion(processing.getGrille());
            motion.AfficherGrille();
        }
    }
}
