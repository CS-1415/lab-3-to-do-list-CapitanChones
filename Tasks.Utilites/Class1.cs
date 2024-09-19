namespace Utilites;

public class Task
{
    readonly int id;
    readonly string title;
    readonly string description;
    bool isComplete = false;

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
        return $"[{complete}]{tsk.id, -10}{tsk.title}";

    }

    public static string DisplayDescription(Task tsk)
    {
        return $"{tsk.title}:\n{tsk.description}";
    }




}
