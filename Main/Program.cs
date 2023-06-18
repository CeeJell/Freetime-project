using Main;
using static System.Formats.Asn1.AsnWriter;

internal class Program
{
    private static void Main(string[] args)
    {
        bool Gameloop = true;
        bool StartGame = true;

        Player player = new Player();


        Room room111 = new Room() { Description = "Room 1.11" };
        Room room112 = new Room() { Description = "Room 1.12" };
        Room room113 = new Room() { Description = "Room 1.13" };
        Room room114 = new Room() { Description = "Room 1.14" };
        Room room115 = new Room() { Description = "Room 1.15" };
        Room room116 = new Room() { Description = "Room 1.16" };
        Room room121 = new Room() { Description = "Room 1.21" };
        Room room124 = new Room() { Description = "Room 1.24" };
        Room room126 = new Room() { Description = "Room 1.26" };
        Room room131 = new Room() { Description = "Room 1.31" };
        Room room132 = new Room() { Description = "Room 1.32" };
        Room room133 = new Room() { Description = "Room 1.33" };
        Room room135 = new Room() { Description = "Room 1.35" };
        Room room136 = new Room() { Description = "Room 1.36" };
        Room room142 = new Room() { Description = "Room 1.42" };
        Room room143 = new Room() { Description = "Room 1.43" };
        Room room144 = new Room() { Description = "Room 1.44" };
        Room room146 = new Room() { Description = "Room 1.46" };
        Room room154 = new Room() { Description = "Room 1.54" };
        Room room155 = new Room() { Description = "Room 1.55" };
        Room room156 = new Room() { Description = "Room 1.56" };
        Room room163 = new Room() { Description = "Room 1.63" };
        Room room164 = new Room() { Description = "Room 1.64" };

        Room room213 = new Room() { Description = "Room " };
        Room room214 = new Room() { Description = "Room " };
        Room room221 = new Room() { Description = "Room " };
        Room room222 = new Room() { Description = "Room " };
        Room room224 = new Room() { Description = "Room " };
        Room room226 = new Room() { Description = "Room " };
        Room room232 = new Room() { Description = "Room " };
        Room room233 = new Room() { Description = "Room " };
        Room room234 = new Room() { Description = "Room " };
        Room room235 = new Room() { Description = "Room " };
        Room room236 = new Room() { Description = "Room " };
        Room room241 = new Room() { Description = "Room " };
        Room room242 = new Room() { Description = "Room " };
        Room room244 = new Room() { Description = "Room " };
        Room room246 = new Room() { Description = "Room " };
        Room room252 = new Room() { Description = "Room " };
        Room room253 = new Room() { Description = "Room " };
        Room room254 = new Room() { Description = "Room " };
        Room room255 = new Room() { Description = "Room " };
        Room room263 = new Room() { Description = "Room " };
        Room room265 = new Room() { Description = "Room " };

        Room room321 = new Room() { Description = "Room " };
        Room room322 = new Room() { Description = "Room " };
        Room room323 = new Room() { Description = "Room " };
        Room room324 = new Room() { Description = "Room " };
        Room room333 = new Room() { Description = "Room " };
        Room room341 = new Room() { Description = "Room " };
        Room room342 = new Room() { Description = "Room " };
        Room room343 = new Room() { Description = "Room " };
        Room room344 = new Room() { Description = "Room " };
        Room room345 = new Room() { Description = "Room " };
        Room room353 = new Room() { Description = "Room " };
        Room room363 = new Room() { Description = "Room " };

        Room room414 = new Room() { Description = "Room " };
        Room room421 = new Room() { Description = "Room " };
        Room room422 = new Room() { Description = "Room " };
        Room room423 = new Room() { Description = "Room " };
        Room room424 = new Room() { Description = "Room " };
        Room room431 = new Room() { Description = "Room " };
        Room room441 = new Room() { Description = "Room " };
        Room room442 = new Room() { Description = "Room " };
        Room room451 = new Room() { Description = "Room " };
        Room room461 = new Room() { Description = "Room " };
        Room room462 = new Room() { Description = "Room " };
        Room room463 = new Room() { Description = "Room " };
        Room room464 = new Room() { Description = "Room " };
        Room room465 = new Room() { Description = "Room " };
        Room room466 = new Room() { Description = "Room " };

        Room currentRoom = room113;
        Room lastRoom = currentRoom;
        Room tempRoom = null;

        room111.AddEast(room112);
        room111.AddNorth(room121);
        room112.AddEast(room113);
        room113.AddEast(room114);
        room114.AddEast(room115);
        room114.AddNorth(room124);
        room115.AddEast(room116);
        room116.AddNorth(room126);
        room121.AddNorth(room131);
        room126.AddNorth(room136);
        room131.AddEast(room132);
        room132.AddEast(room133);
        room132.AddNorth(room142);
        room133.AddNorth(room143);
        room135.AddEast(room136);
        room136.AddNorth(room146);
        room142.AddEast(room143);
        room143.AddEast(room144);
        room144.AddNorth(room154);
        room146.AddNorth(room156);
        room154.AddEast(room155);
        room154.AddNorth(room164);
        room155.AddEast(room156);
        room163.AddEast(room164);

        // Console.WriteLine(player.playerItems[int.Parse(siffra.ToString())]);
        // Console.ForegroundColor = ConsoleColor.Green;

        while (Gameloop)
        {
            if (StartGame)
            {
                printPrelude();
                StartGame = false;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Do you want to go North, South, East or West?");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            string userText = Console.ReadLine().ToLower();

            tempRoom = null;
            switch (userText)
            {
                case "n":
                case "north":
                    tempRoom = currentRoom.GoNorth;
                    break;
                case "s":
                case "south":
                    tempRoom = currentRoom.GoSouth;
                    break;
                case "e":
                case "east":
                    tempRoom = currentRoom.GoEast;
                    break;
                case "w":
                case "west":
                    tempRoom = currentRoom.GoWest;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.Write("Not one of the options, ");
                    break;
            }
            if (tempRoom == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("You can't go that way.");
                continue;
            }
            lastRoom = currentRoom;
            currentRoom = tempRoom;

            printDescription();
        }

        void printDescription()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(currentRoom.Description);
        }

        void printPrelude()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to my shit game :D");
            Console.WriteLine("in this game you are in a building of some sort or something.");
            Console.WriteLine("you move by writing north, south, west or east, or their corresponding first letter.");
            Console.WriteLine("Press Enter to Start!");
            Console.ReadLine();
            Console.Clear();


        }
    }
}