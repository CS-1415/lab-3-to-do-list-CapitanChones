using System.Diagnostics;
using Utilites;
namespace Tasks.Test;

public class UnitTest1
{
    [Fact]
    public void TestdisplayTask()
    {

        var t1 = new Utilites.Task(1, "Wash Car", "go get soap and a sponge and wash your car");
        var t2 = new Utilites.Task(43, "Go to Sleep", "lay down and go to bed");

        Debug.Assert(Utilites.Task.DisplayTask(t1) == $"[ ]{1,-10}Wash Car");
        Debug.Assert(Utilites.Task.DisplayTask(t2) == $"[ ]{43,-10}Go to Sleep");


    }
    [Fact]
    public void TestDisplayDescription()
    {
        var t1 = new Utilites.Task(1, "Wash Car", "go get soap and a sponge and wash your car");
        var t2 = new Utilites.Task(43, "Go to Sleep", "lay down and go to bed");

        Debug.Assert(Utilites.Task.DisplayDescription(t1) == $"Wash Car:\ngo get soap and a sponge and wash your car");
        Debug.Assert(Utilites.Task.DisplayDescription(t2) == $"Go to Sleep:\nlay down and go to bed");

    }
}