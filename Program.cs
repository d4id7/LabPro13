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

// // === finally ===
// try {
//     System.Console.WriteLine("Пытаемся выполнить операцию...");
//     int[] numbers = [1, 2, 3];
//     System.Console.WriteLine(numbers[5]);
// }
// catch (IndexOutOfRangeException ex) {
//     System.Console.WriteLine($"Ошибка: {ex.Message}");
// }
// finally {
//     System.Console.WriteLine("Этот блок выполнится в любом случае");
// }

// // === finally без ошибки ===
// System.Console.WriteLine();
// try {
//     System.Console.WriteLine("Операция без ошибок");
// }
// finally {
//     System.Console.WriteLine("И здесь finally тоже сработал");
// }

// === throw ===
using System.Security.Principal;

try {
    double result = CalculateSquareRoot(-5);
    System.Console.WriteLine(result);
} catch (ArgumentException ex) {
    System.Console.WriteLine($"Ошибка: {ex.Message}");
}

double CalculateSquareRoot(double number) {
    if (number < 0) {
        throw new ArgumentException("Число не может быть отрицательным");
    }
    return Math.Sqrt(number);
}

// === Собственное исключение ===
System.Console.WriteLine();

try {
    Withdraw(1000, 1500);
}
catch (NegativeBalanceException ex) {
    System.Console.WriteLine($"Операция отклонена: {ex.Message}");
}

Withdraw(1000, 400);

void Withdraw(double balance, double amount) {
    if (amount > balance) {
        throw new NegativeBalanceException($"Недостаточно средств: на счёте {balance}, а нужно снять {amount}");
    }
    System.Console.WriteLine($"Снято {amount}, остаток {balance - amount}");
}

class NegativeBalanceException : Exception {
    public NegativeBalanceException(string message) : base(message) { }
}