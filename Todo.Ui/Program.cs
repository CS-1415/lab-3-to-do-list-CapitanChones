//Amando Thomas 9/18/24 Todo List Lab
using System.Runtime.CompilerServices;
using Utilites;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Utilites.Task> tasks = new List<Utilites.Task>()
            {
            new Utilites.Task(1, "Fix Leak", "Fix the Leak in the Cealing" ),
            new Utilites.Task(2, "Fix Leak 2", "Fix the Leak in the wall" ),
            new Utilites.Task(3, "Debug Code", "Go fix your Buggy gode you made last week" )
            };


        while (true)
        {


            Menu.NewMenu(tasks);

            switch (Menu.IsValidInput(Console.ReadKey(),
             "Press \"+\" to add a task, \"i\" to se a task description \"x\" to mark a task complete, and \"z\" to leave:",
             ['+', 'i', 'x', 'z']))
            {
                case '+':
                    Console.Clear();
                    Console.WriteLine("What is the name of your new task, then tell me what the descrioption is ");
                    string title = Console.ReadLine();
                    string desc = Console.ReadLine();
                    tasks.Add(new Utilites.Task(tasks.Count() + 1, title, desc));
                    Menu.NewMenu(tasks);
                    break;

                case 'i':
                    Console.Clear();
                    var ids = new List<char>();
                    for (int i = 0; i < tasks.Count; ++i)
                    {
                        ids.Add(i.ToString().ToCharArray()[0]);
                    }
                    Console.WriteLine($"which task do you want to see");
                    Utilites.Task.DisplayDescription(tasks[(int)Menu.IsValidInput(Console.ReadKey(), "which task do you want to see", ids.ToArray())]);
                    Menu.NewMenu(tasks);
                    break;


                case 'x':
                    Console.Clear();
                    ids = new List<char>();
                    for (int i = 0; i <= tasks.Count; i++)
                    {
                        ids.Add(i.ToString().ToCharArray()[0]);

                    }
                    Console.WriteLine($"which task do you want to Mark Complete");
                    Utilites.Task.MarkComplete(tasks[(int)Menu.IsValidInput(Console.ReadKey(), "which task do you want to see", ids.ToArray())]);
                    Menu.NewMenu(tasks);
                    break;

                case 'z':

                    Console.Clear();
                    Console.WriteLine("bye bye!");
                    return;

            }

        }


    }
}