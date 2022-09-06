string[] itemsList = new string[] {"espada", "escudo", "capacete"};

for(int i = 0; i < itemsList.Length; i++) {
    string item = itemsList[i];
    Console.WriteLine($"O item número {i + 1} é: {item}");
}

foreach(string item in itemsList) {
    Console.WriteLine($"O item número é: {item}");
}

int health = 10;
bool isPoisoned = true;
while(isPoisoned == true && health > 0) {
    health -= 1;
    Console.WriteLine($"Você tomou dano. Hitpoints remanescentes: {health}");
    Console.ReadKey();
}

while(true) {
    health -= 1;
    
    if(isPoisoned == false || health <= 0) {
        break;
    }

    Console.WriteLine($"Você tomou dano. Hitpoints remanescentes: {health}");
    Console.ReadKey();

}

Console.WriteLine("Jogador não tem mais nenhum hitpoint");

Console.ReadKey();