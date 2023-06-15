using Main;

internal class Program
{
    private static void Main(string[] args)
    {
        bool Gameloop = true;

        Player player = new Player();
        player.playerItems.Add(Loot.test);
        player.playerItems.Add(Loot.test);

        Room room111 = new Room() { Description = "" };
        Room room112 = new Room() { Description = "" };
        Room room113 = new Room() { Description = "" };
        Room room114 = new Room() { Description = "" };
        Room room115 = new Room() { Description = "" };
        Room room116 = new Room() { Description = "" };
        Room room121 = new Room() { Description = "" };
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

        room111.AddEast(room112);
        room111.AddNorth(room121);
        room112.AddEast(room113);

        // Console.WriteLine(player.playerItems[int.Parse(siffra.ToString())]);
        // Console.ForegroundColor = ConsoleColor.Green;

        while (Gameloop)
        {
            
        }
    }
}