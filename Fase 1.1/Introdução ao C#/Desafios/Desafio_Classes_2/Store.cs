public class Store {

    private List<Item> items;

    public Store() {

        items = new List<Item>() {

            new Item("Pão de Queijo", 1),
            new Item("Acarajé", 3),
            new Item("Feijoada", 3)
        };
    }

    public void PrintGreetings() {

        PrintLineAndWait("Bem vindo a nossa loja!");
        PrintLineAndWait("Eu vejo que voce tem muitos coins com voce...");
        PrintLineAndWait("Hmmm... voce quer dar uma olhada no nosso inventario? Sim ou sim? :)");

    }

    public void ExecuteStoreLoop(Player player) {

        while(player.CanBuyAny(items)) {

            PrintStoreOptions();
            Item item = ReadItem("Digite o número do item que você quer comprar -> ");

            if(player.TryPurchaseItem(item)) {

                Console.WriteLine();
                PrintLineAndWait($"Você comprou um {item.Name} por {item.Price}! Você tem {player.Money} coins");
            }
            else {

                Console.WriteLine();
                PrintLineAndWait($"Esse item custa {item.Price} mas você só tem {player.Money}");
                Console.WriteLine();
            }
        }
    }

    public void PrintEnding(Player player) {

        Console.WriteLine();
        Console.WriteLine("Você não consegue comprar mais nada! Esses são os seus items: ");
        player.PrintPlayerItems();

        Console.WriteLine();
        Console.ReadKey();
        PrintLineAndWait("...");
        PrintLineAndWait("É uma pena que esses items são apenas bits no seu computador...");

    }

    private int ReadNumber(string message) {

        Console.Write(message);
        string input = Console.ReadLine();
        int number;

        if(int.TryParse(input, out number)) {

            return number;
        }
        
        return -1;
    }

    private Item ReadItem(string message) {

        int index = ReadNumber(message);
        index -= 1;

        while(index < 0 || index >= items.Count) {

            Console.WriteLine("Eu não conheço esse item. E você não sai daqui até comprar!");
            index = ReadNumber(message);
            index -= 1;
        }

        return items[index];
    }

    private void PrintStoreOptions() {

        Console.WriteLine();
        Console.WriteLine("Essas são as nossas opções: ");

        for(int i = 0; i < items.Count; i++) {

            Console.WriteLine($"{i + 1}: {items[i].Name} - {items[i].Price}");
        }
    }

    private void PrintLineAndWait(string message) {

        Console.WriteLine(message);
        Console.ReadKey();
    } 
}