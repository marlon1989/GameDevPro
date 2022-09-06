public class Player {

    public int Money { get; private set; }
    public List<Item> Inventory { get; private set; }

    public Player(int money) {

        Money = money;
        Inventory = new List<Item>();
    }

    public bool CanBuyAny(List<Item> items) {

        foreach(var item in items) {
            if(CanBuy(item)) {
                return true;
            }
        }

        return false;
    }

    private bool CanBuy(Item item) {

        return Money >= item.Price;
    }

    public bool TryPurchaseItem(Item item) {

        if(CanBuy(item)) {
            Inventory.Add(item);
            Money -= item.Price;
            return true;
        }

        return false;
    }

    public void PrintPlayerItems() {

        foreach(var item in Inventory) {

            Console.WriteLine($"- {item.Name}");
        }
    }
}