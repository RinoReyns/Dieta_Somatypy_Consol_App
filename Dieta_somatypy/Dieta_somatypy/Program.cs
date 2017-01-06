namespace Dieta_somatypy
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            dane osoba = new dane();
            wzory Wzory = new wzory();
            Interface Interface = new Interface();
            bool koniec = false;
            while (koniec == false)
            {
                osoba.clean();
                osoba.wiek = Interface.wiek();
                osoba.masa = Interface.waga();
                osoba.plec = Interface.plec();
                osoba.aktywnosc = Interface.aktywnosc();
                    
                if (osoba.plec == "m")
                    osoba.BMR = Wzory.man(osoba.wiek, osoba.masa);
                else if (osoba.plec == "k")
                    osoba.BMR = Wzory.woman(osoba.wiek, osoba.masa);
                
                osoba.BMRPLL = Wzory.BMR_aktywnosc(osoba.BMR, osoba.aktywnosc);
                Interface.BRM_BMRPLL(osoba.BMR, osoba.BMRPLL);
                koniec =Interface.end();  
            }

        }
    }
}
