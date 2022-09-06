
Console.ReadKey();

static void MathOperations() {

    int a = 2;
    int b = 3;

    Console.WriteLine(a + b);
    Console.WriteLine(a - b);
    Console.WriteLine(a * b);
    Console.WriteLine(b % a);

    // cast -> converte um tipo para o outro
    float resultadoDaDivisao = (float)a / b; // 0.6667
    Console.WriteLine(resultadoDaDivisao); // Divisão -> 0

    //Atribuições
    a = a + 2;
    a += 2;

    //Ordem de prioridade de operações
    a = 2;
    b = 3;
    int sum1 = a + b * a;
    int sum2 = (a + b) * a;
    Console.WriteLine("Sum1: ");
    Console.WriteLine(sum1);

    Console.WriteLine("Sum2: ");
    Console.WriteLine(sum2);
}

static void StringOperations() {

    string a = "Primeira mensagem";
    string b = "Segunda mensagem";
    Console.WriteLine(a + b);

    string nome = "teste";
    Console.WriteLine("Seu nome é: " + a + ", " + b + "," + nome);
    Console.WriteLine($"Seu nome é:{a}, {b}, {nome}");
}

static void BooleanOperations() {

    //retornam true ou false

    int a = 2;
    int b = 3;

    Console.WriteLine($"a > b ?: {a > b}");
    Console.WriteLine($"a < b ?: {a < b}");

    Console.WriteLine("2 >= 2? " + (2 >= 2));
    Console.WriteLine("0 <= 2? " + (0 <= 2));

    Console.WriteLine($"3 == 1 ?: {3 == 1}");
    Console.WriteLine($"3 != 3 ?: {3 != 3}");

    //Operacoes Booleanas puras
    // OR, AND e NOT
    //OR (||) -> True se QUALQUER valor for verdadeiro
    //AND (&&) -> True APENAS SE TODOS os valores forem verdadeiros
    //NOT (!) -> Nega o valor (True -> False, False -> True)

    bool bool1 = true;
    bool bool2 = false;

    Console.WriteLine("bool1 || bool2 ? " + (bool1 || bool2));
    Console.WriteLine("bool1 && bool2 ? " + (bool1 && bool2));
    Console.WriteLine("!bool1 ? " + (!bool1));
    Console.WriteLine("!!bool2 ? " + (!!bool2));
}
