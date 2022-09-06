Console.WriteLine("Seja bem vindo! Escolha seu nível de dificuldade");
Console.WriteLine("As opções são: Iniciante, Normal e Expert");

string difficultyLevel = Console.ReadLine();
int enemyPower = 20;

if(difficultyLevel == "Iniciante") {
    Console.WriteLine("Você escolheu o nível iniciante");
    Console.WriteLine($"Força dos inimigos: {enemyPower}");
}
else if(difficultyLevel == "Normal") {
    Console.WriteLine("Você escolheu o nível normal");
    enemyPower *= 2;
    Console.WriteLine($"Força dos inimigos: {enemyPower}");
}
else if(difficultyLevel == "Expert") {
    Console.WriteLine("Você escolheu o nível expert");
    enemyPower *= 5;
    Console.WriteLine($"Força dos inimigos: {enemyPower}");
}
else {
    Console.WriteLine("Nível de dificuldade incorreto. Por favor digite Iniciante, Normal ou Expert");
}

Console.ReadKey();