﻿namespace Car_Exercise_V1
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
    }


}
