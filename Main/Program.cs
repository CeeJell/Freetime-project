using Main;
using static System.Formats.Asn1.AsnWriter;

internal class Program
{
    private static void Main(string[] args)
    {
        bool Gameloop = true;

        Player player = new Player();


        Room room111 = new Room() { Description = "11" };
        Room room112 = new Room() { Description = "12" };
        Room room113 = new Room() { Description = "13" };
        Room room114 = new Room() { Description = "14" };
        Room room115 = new Room() { Description = "15" };
        Room room116 = new Room() { Description = "16" };
        Room room121 = new Room() { Description = "21" };
        Room room124 = new Room() { Description = "" };
        Room room126 = new Room() { Description = "" };
        Room room131 = new Room() { Description = "" };
        Room room132 = new Room() { Description = "" };
        Room room133 = new Room() { Description = "" };
        Room room135 = new Room() { Description = "" };
        Room room136 = new Room() { Description = "" };
        Room room142 = new Room() { Description = "" };
        Room room143 = new Room() { Description = "" };
        Room room144 = new Room() { Description = "" };
        Room room146 = new Room() { Description = "" };
        Room room154 = new Room() { Description = "" };
        Room room155 = new Room() { Description = "" };
        Room room156 = new Room() { Description = "" };
        Room room163 = new Room() { Description = "" };
        Room room164 = new Room() { Description = "" };

        Room room213 = new Room() { Description = "" };
        Room room214 = new Room() { Description = "" };
        Room room221 = new Room() { Description = "" };
        Room room222 = new Room() { Description = "" };
        Room room224 = new Room() { Description = "" };
        Room room226 = new Room() { Description = "" };
        Room room232 = new Room() { Description = "" };
        Room room233 = new Room() { Description = "" };
        Room room234 = new Room() { Description = "" };
        Room room235 = new Room() { Description = "" };
        Room room236 = new Room() { Description = "" };
        Room room241 = new Room() { Description = "" };
        Room room242 = new Room() { Description = "" };
        Room room244 = new Room() { Description = "" };
        Room room246 = new Room() { Description = "" };
        Room room252 = new Room() { Description = "" };
        Room room253 = new Room() { Description = "" };
        Room room254 = new Room() { Description = "" };
        Room room255 = new Room() { Description = "" };
        Room room263 = new Room() { Description = "" };
        Room room265 = new Room() { Description = "" };

        Room room321 = new Room() { Description = "" };
        Room room322 = new Room() { Description = "" };
        Room room323 = new Room() { Description = "" };
        Room room324 = new Room() { Description = "" };
        Room room333 = new Room() { Description = "" };
        Room room341 = new Room() { Description = "" };
        Room room342 = new Room() { Description = "" };
        Room room343 = new Room() { Description = "" };
        Room room344 = new Room() { Description = "" };
        Room room345 = new Room() { Description = "" };
        Room room353 = new Room() { Description = "" };
        Room room363 = new Room() { Description = "" };

        Room room414 = new Room() { Description = "" };
        Room room421 = new Room() { Description = "" };
        Room room422 = new Room() { Description = "" };
        Room room423 = new Room() { Description = "" };
        Room room424 = new Room() { Description = "" };
        Room room431 = new Room() { Description = "" };
        Room room441 = new Room() { Description = "" };
        Room room442 = new Room() { Description = "" };
        Room room451 = new Room() { Description = "" };
        Room room461 = new Room() { Description = "" };
        Room room462 = new Room() { Description = "" };
        Room room463 = new Room() { Description = "" };
        Room room464 = new Room() { Description = "" };
        Room room465 = new Room() { Description = "" };
        Room room466 = new Room() { Description = "" };

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
        room146.AddNorth(room146);
        room154.AddEast(room155);
        room154.AddNorth(room164);
        room155.AddEast(room156);
        room163.AddEast(room164);

        // Console.WriteLine(player.playerItems[int.Parse(siffra.ToString())]);
        // Console.ForegroundColor = ConsoleColor.Green;

        while (Gameloop)
        {
            Console.WriteLine("Do you want to go North, South, East or West?");
            Console.WriteLine();

            string keyPressed = Console.ReadLine().ToLower();

            tempRoom = null;
            switch (keyPressed)
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
                    System.Console.Write("Not one of the options, ");
                    break;
            }
            if (tempRoom == null)
            {
                System.Console.WriteLine("You can't go that way.");
                continue;
            }
            lastRoom = currentRoom;
            currentRoom = tempRoom;

            writeDescription();
        }

        void writeDescription()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(currentRoom.Description);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}