// See https://aka.ms/new-console-template for more information
Console.WriteLine ("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [m, n];
for (int i = 0; i < m; i++) {
    for (int j = 0; j < n; j++) {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write( matrix[i,j]+ " ");
    }
    Console.WriteLine();
}
Console.WriteLine ("Введите номер строки в матрице");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите номер столбца в матрице");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 - 1 < m && number2 - 1 < n) {
    Console.WriteLine($"Вот число лежащее на этой позиции: {matrix[number1 -1, number2 - 1]}");
}
else {
    Console.WriteLine("Такой позиции нет в матрице");
}