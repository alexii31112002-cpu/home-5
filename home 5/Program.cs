Console.WriteLine("--Улучшенный Калькулятор--");

double firstNum = GetNum("Введите первое число:");
double secondNum = GetNum("Введите второе число:");


Console.WriteLine("Введите оператор: +, -, *, /");
string oper = Console.ReadLine();

Calculate(firstNum, secondNum, oper);

Console.ReadLine();

static double GetNum(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

static void Calculate(double firstNum, double secondNum, string oper)
{
    switch (oper)
    {
        case "+":
            Console.WriteLine($"Сложение: {firstNum} + {secondNum} = {firstNum + secondNum}");
            break;
        case "-":
            Console.WriteLine($"Вычитание: {firstNum} - {secondNum} = {firstNum - secondNum}");
            break;
        case "*":
            Console.WriteLine($"Умножение: {firstNum} * {secondNum} = {firstNum * secondNum}");
            break;
        case "/":
            if (secondNum == 0)
            {
                Console.WriteLine("Ошибка: Делить на 0 нельзя!");
            }
            else
            {
                Console.WriteLine($"Деление: {firstNum} / {secondNum} = {firstNum / secondNum}");
            }
            break;
        default:
            Console.WriteLine("Вы ввели неправильный оператор");
            break;
    }
}
