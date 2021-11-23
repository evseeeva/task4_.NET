

namespace task4
{
    class TV1generation
    {
        public string Firm { get; private set; }
        public int ScreenDiagonal { get; private set; }
        public int SoundPower { get; private set; }

        public TV1generation(string firm, int screenDiagonal, int soundPower)
        {
            Firm = firm;
            ScreenDiagonal = screenDiagonal;
            SoundPower = soundPower;
        }
        public  virtual double calculateQ()

        {
            return ScreenDiagonal + 0.05* SoundPower;
        }

        public override string ToString()
        {
            return string.Format(" TV first generation: firm - {0},  screen diagonal - {1} inches, sound power - {2} db, quality - {3} ", 
                Firm, ScreenDiagonal, SoundPower, calculateQ());
        }
    }
}
