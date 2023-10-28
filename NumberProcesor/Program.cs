 static List<double> ProcessNumbers(List<int> numbers)
{
    List<double> result = new();

    foreach (int number in numbers)
    {
        if (number % 2 == 0)
        {
            result.Add(Math.Pow(number, 2));
        }
        else
        {
            if (number < 0)
            {
                throw new ArgumentException("Cannot calculate square root of negative number.");
            }

            result.Add(Math.Round(Math.Sqrt(number),2));
        }
    }

    return result;
}

List<int> num=Console.ReadLine().Split(' ').Select(int.Parse).ToList();

ProcessNumbers(num);

Console.WriteLine(string.Join(" ", ProcessNumbers(num)));