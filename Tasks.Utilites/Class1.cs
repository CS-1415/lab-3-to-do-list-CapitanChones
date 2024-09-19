namespace Tasks.Utilites;

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

    public static string displayTask(Task tsk)
    {
        return" ";
    }




}
