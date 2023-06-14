using Main;

bool Gameloop = true;

void setupGame()
{
    Player player = new Player();
    player.playerLoot[1] = Loot.test;
    player.playerLoot[2] = Loot.test;
    Console.WriteLine("test");
    Console.WriteLine(player.playerLoot[1].ToString());
}


while (Gameloop)
{
    setupGame();  
}