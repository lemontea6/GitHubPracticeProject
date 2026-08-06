

List<string> tasks = new List<string>
{
    "Learn commits",
    "Learn branches",
    "Learn pull requests"
};

Console.WriteLine("Team Task Tracker");
Console.WriteLine();

for (int index = 0; index < tasks.Count; index++)
{
    Console.WriteLine($"{index + 1}. {tasks[index]}");
}
Console.WriteLine($"Total tasks: {tasks.Count}");