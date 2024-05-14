using system.collection.Generic;
using system.linq;


public class TaskManager
{
    private list<Task> tasks = new list<Task> ();
    public list <Task> GetTasks()
    {
        return tasks;
    }

    public void AddTask(Task task)
    {
        task.Add(task);
    }
    public void DeleteTask(Task task)
    {
        task.Remove(task)
    }
    public void updateTask(Task task)
    {
        var existingTask =tasks. FirstOrDefault(t => t.Name ==task.Name);
        if(existingTask != null){
            existingTask.priority =task.priority;
            existingTask.DueDate = task.DueDate; 
        }
    }
}