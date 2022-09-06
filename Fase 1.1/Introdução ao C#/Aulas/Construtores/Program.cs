Player p1 = new Player();
Player p2 = new Player("Player2", 10);

//Inicializadores
Player p3 = new Player() {

    name = "Player3",
    level = 4
};

//Player p3 = new Player();
//p3.name = "Player3";
//p3.level = 4;

Console.WriteLine($"Player 1: {p1.name}, {p2.level}");
Console.WriteLine($"Player 2: {p2.name}, {p2.level}");

Console.ReadKey();

class Player {

    public string name;
    public int level;

    public Player() {
        name = "NONAME";
        level = 1;
        Console.WriteLine("Construindo o PLayer!");
    }

    public Player(string name, int level) {

        this.name = name;
        this.level = level;
    }
}