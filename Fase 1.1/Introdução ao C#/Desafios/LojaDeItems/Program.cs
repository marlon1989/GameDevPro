Introduction();

Console.ReadLine();

string[] itemOptions = new string[] {"Pão de Queijo", "Acarajé", "Feijoada"};
int[] totalItems = new int[3];

Menu();

Console.ReadLine();

int totalCoins = 5;

for(int i = totalCoins; i >= 1; i--) {

    int itemChoice = ReadInputNumber("Digite o número do item que você quer comprar -> ");

    switch(itemChoice) {
        
    }
    if(itemChoice == 1) {
        totalItems[0]++;
    }
    else if(itemChoice == 2) {
        totalItems[1]++;
    }else if(itemChoice == 3) {
        totalItems[2]++;
    }

    totalCoins--;

    Console.WriteLine($"Você comprou {itemOptions[itemChoice - 1]} por 1 coin! Você tem {totalCoins} coins."); 

}

Console.WriteLine("Todos os items comprados: ");

for(int i = 0; i < itemOptions.Length; i++) {
    Console.WriteLine($"{itemOptions[i]}: {totalItems[i]}");
}

Console.ReadKey();

static void PrintMessageAndWait(string message) {

    Console.WriteLine(message);
    Console.ReadKey();
}

static void Introduction() {

    PrintMessageAndWait("Bem vindo a nossa loja!");
    PrintMessageAndWait("Eu vejo que você tem muitos coins com você...");
    PrintMessageAndWait("Hum... você quer dar uma olhada no nosso inventário? Sim ou sim?");

}

static int ReadInputNumber(string message) {

    Console.Write(message);

    int number = int.Parse(Console.ReadLine());

    try {
        while(number <= 0 || number > 3) {

            Console.WriteLine("Opção inválida. Digite um número de acordo com o menu.");

            Console.Write(message);

            number = int.Parse(Console.ReadLine());
        }
        return number;
    }
    catch {
        return -1;
    }
}

static void Menu() {

    Console.WriteLine("Essa são as nossas opções:");
    Console.WriteLine("1: Pão de Queijo");
    Console.WriteLine("2: Acarajé");
    Console.WriteLine("3: Feijoada");

}