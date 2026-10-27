// // === try-catch: FormatException ===
// try {
//     Console.Write("Введите число: ");
//     int number = int.Parse(Console.ReadLine());
//     System.Console.WriteLine($"Вы ввели: {number}");
// }
// catch (FormatException) {
//     System.Console.WriteLine("Ошибка: введено не число!");
// }

// System.Console.WriteLine("Программа продолжает работу как ни в чём не бывало");

// === ex.Message ===
using System.Security.Cryptography;

try {
    int[] numbers = [1, 2, 3];
    System.Console.WriteLine(numbers[10]);
}
catch (IndexOutOfRangeException ex) {
    System.Console.WriteLine($"Произошла ошибка: {ex.Message}");
}

// === Несколько catch ===

Console.Write("Введите делитель: ");
try {
    int divisor = int.Parse(Console.ReadLine()!);
    int result = 100 / divisor;
    System.Console.WriteLine($"Результат: {result}");
} catch (FormatException) {
    System.Console.WriteLine("ошибка: это не число");
} catch (DivideByZeroException) {
    System.Console.WriteLine("Ошибка: нельзя делить на ноль");
} catch (Exception ex) {
    System.Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
}