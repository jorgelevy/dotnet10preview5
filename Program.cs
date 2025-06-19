// https://www.youtube.com/watch?v=_XYuNrrbMPg
// https://www.netmentor.es/entrada/extension-members-csharp


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// List<int> values = new List<int> { 0,5,6,9,20,55,99 };
List<int> values = new List<int> { };

IEnumerable<int> result = values.WhereGreaterThan(18);
Console.WriteLine("Values greater than 18:");
foreach (var value in result)
{
    Console.WriteLine(value);
}

if (result.IsEmpty)
{
	Console.WriteLine("There is no elements on the list");
}



public static class Extensions
{
	extension(IEnumerable<int> source)
	{
		public IEnumerable<int> WhereGreaterThan(int threshold)
			=> source.Where(x => x > threshold);

		public bool IsEmpty
		=> !source.Any();
	}
}