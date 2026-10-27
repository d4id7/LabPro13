// === Задание 1. Безопасный доступ к массиву ★ ===
int[] numbers = [1, 2, 3, 5, 8];

Console.Write("Индекс элемента (0-4): ");
try {
    int index = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine($"Значение: {numbers[index]}");
}
catch (FormatException) {
    System.Console.WriteLine("Ошибка: введено не число");
}
catch (IndexOutOfRangeException) {
    System.Console.WriteLine("Ошибка: неверный индекс");
}
