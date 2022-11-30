List<int> depths = new List<int>();
using (StreamReader streamReader = new StreamReader("input.txt"))
{
    string depth;
    while ((depth = streamReader.ReadLine()!) != null)
    {
        depths.Add(Int32.Parse(depth)); // Add to list.     
    }
}

int increasedCount = 0;
int previousDepth = 0;
int count = 0;
foreach(var currentDepth in depths)
{
    
    if (count == 0)
    {
        previousDepth = currentDepth;
        count++;
        continue;
    }
    if (currentDepth > previousDepth)
    {
        increasedCount++;
    }
    previousDepth = currentDepth;
    
}

Console.WriteLine($"{increasedCount} measurements that are larger than the previous measurement");