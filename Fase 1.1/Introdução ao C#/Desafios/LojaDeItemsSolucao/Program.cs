List<string> itemOptions = new List<string>() { "Pão de Queijo", "Acarajé", "Feijoada" };
List<int> itemPrices = new List<int>() { 1, 3, 3};

int playerCoinCount = 5;
List<string> playerItems = new List<string>();

PrintLineAndWait("Bem vindo a nossa loja!");
PrintLineAndWait("Eu vejo que voce tem muitos coins com voce...");
PrintLineAndWait("Hmmm... voce quer dar uma olhada no nosso inventario? Sim ou sim? :)");

//enquanto o jogador puder comprar alguma coisa
while(CanBuyAnyItem(playerCoinCount, itemPrices)) {

    PrintStoreOptions(itemOptions, itemPrices);
    playerCoinCount = TryBuyItem(itemOptions, itemPrices, playerCoinCount, playerItems);

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

static void PrintStoreOptions(List<string> itemOptions, List<int> itemPrices) {

    Console.WriteLine();
    Console.WriteLine("Essas são as nossas opções: ");

    for(int i = 0; i < itemOptions.Count; i++) {
        Console.WriteLine($"{i + 1}: {itemOptions[i]} - {itemPrices[i]}");
        Console.WriteLine();
    }
}

static void PrintPlayerItems(List<string> playerItems) {

    Console.WriteLine("Você não consegue comprar mais nada! Esses são os seus items: ");

    foreach(var item in playerItems) {
        Console.WriteLine($"- {item}");
    }
}

static int TryBuyItem(List<string> itemOptions, List<int> itemPrices, int playerCoinCount, List<string> playerItems) {

    string item = ReadItem("Digite o número do item que você quer comprar -> ", itemOptions);

    int itemIndex = itemOptions.IndexOf(item);
    int itemPrice = itemPrices[itemIndex];

    if(playerCoinCount >= itemPrice) {

        playerItems.Add(item);
        playerCoinCount -= itemPrice;
        Console.WriteLine();
        PrintLineAndWait($"Você comprou um {item} por ${itemPrice}! Você tem {playerCoinCount} coins.");
        Console.WriteLine();
    }
    else {

        Console.WriteLine();
        PrintLineAndWait($"Esse item custa {itemPrice} mas você só tem {playerCoinCount}");
        Console.WriteLine();
    }

    return playerCoinCount;
}

static bool CanBuyAnyItem(int playerCoinCount, List<int> itemPrices) {

    foreach(var price in itemPrices) {
        if(playerCoinCount >= price) {
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

static string ReadItem(string message, List<string> itemOptions) {

    int index = ReadNumber(message);
    index -= 1;

    while(index < 0 || index >= itemOptions.Count) {

        Console.WriteLine("Eu não conheço esse item. E você não sai daqui até comprar!");
        index = ReadNumber(message);
        index -= 1;
    }

    return itemOptions[index];
    
}