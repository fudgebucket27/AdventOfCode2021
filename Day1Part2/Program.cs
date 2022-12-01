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
int[] previousSlidingWindow = new int[3];
int[] currentSlidingWindow = new int[3];
for (int i = 0; i <= depths.Count; i++)
{

    if (i == 3)
    {
        previousSlidingWindow[0] = depths[i - 3];
        previousSlidingWindow[1] = depths[i - 2];
        previousSlidingWindow[2] = depths[i - 1];
        Console.WriteLine($"{previousSlidingWindow[0]},{previousSlidingWindow[1]},{previousSlidingWindow[2]}");
    }
    else if(i > 3)
    {
      
        currentSlidingWindow[0] = depths[i - 3];
        currentSlidingWindow[1] = depths[i - 2];
        currentSlidingWindow[2] = depths[i - 1];
        Console.WriteLine($"{currentSlidingWindow[0]},{currentSlidingWindow[1]},{currentSlidingWindow[2]}");
        if (currentSlidingWindow.Sum() > previousSlidingWindow.Sum())
        {
            increasedCount++;
        }
        Array.Copy(currentSlidingWindow, previousSlidingWindow, 3);
    }


}

Console.WriteLine($"{increasedCount} measurements that are larger than the previous measurement");