using System;
using System.Collections.Generic;
using System.Text;

namespace SamsungBotAir
{
    public class Motion : IMotion
    {
        private int[,] grille;
        private int x, y;
        private int dir;
        private enum direction { 
            horizontalGauche = 1,
            VerticalHaut = 2,
            horizontalDroite = 3,
            VerticalBas = 4,
        };

        public Motion(int[,] grille)
        {
            this.grille = grille;
            x = 1;
            y = 1;
            dir = (int)direction.horizontalDroite;
        } 

        public bool Move(int distance)
        {
            if(distance <= 0)
                throw new ArgumentOutOfRangeException(nameof(distance), "La distance ne peut pas être négative");

            try
            {
                for (int newCase = 0; newCase < distance; newCase++)
                { 
                    switch (dir)
                    {
                        case (int)direction.horizontalGauche:
                            //if()
                            break;
                        case (int)direction.VerticalHaut:
                            break;
                        case (int)direction.horizontalDroite:
                            break;
                        case (int)direction.VerticalBas:
                            break;
                    } 
                }
            }
            catch (IndexOutOfRangeException e)
            {
                throw new InvalidOperationException("La distance est trop grande", e);
            }

            return true;
            //si il peut se déplacer de d mètres
            //return true : on considère qu'il s'est déplacé
            //return false : on considère qu'il ne s'est pas déplacé
        }

        public void Rotate(int angle)
        {
            var angleAbs = Math.Abs(angle);
            if(angleAbs >= 360)
                throw new Exception("La rotation ne doit pas dépasser 360°");
            if(angleAbs%90 != 0)
                throw new Exception("La rotation doit être un multiple de 90 °");

            int step = angle / 90;
            dir = (dir + step) % 4;
        }

        public void AfficherGrille()
        {
            for (int x = 0; x < 66; x++)
            {
                for (int y = 0; y < 66; y++)
                {    
                    Console.Write(grille[x, y].ToString() + (grille[x, y] == -1 ? "" : " ") + "|");
                }
                Console.WriteLine("");
            }
        }


    }
}
