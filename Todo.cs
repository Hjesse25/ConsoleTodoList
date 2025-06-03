namespace ConsoleTodoList;

public class Todo
{
    private List<string> todos = new List<string>();

    // Prints the menu to the console
    public void WelcomeMenu()
    {
        Console.Clear();

        bool isMenu = true;
        do
        {
            Console.WriteLine("Todo List App");
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. Remove task");
            Console.WriteLine("3. View tasks");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");


            string choice = Console.ReadLine() ?? "";

            switch (choice.Trim())
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    RemoveTask();
                    break;
                case "3":
                    ViewTasks();
                    break;
                case "4":
                    isMenu = false;
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    PressEnter();
                    continue;
            }
        } while (isMenu);
    }

    // Allows the user to enter a new task
    private void AddTask()
    {
        bool isValid = false;
        while (isValid == false)
        {
            Console.WriteLine("Enter task:");
            string userInput = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Task cannot be empty.");
            }
            else
            {
                string newTask = userInput.Trim();
                todos.Add(newTask);
                Console.WriteLine($"Your task \"{newTask}\" has been added.");
                PressEnter();
                isValid = true;
            }
        }
    }

    // View the current tasks
    private void ViewTasks()
    {
        if (!todos.Any())
        {
            Console.WriteLine("There are no tasks currently");
        }
        else
        {
            Console.WriteLine("Current Tasks");
            for (int i = 0; i < todos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todos[i]}");
            }
        }
        Console.WriteLine();
        PressEnter();
    }

    // Removes a specific task
    private void RemoveTask()
    {
        if (!todos.Any())
        {
            Console.WriteLine("There are no tasks currently");
        }
        else
        {
            Console.WriteLine("Select a task to remove");
            for (int i = 0; i < todos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todos[i]}");
            }

            Console.Write("Enter the number: ");
            string input = Console.ReadLine() ?? "";

            if (int.TryParse(input, out int todoId) && todoId >= 1 && todoId <= todos.Count)
            {
                string removed = todos[todoId - 1];
                todos.RemoveAt(todoId - 1);
                Console.WriteLine($"Removed: {removed}");
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }

        Console.WriteLine();
        PressEnter();
    }

    private static void PressEnter()
    {
        Console.WriteLine("Press any key to continue..");
        Console.ReadLine();
        Console.Clear();
    }
}
