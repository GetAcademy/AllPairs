if (args.Length < 2) return;

var indexA = 0;
var indexB = 1;
var lastIndex = args.Length - 1;

while (indexA <= lastIndex && indexB <= lastIndex)
{
    Console.WriteLine($"{args[indexA]} {args[indexB]}");
    do
    {
        indexB++;
        if (indexB > lastIndex)
        {
            indexA++;
            indexB = indexA + 1;
        }
    } while (indexB == indexA);
}
