namespace Car_Exercise_V1
{
    internal class Menu : CarsData
    {
        public Menu()
        {

            Console.WriteLine("\nChoose a number, and press enter to continu");
            Console.WriteLine("1. list all cars:");
            Console.WriteLine("2. Add a new car:");
            Console.WriteLine("3. Edit a car:");
            Console.WriteLine("4. Delete a car:");
            Console.WriteLine("5. Exit applacation!");

            
            while (true)
            {
               // Console.Clear();
               // Console.CursorVisible = false;
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("1. list all cars:");
                        break;
                    case "2":
                        AddNewCar();
                        break;
                    case "3":
                        EditCar();
                        break;
                    case "4":
                        Console.WriteLine("4. Delete a car:");
                        break;
                    case "5":
                        Console.WriteLine("5");
                        return;
                    default:
                        Console.WriteLine("Invalid input, continue showing the menu");
                        break;
                }

            }

                
            






        }
    }
}
