public class Tasks
{
    public string Name {get; set;}
    public string priority{get; set;}
    public string DateTime DueDate{get;set;}

    public Task(string name, string priority, DateTime dueDate)
    {
        Name =name;
        priority =priority;
        DueDate =dueDate;
    }
}