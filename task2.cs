namespace задача2_лаб2
{
    internal class task2
    {
        static void Main(string[] args)
        {
            //variant 10, task 25
            double elSequence;
            string input;
            bool isAppropriate;
            double minEl = Double.MaxValue;
            int minElPosition = 1;
            int currentPosition = 0;
            //hello
            Console.WriteLine("Добро пожаловать! Данная программа поможет вам найти порядковый номер минимального элемента в последовательности.");
            //checking whether 1st element is 0
            do
            {
                currentPosition++;
                Console.WriteLine("Введите очередной числовой элемент последовательности; если в последовательности не осталось элементов, введите 0:");
                input = Console.ReadLine();
                isAppropriate = double.TryParse(input, out elSequence) && elSequence >= Double.MinValue && elSequence <= Double.MaxValue;
                if (isAppropriate == false)
                {
                    Console.WriteLine("Ошибка при вводе числового элемента: возможно, вы ввели слишком маленькое (слишком большое) число или не число");
                }
            } while (!isAppropriate);
            if (elSequence == 0)
            {
                Console.WriteLine("Последовательность пустая, поэтому в ней невозможно определить минимум и его позицию");
            }
            //if not 0, entering the whole sequence and giving an answer
            else
            {
                do
                {
                    if (elSequence < minEl)
                    {
                        minEl = elSequence;
                        minElPosition = currentPosition;
                    }
                    currentPosition++;
                    do
                    {
                        Console.WriteLine("Введите очередной числовой элемент последовательности; если в последовательности не осталось элементов, введите 0:");
                        input = Console.ReadLine();
                        isAppropriate = double.TryParse(input, out elSequence) && elSequence >= Double.MinValue && elSequence <= Double.MaxValue;
                        if (isAppropriate == false)
                        {
                            Console.WriteLine("Ошибка при вводе числового элемента: возможно, вы ввели слишком маленькое (слишком большое) число или не число");
                        }
                    } while (!isAppropriate);
                } while (elSequence != 0 && currentPosition <= Int32.MaxValue);
                if (elSequence != 0 && currentPosition > Int32.MaxValue)
                {
                    Console.WriteLine($"Вы ввели слишком много элементов. На настоящий момент минимальный элемент последовательности {minEl} впервые встречается на {minElPosition} месте в последовательности.");
                }
                else
                {
                    Console.WriteLine($"Минимальный элемент последовательности {minEl} впервые встречается на {minElPosition} месте в последовательности.");
                }
            }
        }
    }
}
