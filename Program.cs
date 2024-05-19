namespace HomeWork_6
{
    internal class Program
    {
        private static House House;

        public static Team Team { get; private set; }

        static void Main(string[] args)
        {
            House = new House();
            Team = new Team();
        }
    }
}
