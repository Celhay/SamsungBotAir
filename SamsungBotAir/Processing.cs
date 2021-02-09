using System;
using System.Collections.Generic;
using System.Text;

namespace SamsungBotAir
{
    public class Processing
    {
        private int[,] grille;

        public Processing()
        {
            InitGrille();
        }
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
        public int[,] getGrille()
        {
            return grille;
        }

        public void Scan(Motion motion)
        {
            for (int y = 0; y < 66; y++)
            {
                for (int x = 0; x < 66; x++)
                {
                    if (grille[x, y] == 0)
                    {
                        if (CheckObstacle(x, y))
                        {
                            grille[x, y] = -1;
                            x=0;
                            y++;
                        }
                        else
                            grille[x, y] = 1;
                    }
                }
            }
        }

        //si le capteur trouve quelque chose il retourne -1
        //public bool CheckObstacle()
        public bool CheckObstacle(int x, int y)
        {
            if ((x == 5 && y <= 15)) //mur horizontal
            {
                return true;
            }
            else if((x <= 6 && y == 25)) // mur vertical
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
