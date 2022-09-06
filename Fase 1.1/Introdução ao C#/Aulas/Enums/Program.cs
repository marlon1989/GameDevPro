Console.WriteLine("Seja bem vindo! Escolha seu nível de dificuldade");
Console.WriteLine($"As opções são: {DifficultyLevel.Begginer}, {DifficultyLevel.Normal}, {DifficultyLevel.Expert}");
string difficultyLevelString = Console.ReadLine();

DifficultyLevel difficultyLevel;
bool success = Enum.TryParse<DifficultyLevel>(difficultyLevelString, out difficultyLevel);

if(success) {

    int enemyPower = 20;
    bool firstTimeUser = true;

    switch(difficultyLevel) {

        case DifficultyLevel.Begginer:
            Console.WriteLine("Você escolheu o nível Iniciante!");
            Console.WriteLine($"Força dos inimigos: {enemyPower}");
        break;
        
        case DifficultyLevel.Normal:
            Console.WriteLine("Você escolheu o nível Normal!");
            enemyPower *= 2;
            Console.WriteLine($"Força dos inimigos: {enemyPower}");
        break;

        case DifficultyLevel.Expert:
            if(firstTimeUser == true) {
                Console.WriteLine("Você não pode escolher Expert no seu primeiro playthrough!");
            }
            else {
                Console.WriteLine("Você escolheu o nível Expert!");
                enemyPower *= 5;
                Console.WriteLine($"Força dos inimigos: {enemyPower}");
            }
        break;

        default:
            Console.WriteLine($"Valor inesperado: {difficultyLevel}");
        break;
    }
}
else {
    Console.WriteLine($"Valor inesperado: {difficultyLevelString}");
}

Console.ReadKey();

enum DifficultyLevel { //Definindo um tipo customizável
    Begginer,
    Normal,
    Expert
}