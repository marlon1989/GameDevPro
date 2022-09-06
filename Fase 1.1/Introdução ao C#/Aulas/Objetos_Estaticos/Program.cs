Player p1 = new Player();
Player p2 = new Player();

Console.WriteLine($"Initial Level: {Player.initialLevel}");

Console.WriteLine($"Nome do Player1 {p1.name}, Nome do Player2 {p2.name}");
p1.name = "Eu sou P1";
Console.WriteLine($"Nome do Player 1 {p1.name}, Nome do Player 2 {p2.name}");

Console.ReadKey();
class Player {

    public string name = "NONAME";
    public int level = 1;

    public static int initialLevel = 10;

    public void Test() {

        Console.WriteLine($"{name}");
    }

    public static void MyStaticFunction() {

        Console.WriteLine($"{initialLevel}");
    }
}

