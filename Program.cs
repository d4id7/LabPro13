// === try-catch: FormatException ===
try {
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());
    System.Console.WriteLine($"Вы ввели: {number}");
}
catch (FormatException) {
    System.Console.WriteLine("Ошибка: введено не число!");
}

System.Console.WriteLine("Программа продолжает работу как ни в чём не бывало");