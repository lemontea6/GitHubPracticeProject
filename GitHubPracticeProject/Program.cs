List<string> tasks = new List<string>
{
    "Learn commits",
    "Learn branches",
    "Learn pull requests"
};

Console.WriteLine("Team Task Tracker");
Console.WriteLine();

Console.Write("Enter a new task or leave empty: ");
string? newTask = Console.ReadLine();

if (!string.IsNullOrWhiteSpace(newTask))
{
    tasks.Add(newTask.Trim());
}

Console.WriteLine();

for (int index = 0; index < tasks.Count; index++)
{
    Console.WriteLine($"{index + 1}. {tasks[index]}");
}
Console.WriteLine($"The Total tasks - : {tasks.Count}");
