
using project_class_;

var car1 = new Car()
{
    Model = "maserati",
    Price = 9000,
    IsUsed = true,
    
};

var car2 = new Car()
{
    Model = "McLaren",
    Price = 16500,
    IsUsed = false,
};

var car3 = new Car()
{
    Model = "Porsche",
    Price = 12700,
    IsUsed = true,
};

var seller = new User()
{
    UserName = "seller/Sandro",
    Password = "Sardiona",
    Amount = 2500,
};

var bougther = new User()
{
    UserName = "bougther/Durexa",
    Password = "Durexinio",
    Amount = 30000,
};

seller.UserCars.Add(car1);
seller.UserCars.Add(car2);
seller.UserCars.Add(car3);



while (true)
{
    bougther.ShowUserInformation();
    bougther.ShowOwnedCars();
    Console.WriteLine();
    seller.ShowUserInformation();
    seller.ShowOwnedCars();
    Console.WriteLine();
    
    
    var UserChoice = int.Parse(Console.ReadLine());

    if (UserChoice < 0 || UserChoice > seller.UserCars.Count)
    {
        Console.WriteLine("Wrong Input");
        continue;
    }
    var ChoosenCar = seller.UserCars[UserChoice - 1];
    Console.Clear();
    Console.WriteLine( "you have choosen:");
    ChoosenCar.ShowInformation();
    Console.WriteLine();
    var userPurchaseCar = bougther.PurchaseCar(ChoosenCar);
    if (userPurchaseCar)
    {
        seller.Amount += ChoosenCar.Price;
        seller.RemoveCar(ChoosenCar);

    }
    
}



