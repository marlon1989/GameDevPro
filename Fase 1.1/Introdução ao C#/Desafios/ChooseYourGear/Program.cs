Introduction();

string[] option1 = new string[2] { "PANELA", "TRAVESSEIRO" };
string[] option2 = new string[2] {"ARMA", "GAMEBOY" };
string[] option3 = new string[2] {"CAMISA", "BARRA DE CHOCOLATE" };

string[][] allChoices = new string[][] {
    option1, option2, option3
};

string[] inventoryItems = new string[3];

for(int i = 0; i < inventoryItems.Length; i++) {

    string[] currentChoices = allChoices[i];
    string itemChoice = ReadItemOption(currentChoices);

    if(itemChoice != "") {
        inventoryItems[i] = itemChoice;
    }
    else {
        Console.WriteLine("Erro de input!");
    }
}

Console.Write("Suas escolhas foram: ");
foreach(string item in inventoryItems) {
    Console.Write($"{item}, ");
}

Console.ReadKey();

static void PrintLineAndWait(string message) {

    Console.WriteLine(message);
    Console.ReadKey();
}

static void Introduction() {

    PrintLineAndWait("Um apocalipse zumbi acabou de aconteçer do nada na sua cidade");
    PrintLineAndWait("Você começa a corre e pega tudo o que vê pela frente...");
}

static string ReadItemOption(string[] choices) {

    PrintLineAndWait($"Você se depara com um {choices[0]} e um {choices[1]}");
    int index = ReadNumberInput($"Digite 1 para pegar o {choices[0]} e 2 para pegar o {choices[1]} ");
    index -= 1;

    while(index < 0 || index >= choices.Length) {
        Console.WriteLine("ERRO: Por favor insira um input válido!");
        index = ReadNumberInput($"Digite 1 para pegar o {choices[0]} e 2 para pegar o {choices[1]} ");
    }

    return choices[index];
}

static int ReadNumberInput(string message) {
    Console.Write(message);

    try {
        return int.Parse(Console.ReadLine());
    }
    catch {
        return -1;
    }
}