namespace ClassLibrary
{
    internal class Manager : ILvlAccess
    {

        public string Position { get; set; }
        public string Posibilities { get; set; }

        public Manager() { Position = "manager"; Posibilities = "Может просматривать и менять большую часть информации"; }

    }
}
