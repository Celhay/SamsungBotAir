﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SamsungBotAir
{
    public class Processing
    {
        private int[,] grille;

        private void InitGrille()
        {
            grille = new int[66, 66];
            for (int x = 0; x < 66; x++)
            {
                for (int y = 0; y < 66; y++)
                {
                    if (x == 0 || x == 65 || y == 0 || y == 65)
                        grille[x, y] = -1;
                }
            }
            grille[1, 1] = 1;
        }

        public void Scan(Motion motion)
        {
            for (int x = 0; x < 66; x++)
            {
                for (int y = 0; y < 66; y++)
                {
                    //if(motion.grille ==)
                }
            }
        }
    }
}
