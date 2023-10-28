 
static List<List<int>> MatrixAddition(List<List<int>> matrixA, List<List<int>> matrixB)
{
    if (matrixA.Count == 0 || matrixB.Count == 0)
    {
        return new();
    }

    if (matrixA.Count != matrixB.Count || matrixA[0].Count != matrixB[0].Count)
    {
        throw new ArgumentException("Matrices must have the same dimensions for addition.");
    }

    List<List<int>> result = new();

    for (int i = 0; i < matrixA.Count; i++)
    {
        List<int> row = new();

        for (int j = 0; j < matrixA[0].Count; j++)
        {
            row.Add(matrixA[i][j] + matrixB[i][j]);
        }

        result.Add(row);
    }

    return result;
}
static List<List<int>> ReadMatrixFromConsole()
{
    List<List<int>> matrix = new List<List<int>>();
    int numRows = int.Parse(Console.ReadLine());

    for (int i = 0; i < numRows; i++)
    {
        List<int> row = new List<int>();
        string[] values = Console.ReadLine().Split(' ');

        foreach (string value in values)
        {
            row.Add(int.Parse(value));
        }

        matrix.Add(row);
    }

    return matrix;
}

static void Main()
{
    Console.WriteLine("Enter the dimensions and values of matrix A:");
    List<List<int>> matrixA = ReadMatrixFromConsole();

    Console.WriteLine("Enter the dimensions and values of matrix B:");
    List<List<int>> matrixB = ReadMatrixFromConsole();

    try
    {
        List<List<int>> result = MatrixAddition(matrixA, matrixB);

        Console.WriteLine("Matrix A + Matrix B:");
        foreach (var row in result)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("Error: " + ex.Message);
    }
}
