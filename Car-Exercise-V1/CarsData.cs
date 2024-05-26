namespace Car_Exercise_V1
{
    internal class CarsData : Cars
    {
        public CarsData()
        {
        }

        public object Context { get; private set; }

        public void AddNewCar()
        {
            MyDbContext Context = new MyDbContext();
            Cars carsadd = new Cars();
            string UserInput = "";
            while (UserInput != "5")
            {

                Console.WriteLine("add a new car barnd:");
                carsadd.Brand = Console.ReadLine();


                Console.WriteLine("add a new car model:");
                carsadd.Model = Console.ReadLine();



                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine("add a year:");
                    carsadd.Year = int.Parse(Console.ReadLine());

                    break;
                }
            }

            Context.cars.Add(carsadd);
            Context.SaveChanges();
            Console.WriteLine("a new car added to the table");
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

            Console.WriteLine("Enter car id to delete");
            carsdelete.Id = int.Parse(Console.ReadLine());

            Context.cars.Remove(carsdelete);
            Context.SaveChanges();
            Console.WriteLine("car deleted");
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
