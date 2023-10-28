static char[] RemoveStringNumbers(char[]? arr)
{
    if (arr is null)
    {
        throw new ArgumentException("Array can't be null.");
    }

    return arr.Where(c => !char.IsDigit(c)).ToArray();
}

char[] chars=Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

RemoveStringNumbers(chars);

Console.WriteLine(string.Join(" ",RemoveStringNumbers(chars)));
