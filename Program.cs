using System.Diagnostics.CodeAnalysis;
using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

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

// === Задание 2. Валидатор возраста через throw ★★ ===
Console.Write("Возраст: ");
try {
    int userAge = int.Parse(Console.ReadLine()!);
    CheckAge(userAge);

    System.Console.WriteLine("Ошибок нет");
}
catch (FormatException) {
    System.Console.WriteLine("Ошибка: введено не число");
}
catch (ArgumentException ex) {
    System.Console.WriteLine($"Ошибка: {ex.Message}");
}

void CheckAge(int age) {
    if (age < 0 || age > 120) {
        throw new ArgumentException("Невозможный возраст");
    }
}

// === Задание 3. Банковский счёт с двумя своими исключениями ★★★ ===
double userBalance = 10000;

System.Console.WriteLine($"На счёте: {userBalance}");
Operation act;
do {
    System.Console.WriteLine();
    System.Console.WriteLine("=== МЕНЮ ===");

    bool hasAct;
    do {
        Console.Write("Выберите действие (Deposit, Withdraw, Exit): ");
        hasAct = Enum.TryParse<Operation>(Console.ReadLine()!, true, out act);

        if (!hasAct) {
            System.Console.WriteLine("Несуществующая операция. Попробуйте снова");
            System.Console.WriteLine();
        }
    } while (!hasAct);

    System.Console.WriteLine();
    double amountInput;
    try {
        switch (act) {
            case Operation.Deposit:
                Console.Write("Введите сумму для пополнения: ");
                amountInput = double.Parse(Console.ReadLine()!);
                Deposit(ref userBalance, amountInput);
                break;
            case Operation.Withdraw:
                Console.Write("Введите сумму для снятия: ");
                amountInput = double.Parse(Console.ReadLine()!);
                Withdraw(ref userBalance, amountInput);
                break;
            default:
                System.Console.WriteLine("До свидания!");
                break;
        }
    }
    catch (FormatException) {
        System.Console.WriteLine("Ошибка: Введено не число");
    }
    catch (InvalidAmountException ex) {
        System.Console.WriteLine($"Ошибка: {ex.Message}");
    }
    catch (InsufficientFundsException ex) {
        System.Console.WriteLine($"Ошибка: {ex.Message}");
    }
    finally {
        System.Console.WriteLine($"Текущий баланс: {userBalance}");
    }
} while (act != Operation.Exit);

void Deposit(ref double balance, double amount) {
    if (amount <= 0) {
        throw new InvalidAmountException("Невозможно внести меньше нуля или ноль");
    }
    balance += amount;
}

void Withdraw(ref double balance, double amount) {
    if (amount <= 0) {
        throw new InvalidAmountException("Невозможно снять меньше нуля или ноль");
    }
    if (amount > balance) {
        throw new InsufficientFundsException("Недостаточно средств на счёте");
    }
    balance -= amount;
}

class InsufficientFundsException : Exception {
    public InsufficientFundsException(string message) : base(message) { }
}

class InvalidAmountException : Exception {
    public InvalidAmountException(string message) : base(message) { }
}

enum Operation {
    Deposit,
    Withdraw,
    Exit
}