using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Superkangelane : Kangelased
    {
        private double _Osavus;
        Random r = new Random();
        public Superkangelane(string Nimi, string Asukoht) : base(Nimi, Asukoht)
        {
            _Osavus = r.Next(1, 5) + r.NextDouble();
        }

        public override int Päästa(int Ohustatuid)
        {
            return (int)Math.Round(Ohustatuid * (95 + _Osavus) / 100);
        }
        public override string ToString()
        {
            return base.ToString() + " ja ta on selles " + _Osavus + " protsenti osavam kui teised.";
        }
    }
}
