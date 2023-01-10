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
                if(value>0&& value <=300)
                {
                   hmotnost = value;
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
                 if(value>2.72) // nejvyšší člověk v historii 2,72m
                 {
                     vyska = value;
                 }
                 else
                 {
                     vyska = value / 100;
                 }
                
            }
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