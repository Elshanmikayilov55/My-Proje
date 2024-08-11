using CarProje;



CarManager carManagers = new();



Console.WriteLine("1- Add car");
Console.WriteLine("2- Update car");
Console.WriteLine("3- Delete car");



do
{
    Console.WriteLine("to input operation:");
    int operation = Convert.ToInt32(Console.ReadLine());

    switch (operation)
    {
        case (int)EnumofClass.Operation.Add:
            Console.WriteLine("Add car:");
            Cars car1 = new Cars();
            carManagers.AddCar(car1);
            carManagers.DisplayCar();
            break;

        case (int)EnumofClass.Operation.Update:
            Console.WriteLine("Update:");
            carManagers.Update();
            carManagers.DisplayCar();


            break;

        case (int)EnumofClass.Operation.Delete:

            Console.WriteLine("Delete:");
            carManagers.Delete();

            break;

    }
} while (true);