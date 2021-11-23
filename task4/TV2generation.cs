

namespace task4
{
    class TV2generation : TV1generation
    {

        public string P { get; private set; }
        public TV2generation(string firm, int screenDiagonal, int soundPower, string manufacturedСountry) : base(firm, screenDiagonal, soundPower)
        {
            P = manufacturedСountry;
          
        }
        public override double calculateQ()
        {
            switch (P)
            {
                case "Japan":
                   return 2 * base.calculateQ();
                case "Singapore":
                    return 1.5 * base.calculateQ();
                case "Korea":
                    return 1.5 * base.calculateQ();
                
            }
            return base.calculateQ();
        }
        public override string ToString()
        {
            return string.Format(" TV second generation: firm - {0},  screen diagonal - {1} inches, sound power - {2} db, manufactured country - {3}, quality - {4} ",
                Firm, ScreenDiagonal, SoundPower, P, calculateQ());
        }

    }
}
