// // === Задание 1. Безопасный доступ к массиву ★ ===
// int[] numbers = [1, 2, 3, 5, 8];

// Console.Write("Индекс элемента (0-4): ");
// try {
//     int index = int.Parse(Console.ReadLine()!);
//     System.Console.WriteLine($"Значение: {numbers[index]}");
// }
// catch (FormatException) {
//     System.Console.WriteLine("Ошибка: введено не число");
// }
// catch (IndexOutOfRangeException) {
//     System.Console.WriteLine("Ошибка: неверный индекс");
// }

// === Задание 2. Валидатор возраста через throw ★★ ===
Console.Write("Возраст: ");
try {
    int userAge = int.Parse(Console.ReadLine()!);
    CheckAge(userAge);

    System.Console.WriteLine("Ошибок нет");
} catch (FormatException) {
    System.Console.WriteLine("Ошибка: введено не число");
} catch (ArgumentException ex) {
    System.Console.WriteLine($"Ошибка: {ex.Message}");
}

void CheckAge(int age) {
    if (age < 0 || age > 120) {
        throw new ArgumentException("Невозможный возраст");
    }
}