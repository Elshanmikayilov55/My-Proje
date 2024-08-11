using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarProje
{
    public class CarManager
    {
        List<Cars> carsList = new List<Cars>();


        public void AddCar(Cars car)
        {

            do
            {
                try
                {

                    Console.Write("Id:");
                    car.Id = Convert.ToInt32(Console.ReadLine());
                    break;
                }


                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);


            do
            {
                try
                {
                    Console.Write("Brand:");
                    car.Brand = Console.ReadLine();
                    if (car.Brand.Any(char.IsDigit))
                    {
                        throw new Exception("The Brand name is wrong!");
                    }
                    break;
                }


                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            } while (true);








            Console.Write("Model:");
            car.Model = Console.ReadLine();

            Console.Write("Color:");
            car.Color = (EnumofClass.Colors)Convert.ToInt32(Console.ReadLine());

            switch (car.Color)
            {
                case (EnumofClass.Colors)(int)EnumofClass.Colors.Black:
                    car.Color = EnumofClass.Colors.Black;
                    break;
                case (EnumofClass.Colors)(int)EnumofClass.Colors.White:
                    car.Color = EnumofClass.Colors.White;
                    break;
                case (EnumofClass.Colors)(int)EnumofClass.Colors.Silver:
                    car.Color = EnumofClass.Colors.Silver;
                    break;
            }


            Console.Write("Ban type:");
            car.BanType = (EnumofClass.Type)Convert.ToInt32(Console.ReadLine());
            switch (car.BanType)
            {
                case (EnumofClass.Type)(int)EnumofClass.Type.Sedan:
                    car.BanType = EnumofClass.Type.Sedan;
                    break;
                case (EnumofClass.Type)(int)EnumofClass.Type.Coupe:
                    car.BanType = EnumofClass.Type.Coupe;
                    break;
                case (EnumofClass.Type)(int)EnumofClass.Type.Pickup:
                    car.BanType = EnumofClass.Type.Pickup;
                    break;
                case (EnumofClass.Type)(int)EnumofClass.Type.Sport:
                    car.BanType = EnumofClass.Type.Sport;
                    break;
                case (EnumofClass.Type)(int)EnumofClass.Type.SUV:
                    car.BanType = EnumofClass.Type.SUV;
                    break;
                case (EnumofClass.Type)(int)EnumofClass.Type.Micro:
                    car.BanType = EnumofClass.Type.Micro;
                    break;

            }

            Console.Write("Create Year:");
            car.CreateYear = Console.ReadLine();


            Console.Write("Run:");
            car.Run = Console.ReadLine();

            carsList.Add(car);
            Console.WriteLine("Car is added");


        }

        public void DisplayCar()
        {

            foreach (Cars item in carsList)
            {



                Console.Write($"{item.Id}   |   {item.Brand}  |  {item.Model}  |  {item.BanType}  |  {item.Color}   | {item.CreateYear}  |  {item.Run}  | \n \n");


            }
        }

        public void Update()
        {

            Console.Write("to input id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Cars update = carsList.Find(x => x.Id == id);



            if (update is not null && update.Id == id)
            {

                Console.Write("Brand:");
                update.Brand = Console.ReadLine();

                Console.Write("Model:");
                update.Model = Console.ReadLine();

                Console.Write("Color:");
                update.Color = (EnumofClass.Colors)Convert.ToInt32(Console.ReadLine());

                switch (update.Color)
                {
                    case (EnumofClass.Colors)(int)EnumofClass.Colors.Black:
                        update.Color = EnumofClass.Colors.Black;
                        break;
                    case (EnumofClass.Colors)(int)EnumofClass.Colors.White:
                        update.Color = EnumofClass.Colors.White;
                        break;
                    case (EnumofClass.Colors)(int)EnumofClass.Colors.Silver:
                        update.Color = EnumofClass.Colors.Silver;
                        break;
                }


                Console.Write("Ban type:");
                update.BanType = (EnumofClass.Type)Convert.ToInt32(Console.ReadLine());
                switch (update.BanType)
                {
                    case (EnumofClass.Type)(int)EnumofClass.Type.Sedan:
                        update.BanType = EnumofClass.Type.Sedan;
                        break;
                    case (EnumofClass.Type)(int)EnumofClass.Type.Coupe:
                        update.BanType = EnumofClass.Type.Coupe;
                        break;
                    case (EnumofClass.Type)(int)EnumofClass.Type.Pickup:
                        update.BanType = EnumofClass.Type.Pickup;
                        break;
                    case (EnumofClass.Type)(int)EnumofClass.Type.Sport:
                        update.BanType = EnumofClass.Type.Sport;
                        break;
                    case (EnumofClass.Type)(int)EnumofClass.Type.SUV:
                        update.BanType = EnumofClass.Type.SUV;
                        break;
                    case (EnumofClass.Type)(int)EnumofClass.Type.Micro:
                        update.BanType = EnumofClass.Type.Micro;
                        break;
                }

                Console.Write("Create Year:");
                update.CreateYear = Console.ReadLine();
                Console.Write("Run:");
                update.Run = Console.ReadLine();

                carsList.Add(update);
                Console.WriteLine("Car is added");


            }

            else
            {
                Console.WriteLine("The car isn't exist!");
            }




        }

        public void Delete()
        {
            int id = Convert.ToInt32(Console.ReadLine());
            Cars delete = carsList.Find(x => x.Id == id);

            if (delete is not null && delete.Id == id)
            {
                carsList.Remove(delete);
                Console.WriteLine("This car deleted.");
            }

            else
            {

                Console.WriteLine("This car isn't exist!!!");
            }



        }
    }
}

