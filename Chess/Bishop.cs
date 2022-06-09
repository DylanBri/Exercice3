using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Bishop : IPiece
    {
        IPiece.Color color;

        public bool CanCastle()
        {
            return false;
        }

        public bool CanSkip()
        {
            return false;
        }

        public List<ProspectiveMove> Capabilities()
        {
            List<ProspectiveMove> list = new List<ProspectiveMove>();
            for (int diag = 1; diag <= 7; diag++)
            {
                // Diagonale droite haut
                list.Add(new ProspectiveMove(diag, diag));
                // Diagonale gauche bas
                list.Add(new ProspectiveMove(-diag, -diag));
                // Diagonale gauche haut
                list.Add(new ProspectiveMove(-diag, diag));
                // Diagonale bas droite 
                list.Add(new ProspectiveMove(diag, -diag));
            }
            return list;
        }

        public IPiece.Color GetColor()
        {
            return color;
        }

        public bool IsPawn()
        {
            return false;
        }

        public Bishop(IPiece.Color color)
        {
            this.color = color;
        }
    }
}
