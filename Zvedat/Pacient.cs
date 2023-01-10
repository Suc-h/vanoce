using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zvedat
{
    class Pacient : Osoba
    {
        double obvodpasu;

        double ObvodPasu
        {
            get
            {
                return obvodpasu;
            }
            set
            {
                // předpokladám pouze metry
                obvodpasu=value;    
            }
        }

        public Pacient(double obvodpasu,string jmeno, string prijmeni, int hmotnost, double vyska) : base(jmeno, prijmeni, hmotnost, vyska)
        {
            this.obvodpasu = obvodpasu;
        }
        public double ABSI()
        {
            double absi = obvodpasu / (Math.Pow(BMI(),2/3) * (Math.Pow(vyska,0.5)));
            return Math.Round(absi,2)/100;
        }

        public override string ToString()
        {
            return base.ToString()+" a ABSI: "+ABSI();
        }
    }
}
