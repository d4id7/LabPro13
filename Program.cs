// === SafeCalculator ===
using System.Globalization;
bool wantToContinue;
do {
    Console.Write("Первое число: ");
    string numInput1 = Console.ReadLine()!;
    Console.Write("Второе число: ");
    string numInput2 = Console.ReadLine()!;
    Console.Write("Операция (+, -, *, /): ");
    string act = Console.ReadLine()!;

    try {
        int num1 = int.Parse(numInput1);
        int num2 = int.Parse(numInput2);

        switch (act) {
            case "+":
                System.Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;
            case "-":
                System.Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;
            case "*":
                System.Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;
            case "/":
                System.Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                break;
            default:
                throw new UnknownOperationException("Неизвестное действие");
        }
    }
    catch (FormatException) {
        System.Console.WriteLine("Ошибка: введено не число");
    }
    catch (DivideByZeroException) {
        System.Console.WriteLine("Ошибка: нельзя делить на ноль");
    }
    catch (UnknownOperationException ex) {
        System.Console.WriteLine($"Ошибка: {ex.Message}");
    }
    finally {
        System.Console.WriteLine(new string('-', 30));
    }

    string answerToContinue;
    do {
        System.Console.WriteLine("Продолжить? (Y/N)");
        answerToContinue = Console.ReadLine()!.ToLower();
        wantToContinue = answerToContinue == "y" || answerToContinue == "yes";
    } while (!(wantToContinue || answerToContinue == "n" || answerToContinue == "no"));

    System.Console.WriteLine();
} while (wantToContinue);

class UnknownOperationException : Exception {
    public UnknownOperationException(string message) : base(message) {}
}