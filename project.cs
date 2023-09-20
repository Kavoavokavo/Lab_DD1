using System;

class Calculator
{
    static void Main()
    {
        double num1, num2;
        char operation;

        Console.WriteLine("������� ���������� �����������");
        Console.WriteLine("��������� ��������: +, -, , /");

        Console.Write("������� ������ �����: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("������� ��������: ");
        operation = Console.ReadLine()[0]; // ������ ������� �������

        Console.Write("������� ������ �����: ");
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
            case '':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0) // �������� ������� �� ����
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("������: ������� �� ����!");
                    return;
                }
                break;
            default:
                Console.WriteLine("������: �������� ��������!");
                return;
        }

        Console.WriteLine($"���������: {num1} {operation} {num2} = {result}");
    }
}