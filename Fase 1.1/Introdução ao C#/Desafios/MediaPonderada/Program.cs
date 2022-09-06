int nota1 = ReadInputNumber("Digite a primeira nota: ");
int nota2 = ReadInputNumber("Digite a segunda nota: ");
int nota3 = ReadInputNumber("Digite a terceira nota: ");

int totalSum = nota1 + nota2 * 2 + nota3 * 3;
float media = (float)(totalSum)/ 6;

bool passou = media >= 60; 

Console.WriteLine();
Console.WriteLine($"Média com peso(1, 2, 3): {media}");

Console.WriteLine($"Aprovado: {passou}");

Console.ReadKey();

static int ReadInputNumber(string message) {
    
    Console.Write(message);
     
    try {

        return int.Parse(Console.ReadLine());
    }
    catch (System.Exception) {

        return -1;
    }
}   