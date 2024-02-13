namespace myProject
{
    class gameLibrary
    {
        private int _Id;
        private string _Title;
        private string _Developer;

        public gameLibrary()
        {
            _Id = 0;
            _Title = "";
            _Developer = "";
        }
        public gameLibrary(int id, string title, string developer)
        {
            _Id = id;
            _Title = title;
            _Developer = developer;
        }
        public int GetId()
        {
            return _Id;
        }
        public string GetTitle()
        {
            return _Title;
        }
        public string GetDeveloper()
        {
            return _Developer;
        }
        public void SetTitle(string title)
        {
            _Title = title;
        }
        public void SetId(int id)
        {
            _Id = id;
        }
        public void SetDeveloper(string developer)
        {
            _Developer = developer;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            gameLibrary game1 = new gameLibrary();
            game1.SetId(1);
            game1.SetTitle("Spiderman");
            game1.SetDeveloper("Insomniac");

            gameLibrary game2 = new gameLibrary();
            Console.WriteLine("Please enter the game ID: ");
            game2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the title: ");
            game2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the developer: ");
            game2.SetDeveloper(Console.ReadLine());

            gameLibrary game3 = new gameLibrary(3, "Far Cry 6", "Ubisoft");

            Console.WriteLine("Please enter the game ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the title: ");
            string tempTitle = (Console.ReadLine());
            Console.WriteLine("Please enter the developer: ");
            string tempDeveloper = Console.ReadLine();
            gameLibrary game4 = new gameLibrary(tempID, tempTitle, tempDeveloper);

            displayGames(game1);
            displayGames(game2);
            displayGames(game3);
            displayGames(game4);
        }
        static void displayGames(gameLibrary game)
        {
            Console.WriteLine("Here is the game information");
            Console.WriteLine($"Game ID: {game.GetId()}");
            Console.WriteLine($"Game title: {game.GetTitle()}");
            Console.WriteLine($"Game developer: {game.GetDeveloper()}");
        }
    }
}
