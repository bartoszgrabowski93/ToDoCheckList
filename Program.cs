using System;
using System.Collections.Generic;

namespace ToDoCheckList
{
    class Program
    {
        static void Main(string[] args)
        {

            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);
            TaskService taskService = new TaskService();

            /// Welcome User and show possible options
            /// 
            Console.WriteLine("Welcome in ToDoCheckList!");


            while (true)
            {
                Console.WriteLine("What would u like to do:");
                var mainMenu = actionService.GetMenuActionsByMenuName("Main");

                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                }


                var userMenuChoice = Console.ReadKey();
                

                switch (userMenuChoice.KeyChar)
                {
                    case '1':
                        Console.WriteLine(" ");
                        var id = taskService.AddTask();
                        break;
                    case '2':
                        Console.WriteLine(" ");
                        taskService.ChangeTaskStatus();
                        break;
                    case '3':
                        Console.WriteLine(" ");
                        taskService.EditTask();
                        break;
                    case '4':
                        Console.WriteLine(" ");
                        var removeId = taskService.RemoveTask();
                        break;
                    case '5':
                        Console.WriteLine(" ");
                        taskService.ViewTasks();
                        break;
                    case '6':
                        Console.WriteLine(" ");
                        taskService.ViewTaskDetails();
                        break;
                    case '7':
                        Console.WriteLine(" ");
                        taskService.UndoneFiltrTask();
                        break;
                    default:
                        Console.WriteLine("Action does not exist.");
                        break;
                }
            }


            /// 
            /// Options:
            /// 2. Change task status to complete/undone
            /// 3. Edit task
            /// 4. Delete task
            /// 5. Sort tasks by ID, priority or status
            /// 
            ///     1c. Ask User for date
            ///     1d. Ask User for task priority 
            ///     
            ///     2a. Show all tasks
            ///     2b. Ask User which task status should be changed
            ///     2c. Change status of the task
            ///     
            ///     3a. Show all tasks
            ///     3b. Ask User which task to change
            ///     3c. Ask which parameter should be changed / or all
            ///     3d. Change parameter
            ///     
            ///     4a. Show all tasks
            ///     4b. Ask User for declaration which to delete
            ///     4c. Delete task
            ///     
            ///     5a. Ask user for main parameter to filter
            ///     5b. Filter by parameter chosen by User
            ///     5b. Show filtered tasks 

            

        }

        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Add Task", "Main");
            actionService.AddNewAction(2, "Change Task Status", "Main");
            actionService.AddNewAction(3, "Edit Task", "Main");
            actionService.AddNewAction(4, "Remove Task", "Main");
            actionService.AddNewAction(5, "View Tasks", "Main");
            actionService.AddNewAction(6, "View Task Details", "Main");
            actionService.AddNewAction(7, "Show undone tasks", "Main");
            return actionService;
        }
    }
}
