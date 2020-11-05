using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace DobbyAPI.Logic_Classes
{
    public class Veld
    {
        public string kleur;
        private int _x;
        private int _y;
        public int X { get => _x; set => _x= value; }
        public int Y { get => _y; set => _y= value; }

        public int nummer;
        private Schijf _schijfDatVeldBezet;

        public Schijf SchijfDatVeldBezet { get => _schijfDatVeldBezet; set => _schijfDatVeldBezet = value; }

        public Veld(int x, int y, bool speelbaar)
        {
            this._x = x;
            this._y = y;
            if (speelbaar)
            {
                this.kleur = "donker";

            }
            else
            {
                this.kleur = "licht";
            }
            if(y % 2 == 1)
            {
                this.nummer = (int.Parse(x.ToString() + y.ToString()) + 1) / 2;
            }
            else
            {
                this.nummer = 0;
            }
        }

        public Veld()
        {

        }

        public void ZetSchijfOpVeld(Schijf schijf)
        {
            this._schijfDatVeldBezet = schijf;
        }

        public void HaalSchijfVanVeld()
        {
            this._schijfDatVeldBezet = null;
        }

        public Schijf SchijfOpVeld()
        {
            return this._schijfDatVeldBezet;
        }
    }
}
