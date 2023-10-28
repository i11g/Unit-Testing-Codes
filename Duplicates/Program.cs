using System.Security.Cryptography.X509Certificates;

static int[] RemoveDuplicates(int[] numbers)
{
    HashSet<int> uniqueNumbers = new();

    foreach (int number in numbers)
    {
        uniqueNumbers.Add(number);
    }

    return uniqueNumbers.ToArray();
}

int[] num=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

RemoveDuplicates(num);
Console.WriteLine(string.Join(" ",RemoveDuplicates(num)));