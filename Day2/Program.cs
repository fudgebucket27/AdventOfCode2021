List<string> pilotCommands = new List<string>();
using (StreamReader streamReader = new StreamReader("input.txt"))
{
    string oilotCommand;
    while ((oilotCommand = streamReader.ReadLine()!) != null)
    {
        pilotCommands.Add(oilotCommand); // Add to list.     
    }
}

int horizontalPosition = 0;
int depth = 0;
foreach(string pilotCommand in pilotCommands)
{
    string[] command = pilotCommand.Split(' ');
    if(command[0] == "forward")
    {
        horizontalPosition += Int32.Parse(command[1]);
    }else if(command[0] == "down")
    {
        depth += Int32.Parse(command[1]);
    }
    else if (command[0] == "up")
    {
        depth -= Int32.Parse(command[1]);
    }
}

int finalDepthMultipledByfinalHorizontal = horizontalPosition * depth;
Console.WriteLine(finalDepthMultipledByfinalHorizontal);
