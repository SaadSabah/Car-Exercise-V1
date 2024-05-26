namespace Car_Exercise_V1
{
    internal class Menu : CarsData
    {
        public Menu()
        {

           


            while (true)
            {
                Console.WriteLine("\n...............................................");
                Console.WriteLine("Choose a number, and press Enter to continue:".ToUpper());
                Console.WriteLine("...............................................");
                Console.WriteLine("1. List all cars".ToUpper());
                Console.WriteLine("2. Add a new car".ToUpper());
                Console.WriteLine("3. Edit a car".ToUpper());
                Console.WriteLine("4. Delete a car".ToUpper());
                Console.WriteLine("5. Exit application".ToUpper());
                Console.WriteLine("\n_______________________");

                switch (Console.ReadLine())
                {
                    case "1":
                        ListAllCars();
                        break;
                    case "2":
                        AddNewCar();
                        break;
                    case "3":
                        EditCar();
                        break;
                    case "4":
                        DeleteCar();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid input. Continuing to show the menu.".ToUpper());
                        break;
                }

            }

                
            






        }
    }
}
