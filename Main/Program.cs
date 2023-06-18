using Main;
using static System.Formats.Asn1.AsnWriter;

internal class Program
{
    private static void Main(string[] args)
    {
        bool Gameloop = true;
        bool StartGame = true;

        Player player = new Player();


        Room room111 = new Room() { roomCoordinate = "Room 1.11", Description = "", whatDirections = "" };
        Room room112 = new Room() { roomCoordinate = "Room 1.12", Description = "", whatDirections = "" };
        Room room113 = new Room() { roomCoordinate = "Room 1.13", Description = "", whatDirections = "" };
        Room room114 = new Room() { roomCoordinate = "Room 1.14", Description = "", whatDirections = "" };
        Room room115 = new Room() { roomCoordinate = "Room 1.15", Description = "", whatDirections = "" };
        Room room116 = new Room() { roomCoordinate = "Room 1.16", Description = "", whatDirections = "" };
        Room room121 = new Room() { roomCoordinate = "Room 1.21", Description = "", whatDirections = "" };
        Room room124 = new Room() { roomCoordinate = "Room 1.24", Description = "", whatDirections = "" };
        Room room126 = new Room() { roomCoordinate = "Room 1.26", Description = "", whatDirections = "" };
        Room room131 = new Room() { roomCoordinate = "Room 1.31", Description = "", whatDirections = "" };
        Room room132 = new Room() { roomCoordinate = "Room 1.32", Description = "", whatDirections = "" };
        Room room133 = new Room() { roomCoordinate = "Room 1.33", Description = "", whatDirections = "" };
        Room room135 = new Room() { roomCoordinate = "Room 1.35", Description = "", whatDirections = "" };
        Room room136 = new Room() { roomCoordinate = "Room 1.36", Description = "", whatDirections = "" };
        Room room142 = new Room() { roomCoordinate = "Room 1.42", Description = "", whatDirections = "" };
        Room room143 = new Room() { roomCoordinate = "Room 1.43", Description = "", whatDirections = "" };
        Room room144 = new Room() { roomCoordinate = "Room 1.44", Description = "", whatDirections = "" };
        Room room146 = new Room() { roomCoordinate = "Room 1.46", Description = "", whatDirections = "" };
        Room room154 = new Room() { roomCoordinate = "Room 1.54", Description = "", whatDirections = "" };
        Room room155 = new Room() { roomCoordinate = "Room 1.55", Description = "", whatDirections = "" };
        Room room156 = new Room() { roomCoordinate = "Room 1.56", Description = "", whatDirections = "" };
        Room room163 = new Room() { roomCoordinate = "Room 1.63", Description = "", whatDirections = "" };
        Room room164 = new Room() { roomCoordinate = "Room 1.64", Description = "", whatDirections = "" };

        Room room213 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room214 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room221 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room222 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room224 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room226 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room232 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room233 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room234 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room235 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room236 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room241 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room242 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room244 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room246 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room252 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room253 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room254 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room255 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room263 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room265 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };

        Room room321 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room322 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room323 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room324 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room333 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room341 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room342 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room343 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room344 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room345 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room353 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room363 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };

        Room room414 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room421 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room422 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room423 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room424 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room431 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room441 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room442 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room451 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room461 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room462 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room463 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room464 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room465 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };
        Room room466 = new Room() { roomCoordinate = "Room ", Description = "", whatDirections = "" };

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
            Console.WriteLine(currentRoom.roomCoordinate);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(currentRoom.Description);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("'I can currently walk " +  currentRoom.whatDirections + "'");
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