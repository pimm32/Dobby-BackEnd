using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DobbyAPI.Logic_Classes
{
    public class Schijf
    {
        public string kleur;
        private string[] _kleuren = new string[2] {"wit","zwart"};
        public bool geslagen = false;


        public Schijf(int speler)
        {
            KenKleurAanShijfToe(speler);
        }

        public Schijf(int speler, string[] kleurenset)
        {
            _kleuren[0] = kleurenset[0];
            _kleuren[1] = kleurenset[1];

            KenKleurAanShijfToe(speler);
        }

        private void KenKleurAanShijfToe(int speler)
        {
            if (speler == 1)
            {
                this.kleur = _kleuren[0];
            }
            else
            {
                this.kleur = _kleuren[1];
            }
        }
    }
}
