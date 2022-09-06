Player p1 = new Player("P1", 1, 100);
Console.WriteLine($"Player1: {p1.Name}, {p1.Level}, {p1.Money}");
p1.Name = "NewName";
Console.WriteLine($"Player1: {p1.Name}");

Console.ReadKey();


//public, private, protected, internal
/*
1 - private por default
2 - usa getters e/ou setters para expor acesso aos membros da classe
3 - ter poucos métodos públicos
*/

//Propriedades(properties)
//Parece uma variável da classe, mas é um getter ou setter.

class Player {

    private string name;

    public string Name {
        get => name;
        set => name = value;
    }

    private int level;
    public int Level => level;

    //auto property
    public int Money { get; private set; }

    public Player(string name, int level, int money) {

        this.name = name;
        this.level = level;
        Money = money;

    }

    public void GiveXp(int xpAmount) {

        //dar experiência ao player
        //se passou de level -> level++
    }
}