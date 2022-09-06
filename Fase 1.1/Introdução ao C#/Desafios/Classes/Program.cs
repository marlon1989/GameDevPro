List<Item> items = new List<Item>() {

    new Item {

        Name = "Pão de Queijo",
        Price = 1
    },

    new Item {

        Name = "Acarajé",
        Price = 3

    },

    new Item {

        Name = "Feijoada",
        Price = 3
    }
};

int playerCoinCount = 5;
List<Item> playerItems = new List<Item>();

PrintLineAndWait("Bem vindo a nossa loja!");
PrintLineAndWait("Eu vejo que voce tem muitos coins com voce...");
PrintLineAndWait("Hmmm... voce quer dar uma olhada no nosso inventario? Sim ou sim? :)");

while(CanBuyAnyItem(playerCoinCount, items)) {

    PrintStoreOptions(items);
    playerCoinCount = TryBuyItem(items,playerCoinCount, playerItems);

}

Console.WriteLine();
PrintPlayerItems(playerItems);

Console.WriteLine();
Console.ReadKey();

PrintLineAndWait("...");
PrintLineAndWait("É uma pena que esses items são apenas bits no seu computador... ");

static void PrintLineAndWait(string message) {

    Console.WriteLine(message);
    Console.ReadKey();
    
}

static void PrintStoreOptions(List<Item> items) {

    Console.WriteLine();
    Console.WriteLine("Essas são as nossas opções: ");

    for(int i = 0; i < items.Count; i++) {
        Console.WriteLine($"{i + 1}: {items[i].Name} - {items[i].Price}");
        Console.WriteLine();
    }
}

static void PrintPlayerItems(List<Item> playerItems) {

    Console.WriteLine("Você não consegue comprar mais nada! Esses são os seus items: ");

    foreach(var item in playerItems) {
        Console.WriteLine($"- {item.Name}");
    }
}

static int TryBuyItem(List<Item> itemOptions, int playerCoinCount, List<Item> playerItems) {

    Item item = ReadItem("Digite o número do item que você quer comprar -> ", itemOptions);

    if(playerCoinCount >= item.Price) {

        playerItems.Add(item);
        playerCoinCount -= item.Price;
        Console.WriteLine();
        PrintLineAndWait($"Você comprou um {item.Name} por ${item.Price}! Você tem {playerCoinCount} coins.");
        Console.WriteLine();
    }
    else {

        Console.WriteLine();
        PrintLineAndWait($"Esse item custa {item.Price} mas você só tem {playerCoinCount}");
        Console.WriteLine();
    }

    return playerCoinCount;
}

static bool CanBuyAnyItem(int playerCoinCount, List<Item> items) {

    foreach(var item in items) {
        if(playerCoinCount >= item.Price) {
            return true;
        }
    }

    return false;
}

static int ReadNumber(string message) {

    Console.Write(message);
    string input = Console.ReadLine();
    int number;

    if(int.TryParse(input, out number)) {

        return number;
    }

    return -1;
}

static Item ReadItem(string message, List<Item> itemOptions) {

    int index = ReadNumber(message);
    index -= 1;

    while(index < 0 || index >= itemOptions.Count) {

        Console.WriteLine("Eu não conheço esse item. E você não sai daqui até comprar!");
        index = ReadNumber(message);
        index -= 1;
    }

    return itemOptions[index];
    
}

class Item {

    public string Name;
    public int Price;

}