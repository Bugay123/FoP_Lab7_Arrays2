class Program
{
    /*Створити одновимірний масив з 16 елементів і заповнити його
    випадковими числами. Вивести на консоль елементи масиву.
    Відсортувати елементи масиву методом Array.Sort. Потім знайти
    найбільший і найменший елементи у відсортованому масиві.*/

    private static void Main(string[] args)
    {
        int[] m = new int[16];
        Random r = new Random();

        for(int i = 0; i < 16; i++)
        {
            m[i] = r.Next();
            Console.Write(m[i]+ " ");
        }
        Array.Sort(m);
        Console.WriteLine($"\nМінімальне значення в массиві: {m.GetValue(0)}\nМаксимальне значення в масиві: {m.GetValue(m.Length-1)}");
    }
}