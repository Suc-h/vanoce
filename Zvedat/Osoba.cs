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
        protected string jmeno;
        protected string prijmeni;
        protected int hmotnost;
        protected double vyska;

        

        string Jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {
                jmeno = value;
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
                prijmeni = value;
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

                if (value <= 300 && value > 0)
                {
                    hmotnost = value;
                }
                else
                {
                    MessageBox.Show("Hmotnost mimo rozsah!");
                    hmotnost = 0;
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
                if (value < 3)
                    vyska = value;
                else
                    vyska = value / 100;

            }
        }
        public Osoba(string jmeno, string prijmeni, int hmotnost, double vyska)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.Hmotnost = hmotnost;
            this.Vyska = vyska;
        }

        public virtual double BMI()
        {
            double bmi = hmotnost / (vyska * vyska);
            return Math.Round(bmi,2);
        }

        public override string ToString()
        {
            return Jmeno + " " + Prijmeni + " s hmotností: " + Hmotnost + "kg a výškou: " + Vyska + "m s BMI: " + BMI();
        }
    }
}