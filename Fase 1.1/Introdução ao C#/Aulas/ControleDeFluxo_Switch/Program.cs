Console.WriteLine("Seja bem vindo! Escolha seu nível de dificuldade");
Console.WriteLine("As opções são: Iniciante, Normal e Expert");

string difficultyLevel = Console.ReadLine();

switch(difficultyLevel) {

    case "Iniciante": 
        Console.WriteLine("Dificuldade Iniciante");
        break;
    
    case "Normal":
        Console.WriteLine("Dificuldade Normal");
        break;
    
    case "Expert":
        Console.WriteLine("Dificuldade Expert");
        break;
    
    default:
        Console.WriteLine($"Nível de dificuldade Inesperado: {difficultyLevel}");
        break;
}

Console.ReadKey();