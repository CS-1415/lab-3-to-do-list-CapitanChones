namespace Utilites;

public class Task
{
    readonly int id;
    readonly string title;
    readonly string description;
    public bool isComplete = false;

    public Task(int _id, string _title, string _description)
    {
        id = _id;
        title = _title;
        description = _description;

    }

    public static string DisplayTask(Task tsk)
    {
        string complete = " ";
        if (tsk.isComplete) { complete = "x"; }
        return $"[{complete}]{tsk.id,-10}{tsk.title}";

    }

    public static string DisplayDescription(Task tsk)
    {
        return $"{tsk.title}:\n{tsk.description}";
    }

    public static void MarkComplete(Task tsk)
    {
        tsk.isComplete = true;
    }




}
public class Menu
{
    public static char IsValidInput(ConsoleKeyInfo input, string msg, params char[] desired)
    {
        while (!desired.Contains(input.KeyChar))
        {
            Console.WriteLine(input.KeyChar + " is not an option. " + msg);
            IsValidInput(Console.ReadKey(), msg, desired);
        }
        return input.KeyChar;

    }

    public static void NewMenu(List<Task> tasks)
    {
        Console.Clear();
        Console.WriteLine($"{"ID",5}{"Task",12}");
        for (int i = 0; i < Console.WindowWidth; i++)
        {
            Console.Write("-");
        }
        foreach (Task t in tasks)
        {
            Console.WriteLine(Task.DisplayTask(t));
        }

        Console.WriteLine("Press \"+\" to add a task, \"i\" to se a task description \"x\" to mark a task complete, and \"z\" to leave:");

    }

}
