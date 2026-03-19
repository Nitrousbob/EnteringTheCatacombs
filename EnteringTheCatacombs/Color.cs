namespace EnteringTheCatacombs
{
    internal class TheColor
    {
        public byte R { get; set; }
        public byte G { get; set; }
        public byte B { get; set; }

        public TheColor(byte r, byte g, byte b)
        {
            this.R = r;
            this.G = g;
            this.B = b;
        }

        public static TheColor White => new TheColor(255, 255, 255);
        public static TheColor Black => new TheColor(0, 0, 0);
        public static TheColor Red => new TheColor(255, 0, 0);
        public static TheColor Orange => new TheColor(255, 165, 0);
        public static TheColor Yellow => new TheColor(255, 255, 0);
        public static TheColor Green => new TheColor(0, 128, 0);
        public static TheColor Blue => new TheColor(0, 0, 255);
        public static TheColor Purple => new TheColor(128, 0, 128);

        public override string ToString()
        {
            return $"R:{R} G:{G} B:{B}";
        }
    }
}
