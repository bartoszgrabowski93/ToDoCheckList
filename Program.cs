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
