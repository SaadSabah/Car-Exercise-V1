namespace Car_Exercise_V1
{
    internal class CarsData : Cars
    {
        public CarsData()
        {
        }

        public object Context { get; private set; }

        //public void AddNewCar()
        //{
        //    MyDbContext Context = new MyDbContext();
        //    Cars carsadd = new Cars();
        //    string UserInput = "";

        //    while (UserInput != "5")
        //    {





        //            Console.Write("brand:");
        //            string Brand = Console.ReadLine();
        //            if (!string.IsNullOrEmpty(Brand))
        //            {
        //                Console.WriteLine("brand added");
        //                carsadd.Brand = Brand;
        //            }

        //            else
        //            {
        //                Console.WriteLine("brand can not be empty");
        //                return;
        //            }

        //            Console.Write("model:");
        //            string Model = Console.ReadLine();
        //            if (!string.IsNullOrEmpty(Model))
        //            {
        //                Console.WriteLine("model added");
        //                carsadd.Model = Model;
        //            }
        //            else
        //            {
        //                Console.WriteLine("model can not be empty");
        //                return;
        //            }

        //            Console.Write("Year:");
        //            string input = Console.ReadLine();

        //            if (int.TryParse(Console.ReadLine(), out int parsedYear))
        //            {
        //                if (parsedYear <= 0)
        //                {
        //                    Console.WriteLine("Year added");
        //                    carsadd.Year = parsedYear;
        //                }

        //                else
        //                {
        //                    Console.WriteLine("Invalid year. Year must be non-negative.");
        //                    return;
        //                }
        //            }
        //            else if (string.IsNullOrWhiteSpace(input))
        //            {
        //                Console.WriteLine("Year is empty");
        //                break;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Invalid input. Please enter a valid year.");
        //            }

        //            Context.cars.Add(carsadd);

        //            Console.WriteLine("save changes y/n");
        //            string answer = Console.ReadLine();
        //            if (!string.IsNullOrEmpty(answer))
        //            {
        //                if (answer.ToString().Trim().ToLower() != "y")
        //                {
        //                    AddNewCar();
        //                }
        //                else
        //                {
        //                    Context.SaveChanges();
        //                    Console.WriteLine("a new car added to the table");
        //                    break;
        //                }
        //            }



        //        }
        //}
        public void AddNewCar()
        {
            MyDbContext Context = new MyDbContext();
            Cars carsadd = new Cars();

            while (true)  // Use an infinite loop and break when successful
            {
                try
                {
                    Console.Write("Brand: ");
                    string Brand = Console.ReadLine();
                    if (string.IsNullOrEmpty(Brand))
                    {
                        Console.WriteLine("Brand cannot be empty");
                        continue;  // Ask for the brand again
                    }
                    carsadd.Brand = Brand;

                    Console.Write("Model: ");
                    string Model = Console.ReadLine();
                    if (string.IsNullOrEmpty(Model))
                    {
                        Console.WriteLine("Model cannot be empty");
                        continue; // Ask for the model again
                    }
                    carsadd.Model = Model;

                    Console.Write("Year: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int parsedYear) && parsedYear >= 0)
                    {
                        carsadd.Year = parsedYear;
                    }
                    else
                    {
                        Console.WriteLine("Invalid year. Year must be non-negative.");
                        continue; // Ask for the year again
                    }

                    // ... (Add other car property inputs here, with similar validation)

                    Context.cars.Add(carsadd);

                    Console.WriteLine("Save changes (y/n)?");
                    string answer = Console.ReadLine()?.Trim().ToLower(); // Safe navigation and trim
                    if (answer == "y")
                    {
                        Context.SaveChanges();
                        Console.WriteLine("A new car added to the table");
                        break; // Exit the loop successfully
                    }
                    else if (answer == "n")
                    {
                        Console.WriteLine("Changes not saved.");
                        break; // Exit the loop without saving
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    // You might want to log this exception for later analysis
                }
            }
        }

        public void EditCar()
        {
            MyDbContext Context = new MyDbContext();
            Cars carsupdate = new Cars();

            Console.WriteLine("enter id to edit:");
            carsupdate.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("new brand:");
            carsupdate.Brand = Console.ReadLine();

            Console.WriteLine("new model:");
            carsupdate.Model = Console.ReadLine();



            if (int.TryParse(Console.ReadLine(), out int num))

                Console.WriteLine("add a year:");
            carsupdate.Year = int.Parse(Console.ReadLine());



            Context.cars.Update(carsupdate);
            Context.SaveChanges();
            Console.WriteLine("updeted succssed");

        }

        public void DeleteCar()
        {
            MyDbContext Context = new MyDbContext();
            Cars carsdelete = new Cars();

            Console.WriteLine("Enter car id to delete".ToUpper());
            carsdelete.Id = int.Parse(Console.ReadLine());

            Context.cars.Remove(carsdelete);
            Context.SaveChanges();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("car deleted".ToUpper());
            Console.Beep();
            Console.ResetColor();
        }

        public void ListAllCars()
        {
            MyDbContext Context = new MyDbContext();
            List<Cars> carslist = Context.cars.ToList();


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("   " + "CAR BRAND".PadRight(20) + "CAR MODEL".PadRight(20) + "YEAR");
            Console.ResetColor();
            Console.WriteLine("\n");
            int i = 1;
            foreach (var item in carslist)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{i}. {item.Brand.ToString().PadRight(20)}" +
                    $"{item.Model.ToString().PadRight(20)}{item.Year}");
                Console.ResetColor();
                i++;
            }
        }

    }



}
