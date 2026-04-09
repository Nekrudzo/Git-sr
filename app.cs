// version 1.0.0
using System;
   class App {
    static int Subtract(int a, int b){
        return a - b;
    }

        static int Multiply(int a, int b){
        return a * b;
    }
    
        static int Add(int a, int b){
        return a + b;
    }
       static void Main() {
        Console.Write("Введите первое число: ");
        string input1 = Console.ReadLine();
        int num1 = int.Parse(input1);
    
        Console.Write("Введите второе число: ");
        string input2 = Console.ReadLine();
        int num2 = int.Parse(input2);
    
        Console.Write("Выберите операцию (+, -, *): ");
        string operation = Console.ReadLine();
    
        int result = 0;
    
        if (operation == "+")
            result = num1 + num2;
        else if (operation == "-")
            result = num1 - num2;
        else if (operation == "*")
            result = num1 * num2;
    
        Console.WriteLine($"Результат: {result}");
       }
   }
