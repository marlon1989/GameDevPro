PlayIntroduction();

PrintDialogDivision();
PlayPlayerIntroduction();

PrintDialogDivision();
PlayRivalIntroduction();

PrintDialogDivision();
PrintDialogueEnd();

Console.ReadKey();

static string ReadTextInput(string message) {
    Console.Write(message);
    string input = Console.ReadLine();
    return input;
}

static void PrintDialogDivision() {

    Console.WriteLine();
    Console.WriteLine("----------------------------------");
    Console.WriteLine();

}

static void PrintLineAndWait(string message) {

    Console.WriteLine(message);
    Console.ReadKey();

}

static void PlayIntroduction() {

    PrintLineAndWait("Olá pessoal! Bem vindos ao mundo Pokémon!");
    PrintLineAndWait("Sou Carvalho. Pode me chamar de POKEMON PROF!");
    PrintLineAndWait("Esse mundo é habitado por seres chamados Pokémons");
    PrintLineAndWait("Pessoas usam Pokémons para cuidar ou em confrontos");
    PrintLineAndWait("Já eu...");
    PrintLineAndWait("Estudo Pokémons como profissão");

}

static void PlayPlayerIntroduction() {

    string nomeDoPlayer = ReadTextInput("Primeiro, qual é o seu nome? --> ");

    Console.Write("Tudo bem! Seu nome é: ");
    PrintLineAndWait(nomeDoPlayer);

}

static void PlayRivalIntroduction() {
    
    PrintLineAndWait("Apresento meu neto. Ele é seu rival desde que vocês nasceram");

    string nomeDoRival = ReadTextInput("... Eu esqueci o nome do rapaz! Você pode me lembrar? --> ");

    Console.Write("Claro! Eu me lembro agora! O nome dele é: ");
    PrintLineAndWait(nomeDoRival);
}

static void PrintDialogueEnd() {

    PrintLineAndWait("Ache todos os Pokémons lendários desse mundo!");
    PrintLineAndWait("Um mundo de aventuras começa agora!");
}