class Program
{
    /*В 5-ти поверховому будинку на кожному поверсі є 4 квартири. В
    кожній квартирі проживає від 1 до 5 людей. Створити прямокутний
    масив, в якому стовпчики – квартири, рядки – поверхи, масив [5,4].
    Заповнити масив числами від 1 до 5. Обчислити кількість мешканців.*/

    private static void Main(string[] args)
    {
        int[,] house = new int[5, 4];
        int people = 0;
        Random rnd = new Random();

        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                house[i, j] = rnd.Next(1, 5);
                people += house[i, j];
            }
        }
        Console.WriteLine($"Кількість мешканців: {people}");
    }
}