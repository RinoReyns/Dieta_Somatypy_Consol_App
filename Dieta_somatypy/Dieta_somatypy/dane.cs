namespace Dieta_somatypy
{
    class dane
    {
        public int wiek { get; set; }
        public double masa { get; set; }
        public string plec { get; set; }
        public double BMR { get; set; }
        public double aktywnosc { get; set; }
        public double BMRPLL { get; set; }
        public void clean()
        {
            wiek = 0;
            masa = 0;
            plec = "";
            BMR = 0;
            aktywnosc = 0;
            BMRPLL = 0;

        }
    }
}
