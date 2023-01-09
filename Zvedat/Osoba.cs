using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Zvedat
{
    class Osoba
    {
        string jmeno;
        string prijmeni;
        int hmotnost;
        double vyska;

        public Osoba(string jmeno, string prijmeni, int hmotnost, double vyska)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.hmotnost = hmotnost;
            this.vyska = vyska;
        }

        string Jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {

            }
        }
        string Prijmeni
        {
            get
            {
                return prijmeni;
            }
            set
            {

            }
        }
        int Hmotnost
        {
            get
            {
                return hmotnost;
            }
            set
            {
                if(value>=0&& value <=300)
                {
                   this.hmotnost = value;
                }
                else
                {
                    MessageBox.Show("Hmotnost mimo rozsah!");
                }
            }
        }
        double Vyska
        {
            get
            {
                return vyska;
            }
            set
            {
                if(value>50)
                {
                    this.vyska = value;
                }
            }
        }
        
        public virtual string BMI()
        {
            double bmi = hmotnost / (vyska * vyska);
            return  " "+bmi;
        }

        public override string ToString()
        {
            return Jmeno + " " + Prijmeni + " s hmotností: " + Hmotnost + " a výškou: " + Vyska + " s BMI: " + BMI();
        }
    }
}