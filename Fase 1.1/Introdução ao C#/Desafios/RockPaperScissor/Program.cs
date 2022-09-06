Introduction();

PrintLine();

Tipo tipoEscolha = LerTipo($"Escolha {Tipo.Rock}, {Tipo.Paper} ou {Tipo.Scissor} --> ");

    switch(tipoEscolha) {

        case Tipo.Rock:
            PrintMessageAndWait("Eu escolhi paper. Você perdeu!");
        break;

        case Tipo.Paper:
            PrintMessageAndWait("Eu escolhi scissor. Você perdeu!");
        break;

        case Tipo.Scissor:
            PrintMessageAndWait("Eu escolhi rock. Você perdeu!");
        break;

        default:
            PrintMessageAndWait("Você não sabe jogar Rock, Paper ou Siccors? ._.");
        break;
    }

Console.ReadKey();

static void PrintMessageAndWait(string message) {

    Console.WriteLine(message);
    Console.ReadKey();
}

static void PrintLine() {

    Console.WriteLine();
    Console.WriteLine("--------------------");
    Console.WriteLine();
}

static void Introduction() {

    PrintMessageAndWait("Bem vindo ao Rock, Paper and Scisor com uma AI!");
    PrintMessageAndWait("Esse é o meu território, então voçê não tem chance.");
    PrintMessageAndWait("(É sério, eu que fiz esse jogo)");

}

static Tipo LerTipo(string message) {

    Console.Write(message);
    string input = Console.ReadLine();
    Tipo option;

    if(Enum.TryParse<Tipo>(input, out option)) {
        return option;
    }
    else {
        return Tipo.Uknown;
    }
}

enum Tipo {

    Uknown = -1,
    Rock,
    Paper,
    Scissor,
}