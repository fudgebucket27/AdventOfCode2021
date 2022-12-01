List<string> diagnosticReport = new List<string>();
using (StreamReader streamReader = new StreamReader("input.txt"))
{
    string bits;
    while ((bits = streamReader.ReadLine()!) != null)
    {
        diagnosticReport.Add(bits); // Add to list.     
    }
}

string gammaRate = "";
int index = 0;
List<string> ones = new List<string>();
List<string> zeroes = new List<string>();
while(index < 12)
{
    foreach(string line in diagnosticReport)
    {
        if(line[index] == '0')
        {
            zeroes.Add(line);
        }
        else if(line[index] == '1')
        {
            ones.Add(line);
        }
    }
    if(ones.Count > zeroes.Count)
    {
        gammaRate += "1";
    }
    else if(zeroes.Count > ones.Count)
    {
        gammaRate += "0";
    }
    ones.Clear();
    zeroes.Clear();
    index++;
}

string epsilonRate = "";
index = 0;
while (index < 12)
{
    foreach (string line in diagnosticReport)
    {
        if (line[index] == '0')
        {
            zeroes.Add(line);
        }
        else if (line[index] == '1')
        {
            ones.Add(line);
        }
    }
    if (ones.Count < zeroes.Count)
    {
        epsilonRate += "1";
    }
    else if(zeroes.Count < ones.Count)
    {
        epsilonRate += "0";
    }
    ones.Clear();
    zeroes.Clear();
    index++;
}

Console.WriteLine($"Gamma Rate: {gammaRate} , Epsilon Rate: {epsilonRate}");
Console.WriteLine($"Power consumption: {Convert.ToInt32(gammaRate, 2) * Convert.ToInt32(epsilonRate, 2)}");
