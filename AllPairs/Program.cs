using AllPairs;

if (args.Length < 2) return;
var pair = new Pair(args);
while (pair.HasNext())
{
    pair.Show();
    pair.Next();
}
