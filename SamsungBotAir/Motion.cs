using System;
using System.Collections.Generic;
using System.Text;

namespace SamsungBotAir
{
    public class Motion : IMotion
    {
        private int[,] _grille; 
        public int[,] grille
        {
            get { return _grille; }
            set { _grille = value; }
        }


        public Motion()
        {
            // première ligne et dernière ligne
            // première colonne et dernière colonne
            // point de départ (1,1) en haut à gauche
            InitGrille();
        }

        private void InitGrille()
        {
            grille = new int[66,66];
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
