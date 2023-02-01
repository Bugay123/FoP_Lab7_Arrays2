class Program
{

   /* 1. Створити прямокутний масив[6, 8] і заповнити його випадковими
        числами від 0 до 40. Знайти суму елементів першого рядка масиву і
        кількість його не нульових елементів.*/

    private static void Main(string[] args)
    {
        int[,] a = new int[6, 8];
        Random rnd = new Random();
        int sum = 0;
        int count = 0;

        for(int i = 0; i < 6; i++)
        {
            for(int j = 0; j < 8; j++)
            {
                a[i, j] = rnd.Next(0, 40); //заповнюємо массив

                if (i == 0) //вибираємо перший рядок
                {
                    sum += a[i, j]; // додаємо до сумми
                    if (a[i, j] > 0)    //перевіряємо чи число більше 0
                    {
                        count++;   //рахуємо число
                    }
                }
                
            }
        }
        Console.WriteLine($"Сумма: {sum}, кiлькiсть: {count}" );
    }
}