namespace medziagos_kartojimas
{
    public class Kamuolys : Spalva 
    {

        public Kamuolys(byte red, byte green, byte blue, int dydis) : base(red, green, blue)
        {
            Dydis = dydis;
        }

        public int Dydis { get; set; }
    }
}
