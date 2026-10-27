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

// // === ex.Message ===
// try {
//     int[] numbers = [1, 2, 3];
//     System.Console.WriteLine(numbers[10]);
// }
// catch (IndexOutOfRangeException ex) {
//     System.Console.WriteLine($"Произошла ошибка: {ex.Message}");
// }

// // === Несколько catch ===

// Console.Write("Введите делитель: ");
// try {
//     int divisor = int.Parse(Console.ReadLine()!);
//     int result = 100 / divisor;
//     System.Console.WriteLine($"Результат: {result}");
// } catch (FormatException) {
//     System.Console.WriteLine("ошибка: это не число");
// } catch (DivideByZeroException) {
//     System.Console.WriteLine("Ошибка: нельзя делить на ноль");
// } catch (Exception ex) {
//     System.Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");
// }

// === finally ===
try {
    System.Console.WriteLine("Пытаемся выполнить операцию...");
    int[] numbers = [1, 2, 3];
    System.Console.WriteLine(numbers[5]);
}
catch (IndexOutOfRangeException ex) {
    System.Console.WriteLine($"Ошибка: {ex.Message}");
}
finally {
    System.Console.WriteLine("Этот блок выполнится в любом случае");
}

// === finally без ошибки ===
System.Console.WriteLine();
try {
    System.Console.WriteLine("Операция без ошибок");
}
finally {
    System.Console.WriteLine("И здесь finally тоже сработал");
}