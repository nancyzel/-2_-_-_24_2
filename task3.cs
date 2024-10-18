namespace задача3_лаб2
{
    internal class task3
    {
        static void Main(string[] args)
        {
            //variant 10, task 44
            long k;
            string input;
            bool isAppropriate, isDegree = false;
            const double baseNumb = 3;
            int maxDegree = (int)Math.Log(Int64.MaxValue, baseNumb);
            int degree;
            long currentK;
            //hello
            Console.WriteLine("Добро пожаловать! Данная программа поможет вам узнать, является ли заданное вами число k степенью числа 3.");
            //entering k
            do
            {
                Console.WriteLine("Введите целое положительное число k");
                input = Console.ReadLine();
                isAppropriate = Int64.TryParse(input, out k) && k > 0 && k <= Int64.MaxValue;
                if (isAppropriate == false)
                {
                    Console.WriteLine($"Ошибка при вводе числа k: возможно, вы ввели слишком большое число (больше {Int64.MaxValue}), или не целое число, или неположительное число, или не число");
                }
            } while (!isAppropriate);
            //finding and giving an answer
            degree = 0;
            if (k == 1)
            {
                Console.WriteLine($"Число {k} равно 3^{degree}.");
            }
            else
            {
                currentK = k;
                while (currentK > 3)
                {
                    currentK /= 3;
                    degree++;
                }
                isDegree = currentK % 3 == 0;
                if (!isDegree)
                {
                    Console.WriteLine($"Число {k} не является целой степенью числа 3.");
                }
                else
                {
                    Console.WriteLine($"Число {k} равно 3^{++degree}.");
                }
            }
        }
    }
}

