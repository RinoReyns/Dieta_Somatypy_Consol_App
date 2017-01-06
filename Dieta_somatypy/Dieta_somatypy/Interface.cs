using System;

namespace Dieta_somatypy
{
    public class Interface
    {        
        public int wiek()
        {
            string temp;
            bool test = false;
            int temp2=0;
            while (test == false)
            {
                Console.WriteLine("Podaj wiek: ");
                temp = Console.ReadLine();
                if (Int32.TryParse(temp, out temp2))
                    test = true;
            }
            return temp2;
        }

        public double waga()
        {
            string temp;
            bool test = false;
            double temp2=0;
            while (test == false)
            {
                Console.WriteLine("Podaj wagę: ");
                temp = Console.ReadLine();
                if (Double.TryParse(temp, out temp2))   
                    test = true;
            }
            return temp2;
        }

        public string plec()
        {
            string temp="";
            bool test = false;
            while (test == false)
            {
                Console.WriteLine("Podaj płeć: ");
                temp = Console.ReadLine();
                if (temp == "k" || temp == "m") 
                    test = true;
            }
            return temp;
        }

        public double aktywnosc()
        {
            string temp;
            bool test = false;
            double temp3 = 0;
            while (test == false)
            {
                Console.WriteLine("Podaj aktywność: ");
                temp = Console.ReadLine();
                if (Double.TryParse(temp, out temp3))
                    if (temp3 == 1.2 || temp3 == 1.3 || temp3 == 1.4 || temp3 == 1.5 || temp3 == 1.7)
                        test = true;
            }
            return temp3;
        }
        public void BRM_BMRPLL(double BMR, double BMRPLL)
        {
            Console.WriteLine("BMR:" + BMR);
            Console.WriteLine("Zapotrzebowanie całkowite: " + BMRPLL);
            Console.ReadKey();
            Console.Clear();
        }

        public bool end()
        {
            Console.WriteLine("Czy chcesz liczyć jeszcze raz ? t/n");
            if (Console.ReadLine() == "n")
            {
                Console.Clear();
                return true;
            }
            else
            {
                Console.Clear();
                return false;
            }

        }

    }
}
