class Program
{
    /*Створити у коді 2 матриці розміром [3,3] і заповнити їх у коді
    цілими числами. Обчислити добуток матриць в третій матриці.
    Результат вивести на консоль по рядках.*/

    private static void Main(string[] args)
    {
        int[,] m1 ={
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 } };
        int[,] m2 ={
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 } };
        int[,] m3 = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    m3[i, j] += m1[i, k] * m2[k, j];
                }
            }
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{m3[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
}