using System;
using System.Collections.Generic;
using System.Text;

namespace SamsungBotAir
{
    public class Motion : IMotion
    {
        private int[,] grille;
        private int x, y;

        public Motion(int[,] grille)
        {
            this.grille = grille;
            x = 1;
            y = 1;
        } 

        public bool Move(int distance)
        {
            if(distance <= 0)
                throw new ArgumentOutOfRangeException(nameof(distance), "La distance ne peut pas être négative");

            //try
            //{

            //}
            //catch ()
            //{

            //}

            return true;
            //si il peut se déplacer de d mètres
            //return true : on considère qu'il s'est déplacé
            //return false : on considère qu'il ne s'est pas déplacé
        }

        public void Rotate(int angle)
        {
            //tourne dans le sens de a degres
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
