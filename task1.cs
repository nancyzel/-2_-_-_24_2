namespace задача1_лаб2
{
    internal class task1
    {
        static void Main(string[] args)
        {
            //variant 10, task 10
            int n;
            double elSequence;
            string input;
            bool isAppropriate;
            double minEl=Double.MaxValue, maxEl=Double.MinValue;
            //hello
            Console.WriteLine("Добро пожаловать! Данная программа поможет вам найти наименьшее и наибольшее значения в числовой последовательности.");
            //entering number of elements in the sequence
            do
            {
                Console.WriteLine("Введите неотрицательное целое число n - количество чисел в последовательности:");
                input = Console.ReadLine();
                isAppropriate = int.TryParse(input, out n) && n >= 0 && n <= Int32.MaxValue;
                if (isAppropriate == false)
                {
                    Console.WriteLine($"Ошибка при вводе числа n: возможно, вы ввели отрицательное число, слишком большое число (больше {Int32.MaxValue}), не целое число или не число");
                }
            } while (!isAppropriate);
            //entering elements of the sequence and getting its max and min
            switch (n)
            {
                case 0 : Console.WriteLine("Последовательность пустая, поэтому в ней невозможно определить максимум и минимум"); break;
                case 1 : 
                    do
                    {
                        Console.WriteLine("Введите очередной числовой элемент последовательности:");
                        input = Console.ReadLine();
                        isAppropriate = double.TryParse(input, out elSequence) && elSequence >= Double.MinValue && elSequence <= Double.MaxValue;
                        if (isAppropriate == false)
                        {
                            Console.WriteLine("Ошибка при вводе элемента последовательности: возможно, вы ввели слишком маленькое (слишком большое) число или не число");
                        }
                    } while (!isAppropriate);
                    maxEl = elSequence;
                    Console.WriteLine($"В последовательности 1 элемент, поэтому максимум совпадает с минимумом. Минимум и максимум равны {maxEl}.");
                    break;
                default:
                    for (int i = 1; i <= n; i++)
                    {
                        do
                        {
                            Console.WriteLine("Введите очередной числовой элемент последовательности:");
                            input = Console.ReadLine();
                            isAppropriate = double.TryParse(input, out elSequence) && elSequence >= Double.MinValue && elSequence <= Double.MaxValue;
                            if (isAppropriate == false)
                            {
                                Console.WriteLine("Ошибка при вводе элемента последовательности: возможно, вы ввели слишком маленькое (слишком большое) число или не число");
                            }
                        } while (!isAppropriate);
                        if (elSequence < minEl)
                        {
                            minEl = elSequence;
                        };
                        if (elSequence > maxEl)
                        {
                            maxEl = elSequence;
                        };
                    };
                    Console.WriteLine($"Минимум последовательности равен {minEl}, максимум последовательности равен {maxEl}. Сумма максимума и минимума последовательности равна {minEl + maxEl}.");
                    break;
            }
        }
    }
}
