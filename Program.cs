namespace Learning2D_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // [,] defines that the array is 2D AKA has arrays within the array - remember that [] defines a normal array 
            int[,] numberGrid = {
                {1, 2},
                {3, 4 },
                {5, 6 },
                {6, 7 },
                {7, 8 },
                {8, 9 },
                {9, 10 },
                {10, 11 }
            };

            Console.WriteLine(numberGrid[0, 0]);

            Console.ReadLine();

        }
    }
}