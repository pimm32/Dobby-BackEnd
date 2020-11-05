using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobbyAPI.Logic_Classes
{
    public class Bord
    {
        public Veld[,] stelling { get; set; }

        public List<Veld> velden { get; set; }
        public string tekst { get; set; }
        public Bord()
        {
            velden = new List<Veld>();
            stelling = new Veld[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //controleren of het vakje speelbaar is of een licht vakje is
                    if ((i % 2 == 0 && j % 2 == 0) || (i % 2 == 1 && j % 2 == 1))
                    {
                        stelling[i, j] = new Veld(i, j, false);
                        
                    }
                    else
                    {
                        stelling[i, j] = new Veld(i, j, true);
                    }
                }
            }
            NieuwBordOpstellen();
        }

        public void NieuwBordOpstellen()
        {
            foreach (Veld veld in stelling)
            {
                if(
                    veld.nummer == 1 ||
                    veld.nummer == 2 ||
                    veld.nummer == 3 ||
                    veld.nummer == 4 ||
                    veld.nummer == 5 ||
                    veld.nummer == 6 ||
                    veld.nummer == 7 ||
                    veld.nummer == 8 ||
                    veld.nummer == 9 ||
                    veld.nummer == 10 ||
                    veld.nummer == 11 ||
                    veld.nummer == 12 ||
                    veld.nummer == 13 ||
                    veld.nummer == 14 ||
                    veld.nummer == 15 ||
                    veld.nummer == 16 ||
                    veld.nummer == 17 ||
                    veld.nummer == 18 ||
                    veld.nummer == 19 ||
                    veld.nummer == 20
                    )
                {
                    veld.SchijfDatVeldBezet = new Schijf(2);
                }
                if (
                    veld.nummer == 31 ||
                    veld.nummer == 32 ||
                    veld.nummer == 33 ||
                    veld.nummer == 34 ||
                    veld.nummer == 35 ||
                    veld.nummer == 36 ||
                    veld.nummer == 37 ||
                    veld.nummer == 38 ||
                    veld.nummer == 39 ||
                    veld.nummer == 40 ||
                    veld.nummer == 41 ||
                    veld.nummer == 42 ||
                    veld.nummer == 43 ||
                    veld.nummer == 44 ||
                    veld.nummer == 45 ||
                    veld.nummer == 46 ||
                    veld.nummer == 47 ||
                    veld.nummer == 48 ||
                    veld.nummer == 49 ||
                    veld.nummer == 50
                    )
                {
                    veld.SchijfDatVeldBezet = new Schijf(1);
                }

            }
        }


    }
}
