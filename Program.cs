class Program
{
        static void Main(string[] args)
    {
        int rowNumber;
        do
        {
            Console.Write("Enter the layer of Pascal's triangle: ");
            if (!int.TryParse(Console.ReadLine(), out rowNumber))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                continue;
            }

            if (rowNumber < 0)
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
            }
            else
            {
                DisplayPascalTriangle(rowNumber);
            }

            Console.WriteLine();
        } while (rowNumber < 0);

    static void DisplayPascalTriangle(int rowNumber)
    {
        for (int i = 0; i <= rowNumber; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(CalculatePascalValue(i, j) + " ");
            }
            Console.WriteLine();
        }
    }

    static int CalculatePascalValue(int row, int column)
    {
        if (column == 0 || column == row)
        {
            return 1;
        }
        else
        {
            return CalculatePascalValue(row - 1, column - 1) + CalculatePascalValue(row - 1, column);
            }
        }
 
    }
}