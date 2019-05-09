using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Kangelased
    {

        private string _Nimi;
        private string _Asukoht;

        public Kangelased(string Nimi, string Asukoht) {

            this.Nimi = Nimi;
            this.Asukoht = Asukoht;
        }
        public string Nimi {
            get { return _Nimi; }
            set { _Nimi = value; }
        }
        public string Asukoht {
            get { return _Asukoht; }
            set { _Asukoht = value; }
        }
        public int Päästa(int Ohustatuid)
        {
            return (int)Math.Round(Ohustatuid * 95.0 / 100);
        }
        public override string ToString()
        {
            return Nimi + " hoiab " + Asukoht + " turavalisena.";
        }
    }
}
