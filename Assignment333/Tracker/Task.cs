using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Enum for task priority
public enum TaskPriority
{
    Low,
    Medium,
    High
}


namespace Assignment333.Tracker
{
    // Task class
    public class UserTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskPriority Priority { get; set; }
        public bool IsCompleted { get; set; }

        public UserTask(string title, string description, TaskPriority priority)
        {
            Title = title;
            Description = description;
            Priority = priority;
            IsCompleted = false;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Title: {Title}, Priority: {Priority}, Completed: {IsCompleted}");
            Console.WriteLine($"Description: {Description}");
        }
    }


    // TaskList class with indexer
    // TaskList class with indexer
    public class TaskList
    {
        private List<UserTask> tasks = new List<UserTask>();

        // Add a task
        public void AddTask(UserTask task)
        {
            tasks.Add(task);
        }

        // Mark a task as complete
        public void MarkComplete(string taskTitle)
        {
            UserTask task = tasks.Find(t => t.Title.Equals(taskTitle, StringComparison.OrdinalIgnoreCase));
            if (task != null)
            {
                task.IsCompleted = true;
                Console.WriteLine($"✅ Task '{taskTitle}' marked as completed.");
            }
            else
            {
                Console.WriteLine($"⚠️ Task '{taskTitle}' not found.");
            }
        }

        // Show all tasks
        public void ShowAll()
        {
            Console.WriteLine("\n📋 All Tasks:");
            foreach (var task in tasks)
            {
                task.ShowDetails();
                Console.WriteLine();
            }
        }
        // Indexer to get tasks by priority
        public List<UserTask> this[TaskPriority priority]
        {
            get
            {
                return tasks.FindAll(t => t.Priority == priority);
            }
        }
    }



}