namespace ConsoleTodoList;

public class Todo
{
    private List<string> todos = new List<string>();

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
            Console.WriteLine("Enter your choice:");

            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        break;
                    case 3:
                        ViewTasks();
                        break;
                    case 4:
                        isMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid number.");
                        PressEnter();
                        continue;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Input must be in a correct format");
                PressEnter();
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

            if (userInput == null)
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

    private void ViewTasks()
    {
        Console.WriteLine("Current Tasks");
        foreach (var todo in todos)
        {
            Console.WriteLine($"- {todo}");
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
