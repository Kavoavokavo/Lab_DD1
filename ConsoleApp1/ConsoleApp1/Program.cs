using System;

class Calculator
{
    static void Main()
    {
        double num1, num2;
        char operation;

        Console.WriteLine("Простой консольный калькулятор");
        Console.WriteLine("Доступные операции: +, -, , /");

        Console.Write("Введите первое число: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите операцию: ");
        operation = Console.ReadLine()[0]; // Чтение первого символа

        Console.Write("Введите второе число: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0) // Проверка деления на ноль
                    {
                    result = num1 / num2;
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль!");
                    return;
                }
            default:
                Console.WriteLine("Неверная операция!");
                return;
        }

        Console.WriteLine($"Результат: {num1} {operation} {num2} = {result}");
    }
}