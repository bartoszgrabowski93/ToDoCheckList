using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoCheckList
{
    class TaskService
    {
        public List<Task> Tasks { get; set; }

        public TaskService()
        {
            Tasks = new List<Task>();
        }

        public void ViewTasks()
        {
            Console.WriteLine("Tasks: ");
            for (int i = 0; i < Tasks.Count; i++)
            {
                Console.WriteLine($"{Tasks[i].Id}. {Tasks[i].Name}");
            }
            if (Tasks.Count == 0)
            {
                Console.WriteLine("There are no tasks.");
            }

        }
        public void ViewTaskDetails()
        {
            Task taskDetails = new Task();
            Console.WriteLine(" Write tasks Id to get more information: ");
            var id = Console.ReadLine();
            int taskDetailsId;
            Int32.TryParse(id, out taskDetailsId);
            foreach (var task in Tasks)
            {
                if (task.Id == taskDetailsId)
                {
                    taskDetails = task;
                    break;
                }
            }
            Console.WriteLine("Task Id: " + taskDetails.Id);
            Console.WriteLine("Task Name: " + taskDetails.Name);
            if (taskDetails.Status == true)
            {
                Console.WriteLine("Tasl status: Done");
            }
            else
            {
                Console.WriteLine("Task status: Undone");
            }

        }
        public int AddTask()
        {
            Task task = new Task();
            Console.WriteLine(" Write your task Id: ");
            var id = Console.ReadLine();
            int taskId;
            Int32.TryParse(id, out taskId);
            Console.WriteLine(" State your task name: ");
            var taskName = Console.ReadLine();
            task.Id = taskId;
            task.Name = taskName;

            Tasks.Add(task);
            Console.WriteLine("Task added");
            return taskId;
        }

        public int RemoveTask()
        {
            Task taskToRemove = new Task();
            ViewTasks();

            Console.WriteLine("Which Task should be removed?");
            var userChoiceToRemove = Console.ReadLine();
            int taskToRemoveId;
                Int32.TryParse(userChoiceToRemove, out taskToRemoveId);

            foreach(var task in Tasks)
            {
                if(task.Id == taskToRemoveId)
                {
                    taskToRemove = task;
                    break;
                }
            }

            Tasks.Remove(taskToRemove);
            Console.WriteLine("Task removed");
            return taskToRemoveId;
        }

        public void ChangeTaskStatus()
        {
            Task task = new Task();
            ViewTasks();
            Console.WriteLine("Which Task have you completed? Choose task Id.");
            var userDeclaration = Console.ReadLine();
            int completedTaskId;
            Int32.TryParse(userDeclaration, out completedTaskId);

            foreach (var taskToChangeStatus in Tasks)
            {
                if (taskToChangeStatus.Id == completedTaskId)
                {
                    task = taskToChangeStatus;
                    break;
                }
            }
            if (task.Status == true)
            {
                task.Status = false;
            }
            else
            {
                task.Status = true;
            }
                    Console.WriteLine("Task status changed");

            
        }

        public void EditTask()
        {
            Task task = new Task();
            ViewTasks();
            Console.WriteLine("Which Task would you like to change?" );
            var userTaskChangeDeclaration = Console.ReadLine();
            int editTaskId;
            Int32.TryParse(userTaskChangeDeclaration, out editTaskId);
            foreach(var taskToEdit in Tasks )
            {
                if (task.Id == editTaskId)
                {
                    task = taskToEdit;
                }
            }
            /// Czy tak powinno robić się testy, które sprawdzają czy Id nie pokrywają się?
            Console.WriteLine("Please declare new Id for new task: ");
            var editedTaskNewIdDeclaration = Console.ReadLine();
            int idToCheck;
            Int32.TryParse(editedTaskNewIdDeclaration, out idToCheck);
            foreach (var editedTaskNewId in Tasks)
            {
                if (task.Id == idToCheck)
                {
                    Console.WriteLine("Id already used. Please select new Id");
                    break;

                }

            }
            Console.WriteLine("Please declare task new description: ");
            var editedTaskName = Console.ReadLine();
            task.Name = editedTaskName;
            Console.WriteLine("Parameters changed");

        }

        public void UndoneFiltrTask()
        {
            List<Task> undoneTask = new List<Task>();
                  
            foreach (var taskToShow in Tasks)
            {
                if (taskToShow.Status == false)
                {
                    undoneTask.Add(taskToShow);
                }
            }

            Console.WriteLine("Undone tasks: ");
            for (int i=0; i <= undoneTask.Count; i++)
            {
                Console.WriteLine(undoneTask[i].Id + " " + undoneTask[i].Name);
            }
            
        }
    }
}
