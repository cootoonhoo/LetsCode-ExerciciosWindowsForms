int[] arr1 = new int[10], arr2 = new int[10], arr3 = new int[10];
int count = 0, num = 0;
string response;
bool teste;

do {
    do
    {
        Console.WriteLine($"Digte o {count+1}º número inteiro maior que 0");
        response = Console.ReadLine();
        teste = int.TryParse(response, out num) && num > 0;
        if (!teste) Console.WriteLine("Valor inválido");
    } while (!teste);
    arr1[count] = num;
    count++;
} while (count < 10);
Console.WriteLine("");

int j = 0, k= 0;
for (int i = 0; i < arr1.Length; i++) {
    if (arr1[i] % 2 == 0)
    {
        arr2[j] = arr1[i];
        j++;
    }
    else {
        arr3[k] = arr1[i];
        k++;
    }
}

Array.Sort(arr1);
Array.Sort(arr2);
Array.Sort(arr3);

Console.WriteLine("Numeros digitados:");
foreach (var numero in arr1)
{
    Console.Write(numero + " ");
}
Console.WriteLine("\nNumeros pares:");
foreach (var numero in arr2)
{
    if (numero != 0)
    Console.Write(numero + " ");
}
Console.WriteLine("\nNumeros impares:");
foreach (var numero in arr3)
{
    if(numero!=0)
    Console.Write(numero + " ");
}
