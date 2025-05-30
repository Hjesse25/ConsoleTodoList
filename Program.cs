Menu();

void Menu()
{
    bool isMenu = true;
    do
    {
        Console.WriteLine("Todo List App");
        Console.WriteLine("1. Add task");
        Console.WriteLine("2. Remove task");
        Console.WriteLine("3. View tasks");
        Console.WriteLine("4. Exit");

        try
        {
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    isMenu = false;
                    break;
                default:
                    Console.WriteLine("Invalid number.");
                    continue;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Input must be in a correct format");
        }
        finally
        {
            Console.WriteLine();
        }
    } while (isMenu);
}