int myNumber = 20;
int[] numbers = new int[3] {-20, 2, 3};

Console.WriteLine(numbers[1]);
numbers[1] = 22;

Console.WriteLine(numbers[1]);
numbers[1] *= -1;

Console.WriteLine(numbers[1]);

int i = 5;

Console.WriteLine($"Tamanho do array {numbers.Length}");

if(i >= 0 && i < numbers.Length) {
    Console.WriteLine(numbers[i]);
}
else {
        Console.WriteLine("Indice fora do range do array");
}

Console.ReadKey();