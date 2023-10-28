using System.Linq;

 static string[] ReverseStrings(string[] arr)
{
    return arr.Select(s => new string(s.Reverse().ToArray())).ToArray();
}


string[] array = Console.ReadLine().Split(' ').ToArray();

ReverseStrings(array);

ReverseStrings(array);

Console.WriteLine(string.Join(" ", ReverseStrings(array)));