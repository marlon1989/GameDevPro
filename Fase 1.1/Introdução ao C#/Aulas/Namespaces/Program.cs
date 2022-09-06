using System.Collections.Generic;

Console.ReadKey();

int[] myArray = new int[3];
myArray[0] = 1;
myArray[1] = 2;

//funcionalidade para mudar de tamanho
List<int> myList= new List<int>(3);

myList.Add(-23);
myList.Add(-23);
myList.Add(-23);
myList.Add(-23);
myList.Add(-23);
myList.RemoveAt(4);
//comando -> funções -> classes -> namespaces

foreach(int item in myList) {
Console.WriteLine(item);
}

Console.ReadKey();